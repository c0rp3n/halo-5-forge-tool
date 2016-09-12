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

namespace H5_FOV_and_Resoulution_Tool
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
            FovInput.Value = 78;
            FovTrackBar.Value = 78;
            ResInput.Value = 1920;
            ResTrackBar.Value = 1920;

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

            //byte[] fov = BitConverter.GetBytes(test);

            //MemoryManager.WriteToAddress(addr, fov);
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
    }
}
