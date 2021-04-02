using System;
using System.Drawing;
using System.Windows.Forms;
using static Sens_Sapphire_Recoil.Variables;
using static Sens_Sapphire_Recoil.RecoilTables;

namespace Sens_Sapphire_Recoil
{
    public partial class SapphireRecoil : Form
    {
        public SapphireRecoil()
        {
            InitializeComponent();
            lblInfo.Text = "Type: Public | Built: " + DateTime.Now;
        }
        #region MoveablePanels
        // Ignore this area of the code, It just allows users to move the form around without a standard boarder.
        Point Offset { get; set; }
        private void btnMin_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); terminateThread(); }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e) { Offset = new Point(MousePosition.X - Bounds.X, MousePosition.Y - Bounds.Y); }
        private void lblTitle_MouseMove(object sender, MouseEventArgs e) { if (Control.MouseButtons == MouseButtons.Left) this.SetDesktopLocation(MousePosition.X - Offset.X, MousePosition.Y - Offset.Y); }
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e) { Offset = new Point(MousePosition.X - Bounds.X, MousePosition.Y - Bounds.Y); }
        private void pnlTitle_MouseMove(object sender, MouseEventArgs e) { if (Control.MouseButtons == MouseButtons.Left) this.SetDesktopLocation(MousePosition.X - Offset.X, MousePosition.Y - Offset.Y); }
        private void pnlColor_MouseDown(object sender, MouseEventArgs e) { Offset = new Point(MousePosition.X - Bounds.X, MousePosition.Y - Bounds.Y); }
        private void pnlColor_MouseMove(object sender, MouseEventArgs e) { if (Control.MouseButtons == MouseButtons.Left) this.SetDesktopLocation(MousePosition.X - Offset.X, MousePosition.Y - Offset.Y); }    
        private void picIcon_MouseDown(object sender, MouseEventArgs e) { Offset = new Point(MousePosition.X - Bounds.X, MousePosition.Y - Bounds.Y); }
        private void picIcon_MouseMove(object sender, MouseEventArgs e) { if (Control.MouseButtons == MouseButtons.Left) this.SetDesktopLocation(MousePosition.X - Offset.X, MousePosition.Y - Offset.Y); }
        #endregion
        #region Custom Menu Design
        private void cboWeapons_DrawItem(object sender, DrawItemEventArgs e)
        {
            cboWeapons.DataSource = WeaponList;
            DrawItems(sender, e);
        }

        private void cboScopes_DrawItem(object sender, DrawItemEventArgs e)
        {
            cboScopes.DataSource = ScopeList;
            DrawItems(sender, e);
        }

        private void cboBarrels_DrawItem(object sender, DrawItemEventArgs e)
        {
            cboBarrels.DataSource = BarrelList;
            DrawItems(sender, e);
        }

        private static void DrawItems(object sender, DrawItemEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                e.DrawBackground();
                if (e.Index >= 0)
                {
                    StringFormat sf = new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    };
                    Brush brush = new SolidBrush(cbx.ForeColor);
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;
                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }
        #endregion

        private static readonly string[] WeaponList = {
            "Assault Rifle",
            "LR-300",
            "SAR",
            "Custom SMG",
            "MP5",
            "Thompson",
            "M39",
            "M92",
            "M249"
        };

        private static readonly string[] ScopeList = {
            "None",
            "Simple",
            "Holo",
            "8x",
            "16x"
        };

        private static readonly string[] BarrelList = {
            "None",
            "Suppressor",
            "Muzzle Boost",
            "Muzzle Break"
        };

        private void trkbarRandomness_Scroll(object sender, EventArgs e)
        {
            lblRandomnessValue.Text = trkbarRandomness.Value.ToString();
            setRandomness(double.Parse(lblRandomnessValue.Text));
        }

        private void trkbarSens_Scroll(object sender, EventArgs e)
        {
            lblGameSensValue.Text = (trkbarSens.Value * 0.1).ToString();
            setSensitivity(double.Parse(lblGameSensValue.Text));
        }

        private void trkbarFOV_Scroll(object sender, EventArgs e)
        {
            lblGameFOVValue.Text = trkbarFOV.Value.ToString();
            setFOV(double.Parse(lblGameFOVValue.Text));
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            setEnabledBool();
            if (getEnabledBool())
                btnEnable.Text = "Stop";
            else
                btnEnable.Text = "Start";
        }

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboWeapons.SelectedIndex)
            {
                case 0: // AssaultRifle
                    setWeaponInfo(AssaultRifle, AssaultRifleControlTime, 133, 29);
                    break;
                case 1: // LR300AssaultRifle
                    setWeaponInfo(LR300AssaultRifle, LRControlTime, 120, 29);
                    break;
                case 2: // SemiAssultRifle
                    setWeaponInfo(SemiAssultRifle, SemiControlTime, 175, 1);
                    break;
                case 3: // CustomSMG
                    setWeaponInfo(CustomSMG, CustomSMGControlTime, 100, 23);
                    break;
                case 4: // MP5A4
                   setWeaponInfo(MP5A4, MP5A4ControlTime, 120, 29);
                    break;
                case 5: // Thompson
                    setWeaponInfo(Thompson, ThompsonControlTime, 130, 19);
                    break;
                case 6: // M92
                    setWeaponInfo(M92, M92Time, 100, 1);
                    break;
                case 7: // M39
                    setWeaponInfo(M39, M39ControlTime, 200, 1);
                    break;
                case 8: // M249
                    setWeaponInfo(M249, M249ControlTime, 120, 99);
                    break;
            }
        }

        private void cboScopes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboScopes.SelectedIndex)
            {
                case 0: // None
                    setScopeAndMultiplier("None", 1.0);
                    break;
                case 1: // Simple
                    setScopeAndMultiplier("Simple scope", 0.8);
                    break;
                case 2: // Holo 
                    setScopeAndMultiplier("Holo scope", 1.2);
                    break;
                case 3: // 8x
                    setScopeAndMultiplier("8x scope", 3.83721);
                    break;
                case 4: // 16x
                    setScopeAndMultiplier("16x scope", 7.65116);
                    break;
            }
        }

        private void cboBarrels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBarrels.SelectedIndex)
            {
                case 0: // None
                    setBarrelAndMultiplier("None", 1.0);
                    break;
                case 1: // Suppressor
                    setBarrelAndMultiplier("Suppressor", 0.8);
                    break;
                case 2: // Muzzle Booster
                    setBarrelAndMultiplier("Muzzle boost", 1.0);
                    hasMuzzleBoost(true);
                    break;
                case 3: // Muzzle Break
                    setBarrelAndMultiplier("Muzzle break", 0.5);
                    hasMuzzleBoost(false);
                    break;
            }
        }
    }
}
