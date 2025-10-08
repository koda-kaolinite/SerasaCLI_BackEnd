using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace Tse_Forms.forms
{
	partial class LoginControlForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControlForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2DragControl1 = new Guna2DragControl(components);
            LoginPanel = new Guna2Panel();
            LoginButton = new Guna2Button();
            UsernameInput = new Guna2TextBox();
            EnterpriseTitleSubtitleField = new Guna2HtmlLabel();
            UsernameLabel = new Guna2HtmlLabel();
            SignInLabel = new Guna2HtmlLabel();
            EnterpriseNameLabel = new Guna2HtmlLabel();
            PasswordInput = new Guna2TextBox();
            PasswordLabel = new Guna2HtmlLabel();
            guna2DragControl2 = new Guna2DragControl(components);
            GunaBorderlessWindowForm = new Guna2PictureBox();
            LoginView = new Guna2BorderlessForm(components);
            LoginLayoutPanel = new TableLayoutPanel();
            ProjectInfoPanel = new Guna2Panel();
            DiscordIconButton = new Guna2ImageButton();
            GithubIconButton = new Guna2ImageButton();
            WhatsappIconButton = new Guna2ImageButton();
            XIconButton = new Guna2ImageButton();
            ProjectInfoField = new Guna2HtmlLabel();
            ImageLoginLayout = new TableLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GunaBorderlessWindowForm).BeginInit();
            LoginLayoutPanel.SuspendLayout();
            ProjectInfoPanel.SuspendLayout();
            ImageLoginLayout.SuspendLayout();
            SuspendLayout();
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = LoginPanel;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(UsernameInput);
            LoginPanel.Controls.Add(EnterpriseTitleSubtitleField);
            LoginPanel.Controls.Add(UsernameLabel);
            LoginPanel.Controls.Add(SignInLabel);
            LoginPanel.Controls.Add(EnterpriseNameLabel);
            LoginPanel.Controls.Add(PasswordInput);
            LoginPanel.Controls.Add(PasswordLabel);
            LoginPanel.CustomizableEdges = customizableEdges7;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Margin = new Padding(0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LoginPanel.Size = new Size(427, 612);
            LoginPanel.TabIndex = 10;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginButton.BorderRadius = 10;
            LoginButton.BorderThickness = 1;
            LoginButton.CustomizableEdges = customizableEdges1;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.FromArgb(250, 250, 250);
            LoginButton.Font = new Font("Segoe UI", 9F);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Image = (Image)resources.GetObject("LoginButton.Image");
            LoginButton.Location = new Point(172, 456);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoginButton.Size = new Size(60, 60);
            LoginButton.TabIndex = 8;
            // 
            // UsernameInput
            // 
            UsernameInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameInput.BackColor = Color.Transparent;
            UsernameInput.BorderColor = Color.FromArgb(250, 250, 250);
            UsernameInput.BorderRadius = 7;
            UsernameInput.Cursor = Cursors.Hand;
            UsernameInput.CustomizableEdges = customizableEdges3;
            UsernameInput.DefaultText = "";
            UsernameInput.DisabledState.BorderColor = Color.Transparent;
            UsernameInput.DisabledState.FillColor = Color.FromArgb(242, 242, 242);
            UsernameInput.DisabledState.ForeColor = Color.Transparent;
            UsernameInput.DisabledState.PlaceholderForeColor = Color.Transparent;
            UsernameInput.FillColor = Color.FromArgb(242, 242, 242);
            UsernameInput.FocusedState.BorderColor = Color.Black;
            UsernameInput.Font = new Font("Segoe UI", 9F);
            UsernameInput.ForeColor = Color.Black;
            UsernameInput.HoverState.BorderColor = Color.Transparent;
            UsernameInput.Location = new Point(55, 296);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.PlaceholderForeColor = Color.LightGray;
            UsernameInput.PlaceholderText = "";
            UsernameInput.SelectedText = "";
            UsernameInput.ShadowDecoration.CustomizableEdges = customizableEdges4;
            UsernameInput.Size = new Size(311, 36);
            UsernameInput.TabIndex = 1;
            // 
            // EnterpriseTitleSubtitleField
            // 
            EnterpriseTitleSubtitleField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterpriseTitleSubtitleField.AutoSize = false;
            EnterpriseTitleSubtitleField.BackColor = Color.Transparent;
            EnterpriseTitleSubtitleField.Font = new Font("Poppins Medium", 11F);
            EnterpriseTitleSubtitleField.Location = new Point(55, 134);
            EnterpriseTitleSubtitleField.Name = "EnterpriseTitleSubtitleField";
            EnterpriseTitleSubtitleField.Size = new Size(311, 76);
            EnterpriseTitleSubtitleField.TabIndex = 7;
            EnterpriseTitleSubtitleField.Text = "Efficiently and reliably manage your information systems while increasing productivity with automation.";
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            UsernameLabel.ForeColor = Color.Gray;
            UsernameLabel.Location = new Point(55, 276);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Padding = new Padding(5, 0, 0, 0);
            UsernameLabel.Size = new Size(84, 25);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username";
            // 
            // SignInLabel
            // 
            SignInLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignInLabel.BackColor = Color.Transparent;
            SignInLabel.Font = new Font("Poppins ExtraBold", 16F);
            SignInLabel.Location = new Point(55, 218);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(74, 39);
            SignInLabel.TabIndex = 6;
            SignInLabel.Text = "Sign In";
            // 
            // EnterpriseNameLabel
            // 
            EnterpriseNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterpriseNameLabel.BackColor = Color.Transparent;
            EnterpriseNameLabel.Font = new Font("Poppins ExtraBold", 24F, FontStyle.Bold);
            EnterpriseNameLabel.Location = new Point(55, 82);
            EnterpriseNameLabel.Name = "EnterpriseNameLabel";
            EnterpriseNameLabel.Size = new Size(163, 58);
            EnterpriseNameLabel.TabIndex = 5;
            EnterpriseNameLabel.Text = "DOMGEST";
            // 
            // PasswordInput
            // 
            PasswordInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordInput.BackColor = Color.FromArgb(250, 250, 250);
            PasswordInput.BorderColor = Color.FromArgb(250, 250, 250);
            PasswordInput.BorderRadius = 7;
            PasswordInput.Cursor = Cursors.Hand;
            PasswordInput.CustomizableEdges = customizableEdges5;
            PasswordInput.DefaultText = "";
            PasswordInput.DisabledState.BorderColor = Color.Transparent;
            PasswordInput.DisabledState.FillColor = Color.FromArgb(242, 242, 242);
            PasswordInput.DisabledState.ForeColor = Color.Transparent;
            PasswordInput.DisabledState.PlaceholderForeColor = Color.Transparent;
            PasswordInput.FillColor = Color.FromArgb(242, 242, 242);
            PasswordInput.FocusedState.BorderColor = Color.Black;
            PasswordInput.Font = new Font("Segoe UI", 9F);
            PasswordInput.ForeColor = Color.Black;
            PasswordInput.HoverState.BorderColor = Color.DimGray;
            PasswordInput.Location = new Point(55, 380);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.PlaceholderForeColor = Color.LightGray;
            PasswordInput.PlaceholderText = "";
            PasswordInput.SelectedText = "";
            PasswordInput.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PasswordInput.Size = new Size(311, 36);
            PasswordInput.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            PasswordLabel.ForeColor = Color.Gray;
            PasswordLabel.Location = new Point(55, 360);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Padding = new Padding(5, 0, 0, 0);
            PasswordLabel.Size = new Size(80, 25);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = GunaBorderlessWindowForm;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // GunaBorderlessWindowForm
            // 
            GunaBorderlessWindowForm.CustomizableEdges = customizableEdges9;
            GunaBorderlessWindowForm.Dock = DockStyle.Fill;
            GunaBorderlessWindowForm.Image = (Image)resources.GetObject("GunaBorderlessWindowForm.Image");
            GunaBorderlessWindowForm.ImageLocation = "F:\\TseApps\\dotnet\\frontend\\Tse_Forms\\assets\\Login\\irelia.png";
            GunaBorderlessWindowForm.ImageRotate = 0F;
            GunaBorderlessWindowForm.Location = new Point(427, 0);
            GunaBorderlessWindowForm.Margin = new Padding(0);
            GunaBorderlessWindowForm.Name = "GunaBorderlessWindowForm";
            GunaBorderlessWindowForm.ShadowDecoration.CustomizableEdges = customizableEdges10;
            GunaBorderlessWindowForm.Size = new Size(939, 720);
            GunaBorderlessWindowForm.SizeMode = PictureBoxSizeMode.StretchImage;
            GunaBorderlessWindowForm.TabIndex = 0;
            GunaBorderlessWindowForm.TabStop = false;
            // 
            // LoginView
            // 
            LoginView.ContainerControl = this;
            LoginView.DockIndicatorTransparencyValue = 0.6D;
            LoginView.TransparentWhileDrag = true;
            // 
            // LoginLayoutPanel
            // 
            LoginLayoutPanel.ColumnCount = 1;
            LoginLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            LoginLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LoginLayoutPanel.Controls.Add(ProjectInfoPanel, 0, 1);
            LoginLayoutPanel.Controls.Add(LoginPanel, 0, 0);
            LoginLayoutPanel.Location = new Point(0, 0);
            LoginLayoutPanel.Margin = new Padding(0);
            LoginLayoutPanel.Name = "LoginLayoutPanel";
            LoginLayoutPanel.RowCount = 2;
            LoginLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            LoginLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LoginLayoutPanel.Size = new Size(421, 720);
            LoginLayoutPanel.TabIndex = 9;
            // 
            // ProjectInfoPanel
            // 
            ProjectInfoPanel.Controls.Add(DiscordIconButton);
            ProjectInfoPanel.Controls.Add(GithubIconButton);
            ProjectInfoPanel.Controls.Add(WhatsappIconButton);
            ProjectInfoPanel.Controls.Add(XIconButton);
            ProjectInfoPanel.Controls.Add(ProjectInfoField);
            ProjectInfoPanel.CustomizableEdges = customizableEdges15;
            ProjectInfoPanel.Dock = DockStyle.Fill;
            ProjectInfoPanel.Location = new Point(0, 612);
            ProjectInfoPanel.Margin = new Padding(0);
            ProjectInfoPanel.Name = "ProjectInfoPanel";
            ProjectInfoPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            ProjectInfoPanel.Size = new Size(427, 108);
            ProjectInfoPanel.TabIndex = 10;
            // 
            // DiscordIconButton
            // 
            DiscordIconButton.CheckedState.ImageSize = new Size(64, 64);
            DiscordIconButton.Cursor = Cursors.Hand;
            DiscordIconButton.HoverState.ImageSize = new Size(64, 64);
            DiscordIconButton.Image = (Image)resources.GetObject("DiscordIconButton.Image");
            DiscordIconButton.ImageOffset = new Point(0, 0);
            DiscordIconButton.ImageRotate = 0F;
            DiscordIconButton.ImageSize = new Size(24, 24);
            DiscordIconButton.Location = new Point(121, 3);
            DiscordIconButton.Name = "DiscordIconButton";
            DiscordIconButton.PressedState.ImageSize = new Size(64, 64);
            DiscordIconButton.ShadowDecoration.CustomizableEdges = customizableEdges11;
            DiscordIconButton.Size = new Size(27, 28);
            DiscordIconButton.TabIndex = 14;
            // 
            // GithubIconButton
            // 
            GithubIconButton.CheckedState.ImageSize = new Size(64, 64);
            GithubIconButton.Cursor = Cursors.Hand;
            GithubIconButton.HoverState.ImageSize = new Size(64, 64);
            GithubIconButton.Image = (Image)resources.GetObject("GithubIconButton.Image");
            GithubIconButton.ImageOffset = new Point(0, 0);
            GithubIconButton.ImageRotate = 0F;
            GithubIconButton.ImageSize = new Size(24, 24);
            GithubIconButton.Location = new Point(88, 3);
            GithubIconButton.Name = "GithubIconButton";
            GithubIconButton.PressedState.ImageSize = new Size(64, 64);
            GithubIconButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            GithubIconButton.Size = new Size(27, 28);
            GithubIconButton.TabIndex = 13;
            // 
            // WhatsappIconButton
            // 
            WhatsappIconButton.CheckedState.ImageSize = new Size(64, 64);
            WhatsappIconButton.Cursor = Cursors.Hand;
            WhatsappIconButton.HoverState.ImageSize = new Size(64, 64);
            WhatsappIconButton.Image = (Image)resources.GetObject("WhatsappIconButton.Image");
            WhatsappIconButton.ImageOffset = new Point(0, 0);
            WhatsappIconButton.ImageRotate = 0F;
            WhatsappIconButton.ImageSize = new Size(24, 24);
            WhatsappIconButton.Location = new Point(55, 3);
            WhatsappIconButton.Name = "WhatsappIconButton";
            WhatsappIconButton.PressedState.ImageSize = new Size(64, 64);
            WhatsappIconButton.ShadowDecoration.CustomizableEdges = customizableEdges13;
            WhatsappIconButton.Size = new Size(27, 28);
            WhatsappIconButton.TabIndex = 12;
            // 
            // XIconButton
            // 
            XIconButton.CheckedState.ImageSize = new Size(64, 64);
            XIconButton.Cursor = Cursors.Hand;
            XIconButton.HoverState.ImageSize = new Size(64, 64);
            XIconButton.Image = (Image)resources.GetObject("XIconButton.Image");
            XIconButton.ImageOffset = new Point(0, 0);
            XIconButton.ImageRotate = 0F;
            XIconButton.ImageSize = new Size(24, 24);
            XIconButton.Location = new Point(22, 3);
            XIconButton.Name = "XIconButton";
            XIconButton.PressedState.ImageSize = new Size(64, 64);
            XIconButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            XIconButton.Size = new Size(27, 28);
            XIconButton.TabIndex = 11;
            // 
            // ProjectInfoField
            // 
            ProjectInfoField.AutoSize = false;
            ProjectInfoField.BackColor = Color.Transparent;
            ProjectInfoField.Font = new Font("Poppins Light", 8F);
            ProjectInfoField.Location = new Point(22, 34);
            ProjectInfoField.Name = "ProjectInfoField";
            ProjectInfoField.Size = new Size(399, 51);
            ProjectInfoField.TabIndex = 8;
            ProjectInfoField.Text = "DOMGEST is a non-commercial project developed for educational purposes to showcase Windows Forms development. This project is not affiliated with or endorsed by SENAC.";
            // 
            // ImageLoginLayout
            // 
            ImageLoginLayout.Anchor = AnchorStyles.None;
            ImageLoginLayout.ColumnCount = 2;
            ImageLoginLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ImageLoginLayout.ColumnStyles.Add(new ColumnStyle());
            ImageLoginLayout.Controls.Add(LoginLayoutPanel, 0, 0);
            ImageLoginLayout.Controls.Add(GunaBorderlessWindowForm, 1, 0);
            ImageLoginLayout.Location = new Point(0, 0);
            ImageLoginLayout.Margin = new Padding(0);
            ImageLoginLayout.Name = "ImageLoginLayout";
            ImageLoginLayout.RowCount = 1;
            ImageLoginLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ImageLoginLayout.Size = new Size(1366, 720);
            ImageLoginLayout.TabIndex = 10;
            // 
            // LoginControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1366, 720);
            Controls.Add(ImageLoginLayout);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1366, 720);
            Name = "LoginControlForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GunaBorderlessWindowForm).EndInit();
            LoginLayoutPanel.ResumeLayout(false);
            ProjectInfoPanel.ResumeLayout(false);
            ImageLoginLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm LoginView;
		private Guna.UI2.WinForms.Guna2TextBox UsernameInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel UsernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox PasswordInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel PasswordLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel EnterpriseNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel SignInLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel EnterpriseTitleSubtitleField;
        private TableLayoutPanel LoginLayoutPanel;
        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2Panel ProjectInfoPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProjectInfoField;
        private Guna.UI2.WinForms.Guna2ImageButton XIconButton;
        private Guna.UI2.WinForms.Guna2ImageButton DiscordIconButton;
        private Guna.UI2.WinForms.Guna2ImageButton GithubIconButton;
        private Guna.UI2.WinForms.Guna2ImageButton WhatsappIconButton;
        private TableLayoutPanel ImageLoginLayout;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2PictureBox GunaBorderlessWindowForm;

        //Manualmente Criado
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
