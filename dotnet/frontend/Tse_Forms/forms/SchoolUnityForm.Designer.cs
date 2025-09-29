namespace Tse_Forms.forms
{
    partial class SchoolUnityForm
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolUnityForm));
            DeleteSchoolUnityButton = new System.Windows.Forms.Button();
            transformese = new System.Windows.Forms.PictureBox();
            searchSchoolUnityByNameLabel = new System.Windows.Forms.Label();
            searchSchoolUnityByNameInput = new System.Windows.Forms.TextBox();
            schoolUnitiesDataGridView = new System.Windows.Forms.DataGridView();
            schoolUnityNameLabel = new System.Windows.Forms.Label();
            CreateSchoolUnityButton = new System.Windows.Forms.Button();
            schoolUnityNameTextBox = new System.Windows.Forms.TextBox();
            UpdateSchoolUnity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)transformese).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schoolUnitiesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DeleteSchoolUnityButton
            // 
            DeleteSchoolUnityButton.Location = new System.Drawing.Point(367, 664);
            DeleteSchoolUnityButton.Name = "DeleteSchoolUnityButton";
            DeleteSchoolUnityButton.Size = new System.Drawing.Size(144, 42);
            DeleteSchoolUnityButton.TabIndex = 34;
            DeleteSchoolUnityButton.Text = "Deletar Unidade de Ensino";
            DeleteSchoolUnityButton.UseVisualStyleBackColor = true;
            DeleteSchoolUnityButton.Click += deleteSchoolUnityButton_Click;
            // 
            // transformese
            // 
            transformese.Image = ((System.Drawing.Image)resources.GetObject("transformese.Image"));
            transformese.Location = new System.Drawing.Point(12, 12);
            transformese.Name = "transformese";
            transformese.Size = new System.Drawing.Size(499, 226);
            transformese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            transformese.TabIndex = 33;
            transformese.TabStop = false;
            // 
            // searchSchoolUnityByNameLabel
            // 
            searchSchoolUnityByNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            searchSchoolUnityByNameLabel.Location = new System.Drawing.Point(12, 248);
            searchSchoolUnityByNameLabel.Name = "searchSchoolUnityByNameLabel";
            searchSchoolUnityByNameLabel.Size = new System.Drawing.Size(250, 23);
            searchSchoolUnityByNameLabel.TabIndex = 31;
            searchSchoolUnityByNameLabel.Text = "Procurar pelo nome da Unidade de Ensino";
            // 
            // searchSchoolUnityByNameInput
            // 
            searchSchoolUnityByNameInput.Location = new System.Drawing.Point(12, 274);
            searchSchoolUnityByNameInput.Name = "searchSchoolUnityByNameInput";
            searchSchoolUnityByNameInput.Size = new System.Drawing.Size(499, 23);
            searchSchoolUnityByNameInput.TabIndex = 30;
            searchSchoolUnityByNameInput.TextChanged += searchSchoolUnityByNameInput_TextChanged;
            // 
            // schoolUnitiesDataGridView
            // 
            schoolUnitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schoolUnitiesDataGridView.Location = new System.Drawing.Point(12, 303);
            schoolUnitiesDataGridView.Name = "schoolUnitiesDataGridView";
            schoolUnitiesDataGridView.Size = new System.Drawing.Size(499, 262);
            schoolUnitiesDataGridView.TabIndex = 29;
            schoolUnitiesDataGridView.Text = "dataGridView1";
            // 
            // schoolUnityNameLabel
            // 
            schoolUnityNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            schoolUnityNameLabel.Location = new System.Drawing.Point(12, 591);
            schoolUnityNameLabel.Name = "schoolUnityNameLabel";
            schoolUnityNameLabel.Size = new System.Drawing.Size(250, 23);
            schoolUnityNameLabel.TabIndex = 28;
            schoolUnityNameLabel.Text = "Nome da Unidade de Ensino";
            // 
            // CreateSchoolUnityButton
            // 
            CreateSchoolUnityButton.Location = new System.Drawing.Point(12, 664);
            CreateSchoolUnityButton.Name = "CreateSchoolUnityButton";
            CreateSchoolUnityButton.Size = new System.Drawing.Size(144, 42);
            CreateSchoolUnityButton.TabIndex = 27;
            CreateSchoolUnityButton.Text = "Cadastrar Unidade de Ensino";
            CreateSchoolUnityButton.UseVisualStyleBackColor = true;
            CreateSchoolUnityButton.Click += cadastrar_Click;
            // 
            // schoolUnityNameTextBox
            // 
            schoolUnityNameTextBox.Location = new System.Drawing.Point(12, 617);
            schoolUnityNameTextBox.Name = "schoolUnityNameTextBox";
            schoolUnityNameTextBox.Size = new System.Drawing.Size(499, 23);
            schoolUnityNameTextBox.TabIndex = 26;
            // 
            // UpdateSchoolUnity
            // 
            UpdateSchoolUnity.Location = new System.Drawing.Point(194, 664);
            UpdateSchoolUnity.Name = "UpdateSchoolUnity";
            UpdateSchoolUnity.Size = new System.Drawing.Size(144, 42);
            UpdateSchoolUnity.TabIndex = 35;
            UpdateSchoolUnity.Text = "Atualizar Unidade de Ensino";
            UpdateSchoolUnity.UseVisualStyleBackColor = true;
            UpdateSchoolUnity.Click += UpdateSchoolUnity_Click;
            // 
            // SchoolUnity
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(528, 719);
            Controls.Add(UpdateSchoolUnity);
            Controls.Add(DeleteSchoolUnityButton);
            Controls.Add(transformese);
            Controls.Add(searchSchoolUnityByNameLabel);
            Controls.Add(searchSchoolUnityByNameInput);
            Controls.Add(schoolUnitiesDataGridView);
            Controls.Add(schoolUnityNameLabel);
            Controls.Add(CreateSchoolUnityButton);
            Controls.Add(schoolUnityNameTextBox);
            Text = "SchoolUnity";
            ((System.ComponentModel.ISupportInitialize)transformese).EndInit();
            ((System.ComponentModel.ISupportInitialize)schoolUnitiesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button UpdateSchoolUnity;

        #endregion

        private Button DeleteSchoolUnityButton;
        private PictureBox transformese;
        private Label searchSchoolUnityByNameLabel;
        private System.Windows.Forms.TextBox searchSchoolUnityByNameInput;
        private DataGridView schoolUnitiesDataGridView;
        private Label schoolUnityNameLabel;
        private Button CreateSchoolUnityButton;
        private System.Windows.Forms.TextBox schoolUnityNameTextBox;
    }
}