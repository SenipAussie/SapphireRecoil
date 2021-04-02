using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static Sens_Sapphire_Recoil.Variables;

namespace Sens_Sapphire_Recoil
{
    static class Recoil
    {
        [STAThread]
        static void Main()
        {
            Thread recoil_thread = new Thread(RecoilThread);
            recoil_thread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SapphireRecoil());
        }

        [DllImport("user32.dll")] public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, UIntPtr dwExtraInfo);
        [DllImport("user32.dll")] private static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyDown(Keys key)
        { return 0 != (GetAsyncKeyState((int)key) & 0x8000); }

        private static void RecoilThread()
        {
            while (isAlive())
            {
                if (getEnabledBool())
                    while (IsKeyDown(Keys.LButton) && IsKeyDown(Keys.RButton))
                    {
                        for (int i = 0; i <= getAmmo() - 1; i++)
                        {
                            if (!IsKeyDown(Keys.LButton)) break;
                            Smoothing(isMuzzleBoost(getShootingMS()),
                            isMuzzleBoost(getShotDelay(i)),
                            (int)((((getRecoilX(i) + GetRandomNumber(0.0, getRandomness())) / 4) / getSensitivity()) * getScopeMulitplier() * getBarrelMultiplier() * getFOVMultiplier()),
                            (int)((((getRecoilY(i) + GetRandomNumber(0.0, getRandomness())) / 4) / getSensitivity()) * getScopeMulitplier() * getBarrelMultiplier() * getFOVMultiplier()));
                            mouse_event(0x0001, 0, 0, 0, UIntPtr.Zero);
                        }
                    }
                Thread.Sleep(1);
            }
        }

        static void Smoothing(double MS, double ControlledTime, int X, int Y)
        {
            int oldX = 0, oldY = 0, oldT = 0;
            for (int i = 1; i <= (int)ControlledTime; ++i)
            {
                int newX = i * X / (int)ControlledTime;
                int newY = i * Y / (int)ControlledTime;
                int newTime = i * (int)ControlledTime / (int)ControlledTime;
                mouse_event(1, newX - oldX, newY - oldY, 0, UIntPtr.Zero);
                PerciseSleep(newTime - oldT);
                oldX = newX; oldY = newY; oldT = newTime;
            }
            PerciseSleep((int)MS - (int)ControlledTime);
        }

        [DllImport("Kernel32.dll")] private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [DllImport("Kernel32.dll")] private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        private static void PerciseSleep(int ms)
        {
            QueryPerformanceFrequency(out long timerResolution);
            timerResolution /= 1000;

            QueryPerformanceCounter(out long currentTime);
            long wantedTime = currentTime / timerResolution + ms;
            currentTime = 0;
            while (currentTime < wantedTime)
            {
                QueryPerformanceCounter(out currentTime);
                currentTime /= timerResolution;
            }
        }
    }
}
