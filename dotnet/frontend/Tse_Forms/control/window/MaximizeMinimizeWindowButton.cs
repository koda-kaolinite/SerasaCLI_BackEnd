using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tse_Forms.control
{
    public partial class MaximizeMinimizeWindowButton : UserControl
    {
        public MaximizeMinimizeWindowButton()
        {
            InitializeComponent();

            // Style updates from TODO
            this.Cursor = Cursors.Default;
            guna2ImageButton1.PressedState.ImageSize = guna2ImageButton1.ImageSize;
        }

        private void guna2ImageButton1_Click(object? sender, EventArgs e)
        {
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.WindowState = parentForm.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            }
        }
    }
}
