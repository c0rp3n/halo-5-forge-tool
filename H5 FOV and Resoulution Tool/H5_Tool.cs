using System;
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
        }

        private void FovChange_Click(object sender, EventArgs e)
        {
            Int32 addr = 0x58ECF90;

            float test = (float)FovInput.Value;

            byte[] fov = BitConverter.GetBytes(test);

            MemoryManager.WriteToAddress(addr, fov);
        }
    }
}
