using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Tse_Forms.control.ActionsMenu
{
    public partial class Dashboard : Form
    {
        private const int SideBarClosed = 80;
        private System.Windows.Forms.Timer _menuTimer = null!;
        private bool _menuCollapsed; // Starts expanded as in the designer
        private readonly Dictionary<Control, string> _originalButtonTexts = new Dictionary<Control, string>();

        public Dashboard()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            _menuTimer = new System.Windows.Forms.Timer();
            _menuTimer.Interval = 10;
            _menuTimer.Tick += menuTimer_Tick;

            MenuButton.Click += guna2Button1_Click;

            var buttonsToManage = MenuOptionsPanel.Controls.OfType<Guna.UI2.WinForms.Guna2Button>()
                .Concat([MenuButton, ExitButton]);

            foreach (var button in buttonsToManage)
            {
                _originalButtonTexts[button] = button.Text;
            }

            //Hide Submenu panels on object construction.
            ManagementSuboptionsPanel.Visible = false;
            StatisticsSuboptionsPanel.Visible = false;
        }

        private void HideSubMenu()
        {
            ManagementSuboptionsPanel.Visible = false;
            StatisticsSuboptionsPanel.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void guna2Button1_Click(object? sender, EventArgs e)
        {
            _menuTimer.Start();
        }

        private void UpdateButtonAppearances(bool collapsed)
        {
            IEnumerable<Guna2Button> buttonsToUpdate = MenuOptionsPanel.Controls.OfType<Guna2Button>()
                .Concat([MenuButton, ExitButton]);

            foreach (Guna2Button button in buttonsToUpdate)
            {
                // Todo: Resolver mini bug que o botão de exit move o icone por tipo 2 pixeis para a esquerda quando minimiza.
                if (collapsed)
                {
                    button.Size = new Size(SideBarClosed, button.Height);
                    button.Text = "";
                    button.ImageAlign = HorizontalAlignment.Center;
                    button.TextOffset = new Point(0, 0);
                    button.ImageOffset = new Point(-5, 0);
                }
                else
                {
                    int width = 270;
                    button.Size = new Size(width, button.Height);
                    button.Text = _originalButtonTexts[button];
                    button.ImageAlign = HorizontalAlignment.Left;
                    button.TextOffset = new Point(5, 3);
                    button.ImageOffset = new Point(5, 0);
                }
            }
        }

        private void menuTimer_Tick(object? sender, EventArgs e)
        {
            if (_menuCollapsed)
            {
                // EXPAND
                MenuButtonsPanel.Width += 25;
                if (MenuButtonsPanel.Width >= 273)
                {
                    MenuButtonsPanel.Width = 273;
                    _menuTimer.Stop();
                    _menuCollapsed = false;

                    MenuOptionsPanel.Width = 273;
                    MenuDivBar.Text = "__________________________________________";
                    UpdateButtonAppearances(false);
                }
            }
            else
            {
                // COLLAPSE
                MenuButtonsPanel.Width -= 25;
                if (MenuButtonsPanel.Width <= SideBarClosed)
                {
                    MenuButtonsPanel.Width = SideBarClosed;
                    _menuTimer.Stop();
                    _menuCollapsed = true;

                    MenuOptionsPanel.Width = SideBarClosed;
                    MenuDivBar.Text = "__________";
                    UpdateButtonAppearances(true);
                }
            }
            windowBarForm1.Left = MenuButtonsPanel.Width;
            windowBarForm1.Width = this.ClientSize.Width - MenuButtonsPanel.Width;
        }


        private void ManagementMenuButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ManagementSuboptionsPanel);
        }

        private void StatisticsMenuButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(StatisticsSuboptionsPanel);
        }

        private void OpenMenuForm(Form selectedForm)
        {
            IEnumerable<Form> activeForm = ContentPanel.Controls.OfType<Form>();
            foreach (Form form in activeForm)
            {
                form.Close();
            }
            // Todo: Continuar implementação de abrir o formulario selecionado no menu.
            //activeForm = selectedForm;
            selectedForm.Dock = DockStyle.Fill;
            selectedForm.Show();
        }
    }
}
