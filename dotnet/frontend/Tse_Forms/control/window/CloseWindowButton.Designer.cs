namespace Tse_Forms.control
{
    partial class CloseWindowButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseWindowButton));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CloseImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            SuspendLayout();
            // 
            // CloseImageButton
            // 
            CloseImageButton.BackColor = Color.Transparent;
            CloseImageButton.CheckedState.ImageSize = new Size(20, 20);
            CloseImageButton.HoverState.ImageSize = new Size(20, 20);
            CloseImageButton.Image = (Image)resources.GetObject("CloseImageButton.Image");
            CloseImageButton.ImageOffset = new Point(0, 0);
            CloseImageButton.ImageRotate = 0F;
            CloseImageButton.ImageSize = new Size(20, 20);
            CloseImageButton.Location = new Point(0, 0);
            CloseImageButton.Margin = new Padding(0);
            CloseImageButton.Name = "CloseImageButton";
            CloseImageButton.PressedState.ImageSize = new Size(20, 20);
            CloseImageButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            CloseImageButton.Size = new Size(40, 40);
            CloseImageButton.TabIndex = 0;
            CloseImageButton.Click += CloseImageButton_Click;
            // 
            // CloseWindowButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(CloseImageButton);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "CloseWindowButton";
            Size = new Size(40, 40);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton CloseImageButton;
    }
}
