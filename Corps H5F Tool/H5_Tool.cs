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
        public float defaultFoV = 0f;

        public H5_Tool()
        {            

            InitializeComponent();

            FovTrackBar.Minimum = 65;
            FovTrackBar.Maximum = 150;
            ResTrackBar.Minimum = 840;
            ResTrackBar.Maximum = 7680;
            RESHeightTrackBar.Minimum = 480;
            RESHeightTrackBar.Maximum = 4320;
            FPSTrackBar.Minimum = 30;
            FPSTrackBar.Maximum = 300;

            if (isGameRunning())
            {                
                FovInput.Value = Convert.ToDecimal(fetch_fov());
                FPSInput.Value = fetch_fps();
                H5Launcher.Visible = false;
            }
            else
            {
                FovInput.Value = 78;
                FPSInput.Value = 60;
                H5Launcher.Visible = true;
            }

            defaultFoV = (float)FovInput.Value;

            FovTrackBar.Value = Convert.ToInt32(FovInput.Value);    
            ResInput.Value = 1920;
            ResTrackBar.Value = 1920;
            FPSTrackBar.Value = Convert.ToInt32(FPSInput.Value);

            IDictionary maps = new Dictionary<string, string> {
                {"Alpine", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Breakout Arena", @"levels\multi\fo_arena_breakout\fo_arena_breakout"},
                {"Coliseum", @"levels\multi\ng50_ss_coliseum\ng50_ss_coliseum"},
                //{"Eden", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Empire", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Fathom", @"levels\multi\ng23_ss_skew\ng23_ss_skew"},
                {"Glacier", @"levels\multi\fo02_glacier\fo02_glacier"},
                //{"Mercy", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Molten", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Overgrowth", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Plaza", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Regret", @"levels\multi\ng43r_midship_remix\ng43r_midship_remix"},
                //{"Riptide", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Stasis", @"levels\multi\ng25_ss_pistons_remix\ng25_ss_pistons_remix"},
                //{"The Rig", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Tidal", @"levels\multi\fo04_ocean\fo04_ocean"},
                {"Torque", @"levels\multi\ng25_ss_pistons\ng25_ss_pistons"},
                {"Truth", @"levels\multi\ng43_midship\ng43_midship"},
                //{"Tyrant", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Parallax", @"levels\multi\fo03_space\fo03_space"},
                // ng11_la_courtyard
                // ng20_sa_towers\ng20_sa_towers crash
                // ng23_ss_skew = fathom
                //ng50r_ss_coliseum_remix
                //levels\multi\ng50r_ss_coliseum_remix\ng50r_ss_coliseum_remix
            };

            TutorialMapChangerMaps.DataSource = new BindingSource(maps, null);
            TutorialMapChangerMaps.DisplayMember = "Key";
            TutorialMapChangerMaps.ValueMember = "Value";
        }
        
        private void FovChange_Click(object sender, EventArgs e)
        {
            float fovval = (float)FovInput.Value;
            setFoV(fovval);
        }

        private void setFoV(float val) {
            Int32 addr = 0x5934A90;
            byte[] fov = BitConverter.GetBytes(val);
            MemoryManager.WriteToAddress(addr, fov);
        }


        private void ResChange_Click(object sender, EventArgs e)
        {
            Change_Res();
            Change_Res_Height();
            Chang_Aspect();
        }

        private void Change_Res()
        {
            Int32 addr = 0x4E97F60;

            int test = (int)ResInput.Value;

            byte[] res = BitConverter.GetBytes(test);

            MemoryManager.WriteToAddress(addr, res);
        }

        private void Change_Res_Height()
        {
            Int32 addr = 0x4E97F64;

            int test = (int)ResHeightInput.Value;

            byte[] res = BitConverter.GetBytes(test);

            MemoryManager.WriteToAddress(addr, res);
        }

        private void Chang_Aspect()
        {
            Int32 addr = 0x332FC18;

            float test = (int)ResInput.Value / 1080;

            byte[] aspect = BitConverter.GetBytes(test);

            MemoryManager.WriteToAddress(addr, aspect);
        }

        private void TutorialMapChangerChange_Click(object sender, EventArgs e)
        {
            Int32 addr = 0x3A01840;

            string mapval = TutorialMapChangerMaps.SelectedValue.ToString();

            byte[] map = Encoding.ASCII.GetBytes(mapval);
            byte[] terminatedMap = new byte[map.Length + 1];

            map.CopyTo(terminatedMap, 0);
            terminatedMap[terminatedMap.Length - 1] = 0x00;

            MemoryManager.WriteToAddress(addr, terminatedMap);
        }

        private void FovTrackBarScroll(object sender, EventArgs e)
        {
            FovInput.Value = FovTrackBar.Value;
        }

        private void ResTrackBarScroll(object sender, EventArgs e)
        {
            ResInput.Value = ResTrackBar.Value;
        }


        private void ResHeightTrackBarScroll(object sender, EventArgs e)
        {
            ResHeightInput.Value = RESHeightTrackBar.Value;
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
            float fov = BitConverter.ToSingle(MemoryManager.ReadFromAddress(0x5934A90), 0);
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
            UWP.LaunchApp("Microsoft.Halo5Forge_1.114.4592.2_x64__8wekyb3d8bbwe");
        }

        private void FPSTrackBarScroll(object sender, EventArgs e)
        {
            FPSInput.Value = FPSTrackBar.Value;
            Change_Res();
            Chang_Aspect();
        }

        private void ResetFOV_Click(object sender, EventArgs e)
        {
            setFoV(defaultFoV);
            FovInput.Value = (int)defaultFoV;
            FovTrackBar.Value = (int)defaultFoV;
        }

        private void tmrGameCheck_Tick(object sender, EventArgs e)
        {
            if (isGameRunning())
            {
                H5Launcher.Visible = false;
            } else
            {
                H5Launcher.Visible = true;
            }
        }
        
        private bool isGameRunning()
        {
            Process[] pname = Process.GetProcessesByName("halo5forge");
            return (pname.Length != 0);
        }
    }
}
