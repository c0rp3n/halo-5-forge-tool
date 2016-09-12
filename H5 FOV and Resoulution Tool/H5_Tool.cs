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

            FovInput.Value = 96;
            ResInput.Value = 1920;

            IDictionary maps = new Dictionary<string, string> {
                {"Alpine", "levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Breakout Arena", "09150000"},
                {"Coliseum", "0C150000"},
                {"Eden", "0e150000"},
                {"Empire", "FF140000"},
                {"Fathom", "FF140000"},
                {"Glacier", "FF140000"},
                {"Mercy", "FF140000"},
                {"Molten", "FF140000"},
                {"Overgrowth", "FF140000"},
                {"Plaza", "FF140000"},
                {"Regret", "FF140000"},
                {"Riptide", "FF140000"},
                {"Stasis", "FF140000"},
                {"The Rig", "FF140000"},
                {"Tidal", "FF140000"},
                {"Torque", "FF140000"},
                {"Truth", "FF140000"},
                {"Tyrant", "FF140000"}
            };

            TutorialMapChangerMaps.DataSource = new BindingSource(maps, null);
            TutorialMapChangerMaps.DisplayMember = "Map";
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
            //Int32 addr = 0x3A25DA0;

            //string mapval = (float)FovInput.Value;

            //byte[] map = BitConverter.GetBytes(mapval);

            //MemoryManager.WriteToAddress(addr, map);
        }

        private void FovTrackBarScroll(object sender, EventArgs e)
        {
            FovTrackBar.Minimum = 65;
            FovTrackBar.Maximum = 150;
            FovInput.Value = FovTrackBar.Value;
        }

        private void ResTrackBarScroll(object sender, EventArgs e)
        {
            ResTrackBar.Minimum = 840;
            ResTrackBar.Maximum = 7680;
            ResInput.Value = ResTrackBar.Value;
        }
    }
}
