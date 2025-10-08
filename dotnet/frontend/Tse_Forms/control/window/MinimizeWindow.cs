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
    public partial class MinimizeWindow : UserControl
    {
        public MinimizeWindow()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object? sender, EventArgs e)
        {
            var parentForm = FindForm();
            if (parentForm != null)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
