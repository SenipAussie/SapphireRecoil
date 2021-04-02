using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sens_Sapphire_Recoil
{
    class Variables
    {
        // Stops the Thread gracefully when the program is exited
        private static bool threadIsAlive { get; set; } = true;

        public static bool isAlive()
        { return threadIsAlive; }

        public static void terminateThread() { threadIsAlive = false; }

        // Start / Stop button
        private static bool isEnabled { get; set; } = false;

        public static void setEnabledBool()
        { isEnabled = !isEnabled; }

        public static bool getEnabledBool()
        { return isEnabled; }

        // General Variables
        private static int[,] ActiveRecoil { get; set; } = { { 0, 0 } };
        private static double[] Delay { get; set; } = { 0 };
        private static int ShootingMS { get; set; } = 0;
        private static int Ammo { get; set; } = 0;

        private static string Scope { get; set; } = "None";
        private static double ScopeMulitplier { get; set; } = 1.0;

        private static string Barrel { get; set; } = "None";
        private static double BarrelMultiplier { get; set; } = 1.0;
        private static bool MuzzleBoost { get; set; } = false;

        private static double Randomness { get; set; } = 5.0;
        private static double Sensitivity { get; set; } = 1.0;
        private static double FOV { get; set; } = 90.0;

        public static void setWeaponInfo(int[,] ActiveRecoilTable, double[] DelayValue, int ShootingMSValue, int AmmoValue)
        {
            ActiveRecoil = ActiveRecoilTable;
            Delay = DelayValue;
            ShootingMS = ShootingMSValue;
            Ammo = AmmoValue;
        }

        // RECOIL ARRAY INDEX RETURNER
        public static int getRecoilX(int Bullet)
        { return ActiveRecoil[Bullet, 0]; }

        public static int getRecoilY(int Bullet)
        { return ActiveRecoil[Bullet, 1]; }

        // MS / SHOT DELAY FOR SMOOTHING
        public static int getShootingMS()
        { return ShootingMS; }

        public static double getShotDelay(int Bullet)
        { return Delay[Bullet]; }

        // AMMO
        public static int getAmmo()
        { return Ammo; }

        // SCOPES ATTACHMENTS
        public static void setScopeAndMultiplier(string scope, double value)
        {
            Scope = scope;
            ScopeMulitplier = value;
        }

        public static double getScopeMulitplier()
        { return ScopeMulitplier; }

        // BARREL ATTACHMENTS
        public static void setBarrelAndMultiplier(string barrel, double value)
        {
            Barrel = barrel;
            ScopeMulitplier = value;
        }

        public static double getBarrelMultiplier()
        { return BarrelMultiplier; }

        public static void hasMuzzleBoost(bool value)
        { MuzzleBoost = value; }

        public static double isMuzzleBoost(double MS)
        {
            if (MuzzleBoost)
                return (MS - (MS * 0.1f));
            else
                return MS;
        }

        // MISC SETTINGS
        public static void setRandomness(double RandomnessValue)
        { Randomness = RandomnessValue; }

        public static double getRandomness()
        { return Randomness; }

        public static void setSensitivity(double SensitivityValue)
        { Sensitivity = SensitivityValue; }

        public static double getSensitivity()
        { return Sensitivity; }

        public static void setFOV(double FOVValue)
        { FOV = FOVValue; }

        public static double getFOVMultiplier()
        {
            if (FOV < 75)
                return 1.2;
            else if (FOV < 85)
                return 1.1;
            else
                return 1.0;
        }

        // RECOIL RANDOMIZER
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static int GetRandomSleep()
        {
            Random random = new Random();
            return random.Next(36, 50);
        }
    }
}
