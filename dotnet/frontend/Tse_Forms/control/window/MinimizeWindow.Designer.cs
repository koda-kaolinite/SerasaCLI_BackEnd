namespace Tse_Forms.control
{
    partial class MinimizeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinimizeWindow));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackColor = Color.Transparent;
            guna2ImageButton1.CheckedState.ImageSize = new Size(20, 20);
            guna2ImageButton1.Cursor = Cursors.Default;
            guna2ImageButton1.HoverState.ImageSize = new Size(20, 20);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(20, 20);
            guna2ImageButton1.Location = new Point(0, 0);
            guna2ImageButton1.Margin = new Padding(0);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(20, 20);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(40, 40);
            guna2ImageButton1.TabIndex = 0;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // MinimizeWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ImageButton1);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "MinimizeWindow";
            Size = new Size(40, 40);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
