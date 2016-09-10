using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

            uint addr = 0x009FCE85;
            
            byte[] fov = BitConverter.GetBytes( 50.0 );

            MemoryManager.WriteToAddress(addr, fov);
        }
    }
}
