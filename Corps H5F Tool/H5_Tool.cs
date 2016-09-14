using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corps_H5F_Tool
{
    public partial class H5_Tool : Form
    {
        public H5_Tool()
        {
            InitializeComponent();

            FovTrackBar.Minimum = 65;
            FovTrackBar.Maximum = 150;
            ResTrackBar.Minimum = 840;
            ResTrackBar.Maximum = 7680;
            FPSTrackBar.Minimum = 30;
            FPSTrackBar.Maximum = 300;
            Process[] pname = Process.GetProcessesByName("notepad");
            if (pname.Length == 0)
            {
                FovInput.Value = 78;
                FPSInput.Value = 60;
            }

            else
            {
                FovInput.Value = Convert.ToDecimal(fetch_fov());
                FPSInput.Value = fetch_fps();
            }
            FovTrackBar.Value = Convert.ToInt32(FovInput.Value);    
            ResInput.Value = 1920;
            ResTrackBar.Value = 1920;
            FPSTrackBar.Value = Convert.ToInt32(FPSInput.Value);

            IDictionary maps = new Dictionary<string, string> {
                {"Alpine", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Breakout Arena", @"levels\multi\fo03_space\fo03_space"},
                {"Coliseum", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Eden", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Empire", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Fathom", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Glacier", @"levels\multi\fo02_glacier\fo02_glacier"},
                {"Mercy", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Molten", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Overgrowth", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Plaza", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Regret", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Riptide", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Stasis", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"The Rig", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Tidal", @"levels\multi\fo04_ocean\fo04_ocean"},
                {"Torque", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Truth", @"levels\multi\ng43_midship\ng43_midship"},
                {"Tyrant", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"}
            };

            TutorialMapChangerMaps.DataSource = new BindingSource(maps, null);
            TutorialMapChangerMaps.DisplayMember = "Key";
            TutorialMapChangerMaps.ValueMember = "Value";
        }

        const string ApplicationUserModelID = @"Microsoft.Halo5Forge_8wekyb3d8bbwe!Ausar"; 
        const string PackageID = @"Microsoft.Halo5Forge_1.114.4592.2_x64__8wekyb3d8bbwe";
        
        private void FovChange_Click(object sender, EventArgs e)
        {
            Int32 addr = 0x58ECF90;

            float fovval = (float)FovInput.Value;

            byte[] fov = BitConverter.GetBytes(fovval);

            MemoryManager.WriteToAddress(addr, fov);
        }

        private void ResChange_Click(object sender, EventArgs e)
        {
            //Int32 addr = 0x58ECF90;

            //int test = (int)ResInput.Value;

            //byte[] res = BitConverter.GetBytes(test);

            //MemoryManager.WriteToAddress(addr, res);
        }

        private void TutorialMapChangerChange_Click(object sender, EventArgs e)
        {
            Int32 addr = 0x3A25DA0;

            string mapval = TutorialMapChangerMaps.SelectedValue.ToString();

            byte[] map = Encoding.ASCII.GetBytes(mapval);

            MemoryManager.WriteToAddress(addr, map);
        }

        private void FovTrackBarScroll(object sender, EventArgs e)
        {
            FovInput.Value = FovTrackBar.Value;
        }

        private void ResTrackBarScroll(object sender, EventArgs e)
        {
            ResInput.Value = ResTrackBar.Value;
        }

        private void change_fps(int fps, Int32 addr)
        {
            byte[] fpsval = BitConverter.GetBytes(fps);

            MemoryManager.WriteToAddress(addr, fpsval);
        }

        public static int fetch_fps()
        {
            int fps_div = BitConverter.ToInt16(MemoryManager.ReadFromAddress(0x34B8C50), 0);
            int fps = 1000000 / fps_div;
            return fps;
        }

        public static float fetch_fov()
        {
            float fov = BitConverter.ToSingle(MemoryManager.ReadFromAddress(0x58ECF90), 0);
            return fov;
        }

        private void FPSChange_Click(object sender, EventArgs e)
        {
            change_fps(1000000 / Convert.ToInt16(FPSInput.Value), 0x34B8C50);
            change_fps(1000000 / Convert.ToInt16(FPSInput.Value), 0x34B8C60);
            change_fps(1000000 / Convert.ToInt16(FPSInput.Value), 0x34B8C70);
        }

        private void H5Launcher_Click(object sender, EventArgs e)
        {
            ProcessStartInfo halo5info = new ProcessStartInfo();
            halo5info.FileName = "halo5forge.exe";
            Process.Start(halo5info);
        }

        private void FPSTrackBarScroll(object sender, EventArgs e)
        {
            FPSInput.Value = FPSTrackBar.Value;
        }
    }
}
