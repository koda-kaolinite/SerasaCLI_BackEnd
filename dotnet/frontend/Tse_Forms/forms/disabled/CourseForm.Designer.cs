namespace Tse_Forms.forms
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            DeleteCourseButton = new System.Windows.Forms.Button();
            transformese = new System.Windows.Forms.PictureBox();
            SearchCourseByNameLabel = new System.Windows.Forms.Label();
            searchStudentByNameInput = new System.Windows.Forms.TextBox();
            CourseDataView = new System.Windows.Forms.DataGridView();
            CourseNameInputLabel = new System.Windows.Forms.Label();
            CreateCourseButton = new System.Windows.Forms.Button();
            CourseName = new System.Windows.Forms.TextBox();
            WorkLoadInput = new System.Windows.Forms.TextBox();
            WorkLoadInputLabel = new System.Windows.Forms.Label();
            UpdateCourseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)transformese).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CourseDataView).BeginInit();
            SuspendLayout();
            // 
            // DeleteCourseButton
            // 
            DeleteCourseButton.Location = new System.Drawing.Point(413, 664);
            DeleteCourseButton.Name = "DeleteCourseButton";
            DeleteCourseButton.Size = new System.Drawing.Size(105, 42);
            DeleteCourseButton.TabIndex = 25;
            DeleteCourseButton.Text = "Deletar Curso";
            DeleteCourseButton.UseVisualStyleBackColor = true;
            DeleteCourseButton.Click += deleteCourseButton_Click;
            // 
            // transformese
            // 
            transformese.Image = ((System.Drawing.Image)resources.GetObject("transformese.Image"));
            transformese.Location = new System.Drawing.Point(19, 12);
            transformese.Name = "transformese";
            transformese.Size = new System.Drawing.Size(499, 226);
            transformese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            transformese.TabIndex = 24;
            transformese.TabStop = false;
            // 
            // SearchCourseByNameLabel
            // 
            SearchCourseByNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            SearchCourseByNameLabel.Location = new System.Drawing.Point(19, 248);
            SearchCourseByNameLabel.Name = "SearchCourseByNameLabel";
            SearchCourseByNameLabel.Size = new System.Drawing.Size(250, 23);
            SearchCourseByNameLabel.TabIndex = 22;
            SearchCourseByNameLabel.Text = "Procurar pelo nome do curso";
            // 
            // searchStudentByNameInput
            // 
            searchStudentByNameInput.Location = new System.Drawing.Point(19, 274);
            searchStudentByNameInput.Name = "searchStudentByNameInput";
            searchStudentByNameInput.Size = new System.Drawing.Size(499, 23);
            searchStudentByNameInput.TabIndex = 21;
            searchStudentByNameInput.TextChanged += searchStudentByNameInput_TextChanged;
            // 
            // CourseDataView
            // 
            CourseDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDataView.Location = new System.Drawing.Point(19, 303);
            CourseDataView.Name = "CourseDataView";
            CourseDataView.Size = new System.Drawing.Size(499, 262);
            CourseDataView.TabIndex = 20;
            CourseDataView.Text = "dataGridView1";
            // 
            // CourseNameInputLabel
            // 
            CourseNameInputLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            CourseNameInputLabel.Location = new System.Drawing.Point(19, 591);
            CourseNameInputLabel.Name = "CourseNameInputLabel";
            CourseNameInputLabel.Size = new System.Drawing.Size(231, 23);
            CourseNameInputLabel.TabIndex = 17;
            CourseNameInputLabel.Text = "Nome do Curso";
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Location = new System.Drawing.Point(19, 664);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new System.Drawing.Size(105, 42);
            CreateCourseButton.TabIndex = 16;
            CreateCourseButton.Text = "Cadastrar Curso";
            CreateCourseButton.UseVisualStyleBackColor = true;
            CreateCourseButton.Click += cadastrar_Click;
            // 
            // CourseName
            // 
            CourseName.Location = new System.Drawing.Point(19, 617);
            CourseName.Name = "CourseName";
            CourseName.Size = new System.Drawing.Size(231, 23);
            CourseName.TabIndex = 13;
            // 
            // WorkLoadInput
            // 
            WorkLoadInput.Location = new System.Drawing.Point(265, 617);
            WorkLoadInput.Name = "WorkLoadInput";
            WorkLoadInput.Size = new System.Drawing.Size(253, 23);
            WorkLoadInput.TabIndex = 26;
            // 
            // WorkLoadInputLabel
            // 
            WorkLoadInputLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            WorkLoadInputLabel.Location = new System.Drawing.Point(265, 591);
            WorkLoadInputLabel.Name = "WorkLoadInputLabel";
            WorkLoadInputLabel.Size = new System.Drawing.Size(231, 23);
            WorkLoadInputLabel.TabIndex = 27;
            WorkLoadInputLabel.Text = "Carga Horária";
            // 
            // UpdateCourseButton
            // 
            UpdateCourseButton.Location = new System.Drawing.Point(209, 664);
            UpdateCourseButton.Name = "UpdateCourseButton";
            UpdateCourseButton.Size = new System.Drawing.Size(105, 42);
            UpdateCourseButton.TabIndex = 28;
            UpdateCourseButton.Text = "Atualizar Curso";
            UpdateCourseButton.UseVisualStyleBackColor = true;
            UpdateCourseButton.Click += UpdateCourseButton_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(542, 726);
            Controls.Add(UpdateCourseButton);
            Controls.Add(WorkLoadInputLabel);
            Controls.Add(WorkLoadInput);
            Controls.Add(DeleteCourseButton);
            Controls.Add(transformese);
            Controls.Add(SearchCourseByNameLabel);
            Controls.Add(searchStudentByNameInput);
            Controls.Add(CourseDataView);
            Controls.Add(CourseNameInputLabel);
            Controls.Add(CreateCourseButton);
            Controls.Add(CourseName);
            Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)transformese).EndInit();
            ((System.ComponentModel.ISupportInitialize)CourseDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button UpdateCourseButton;

        private System.Windows.Forms.TextBox WorkLoadInput;
        private System.Windows.Forms.Label WorkLoadInputLabel;

        #endregion

        private System.Windows.Forms.Button DeleteCourseButton;
        private PictureBox transformese;
        private Label SearchCourseByNameLabel;
        private System.Windows.Forms.TextBox searchStudentByNameInput;
        private DataGridView CourseDataView;
        private System.Windows.Forms.Label CourseNameInputLabel;
        private Button CreateCourseButton;
        private System.Windows.Forms.TextBox CourseName;
    }
}