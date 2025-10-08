using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tse_Forms.control.window
{
    public partial class WindowBarForm : UserControl
    {
        public WindowBarForm()
        {
            InitializeComponent();
            InitializeToolTips();
        }

        private void InitializeToolTips()
        {
            // nao esta funcionando quando coloco o mouse em cima no forms dashboard.
            ToolTip toolTip = GunaTooltip;
            toolTip.SetToolTip(closeWindowButton, "Close");
            toolTip.SetToolTip(minimizeWindow, "Minimize");
            toolTip.SetToolTip(maximizeMinimizeWindowButton, "FullScreen/Window");
        }

        // Todo: trocar a cor do background quando coloca o mouse em cima - PENDING
    }
}
