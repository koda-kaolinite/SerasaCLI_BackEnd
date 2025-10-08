namespace Tse_Forms.control.window
{
    partial class WindowBarForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            WindowBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            EnterpriseNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            closeWindowButton = new CloseWindowButton();
            maximizeMinimizeWindowButton = new MaximizeMinimizeWindowButton();
            minimizeWindow = new MinimizeWindow();
            GunaTooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            WindowBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // WindowBarPanel
            // 
            WindowBarPanel.BackColor = Color.Transparent;
            WindowBarPanel.Controls.Add(EnterpriseNameLabel);
            WindowBarPanel.Controls.Add(closeWindowButton);
            WindowBarPanel.Controls.Add(maximizeMinimizeWindowButton);
            WindowBarPanel.Controls.Add(minimizeWindow);
            WindowBarPanel.CustomizableEdges = customizableEdges3;
            WindowBarPanel.Dock = DockStyle.Fill;
            WindowBarPanel.Location = new Point(0, 0);
            WindowBarPanel.Margin = new Padding(0);
            WindowBarPanel.Name = "WindowBarPanel";
            WindowBarPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            WindowBarPanel.Size = new Size(1366, 40);
            WindowBarPanel.TabIndex = 2;
            // 
            // EnterpriseNameLabel
            // 
            EnterpriseNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterpriseNameLabel.BackColor = Color.Transparent;
            EnterpriseNameLabel.Font = new Font("Poppins ExtraBold", 24F, FontStyle.Bold);
            EnterpriseNameLabel.IsSelectionEnabled = false;
            EnterpriseNameLabel.Location = new Point(0, -5);
            EnterpriseNameLabel.Margin = new Padding(0);
            EnterpriseNameLabel.Name = "EnterpriseNameLabel";
            EnterpriseNameLabel.Size = new Size(163, 58);
            EnterpriseNameLabel.TabIndex = 6;
            EnterpriseNameLabel.Text = "DOMGEST";
            EnterpriseNameLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // closeWindowButton
            // 
            closeWindowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeWindowButton.BackColor = Color.Transparent;
            closeWindowButton.Location = new Point(1326, 0);
            closeWindowButton.Margin = new Padding(0);
            closeWindowButton.Name = "closeWindowButton";
            closeWindowButton.Size = new Size(40, 40);
            closeWindowButton.TabIndex = 2;
            // 
            // maximizeMinimizeWindowButton
            // 
            maximizeMinimizeWindowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeMinimizeWindowButton.BackColor = Color.Transparent;
            maximizeMinimizeWindowButton.Location = new Point(1286, 0);
            maximizeMinimizeWindowButton.Margin = new Padding(0);
            maximizeMinimizeWindowButton.Name = "maximizeMinimizeWindowButton";
            maximizeMinimizeWindowButton.Size = new Size(40, 40);
            maximizeMinimizeWindowButton.TabIndex = 1;
            // 
            // minimizeWindow
            // 
            minimizeWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeWindow.BackColor = Color.Transparent;
            minimizeWindow.Location = new Point(1246, 0);
            minimizeWindow.Margin = new Padding(0);
            minimizeWindow.Name = "minimizeWindow";
            minimizeWindow.Size = new Size(40, 40);
            minimizeWindow.TabIndex = 0;
            // 
            // GunaTooltip
            // 
            GunaTooltip.AllowLinksHandling = true;
            GunaTooltip.MaximumSize = new Size(0, 0);
            GunaTooltip.ToolTipTitle = "Titulo";
            // 
            // WindowBarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(WindowBarPanel);
            Margin = new Padding(0);
            Name = "WindowBarForm";
            Size = new Size(1366, 40);
            WindowBarPanel.ResumeLayout(false);
            WindowBarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel WindowBarPanel;
        private CloseWindowButton closeWindowButton;
        private MaximizeMinimizeWindowButton maximizeMinimizeWindowButton;
        private MinimizeWindow minimizeWindow;
        private Guna.UI2.WinForms.Guna2HtmlLabel EnterpriseNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlToolTip GunaTooltip;
    }
}
