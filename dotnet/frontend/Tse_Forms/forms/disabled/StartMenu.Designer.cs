namespace Tse_Forms.forms;

partial class StartMenu {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
        pictureBox1 = new PictureBox();
        AlunosImagem = new PictureBox();
        CursosImagem = new PictureBox();
        UnidadesEnsinoImagem = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)AlunosImagem).BeginInit();
        ((System.ComponentModel.ISupportInitialize)CursosImagem).BeginInit();
        ((System.ComponentModel.ISupportInitialize)UnidadesEnsinoImagem).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(19, 17);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(590, 164);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // AlunosImagem
        // 
        AlunosImagem.BorderStyle = BorderStyle.Fixed3D;
        AlunosImagem.Image = (Image)resources.GetObject("AlunosImagem.Image");
        AlunosImagem.Location = new Point(19, 305);
        AlunosImagem.Name = "AlunosImagem";
        AlunosImagem.Size = new Size(125, 125);
        AlunosImagem.SizeMode = PictureBoxSizeMode.Zoom;
        AlunosImagem.TabIndex = 1;
        AlunosImagem.TabStop = false;
        AlunosImagem.Click += AlunosImagem_Click;
        // 
        // CursosImagem
        // 
        CursosImagem.BorderStyle = BorderStyle.Fixed3D;
        CursosImagem.Image = (Image)resources.GetObject("CursosImagem.Image");
        CursosImagem.Location = new Point(251, 305);
        CursosImagem.Name = "CursosImagem";
        CursosImagem.Size = new Size(125, 125);
        CursosImagem.SizeMode = PictureBoxSizeMode.Zoom;
        CursosImagem.TabIndex = 2;
        CursosImagem.TabStop = false;
        CursosImagem.Click += CursosImagem_Click;
        // 
        // UnidadesEnsinoImagem
        // 
        UnidadesEnsinoImagem.BorderStyle = BorderStyle.Fixed3D;
        UnidadesEnsinoImagem.Image = (Image)resources.GetObject("UnidadesEnsinoImagem.Image");
        UnidadesEnsinoImagem.Location = new Point(484, 305);
        UnidadesEnsinoImagem.Name = "UnidadesEnsinoImagem";
        UnidadesEnsinoImagem.Size = new Size(125, 125);
        UnidadesEnsinoImagem.SizeMode = PictureBoxSizeMode.Zoom;
        UnidadesEnsinoImagem.TabIndex = 3;
        UnidadesEnsinoImagem.TabStop = false;
        UnidadesEnsinoImagem.Click += UnidadesEnsinoImagem_Click;
        // 
        // StartMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(627, 450);
        Controls.Add(UnidadesEnsinoImagem);
        Controls.Add(CursosImagem);
        Controls.Add(AlunosImagem);
        Controls.Add(pictureBox1);
        Name = "StartMenu";
        Text = "StartMenu";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)AlunosImagem).EndInit();
        ((System.ComponentModel.ISupportInitialize)CursosImagem).EndInit();
        ((System.ComponentModel.ISupportInitialize)UnidadesEnsinoImagem).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox AlunosImagem;
    private System.Windows.Forms.PictureBox CursosImagem;
    private System.Windows.Forms.PictureBox UnidadesEnsinoImagem;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}