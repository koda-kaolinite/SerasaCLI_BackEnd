using System.ComponentModel;

namespace Tse_Forms.forms;

partial class StudentForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
        StudentNameInput = new System.Windows.Forms.TextBox();
        CourseInput = new System.Windows.Forms.ComboBox();
        SchoolUnityInput = new System.Windows.Forms.ComboBox();
        RegisterStudentButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        StudentDataView = new System.Windows.Forms.DataGridView();
        SearchStudentByNameInput = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        transformese = new System.Windows.Forms.PictureBox();
        DeleteStudentButton = new System.Windows.Forms.Button();
        UpdateStudentButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)StudentDataView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)transformese).BeginInit();
        SuspendLayout();
        // 
        // StudentNameInput
        // 
        StudentNameInput.Location = new System.Drawing.Point(12, 601);
        StudentNameInput.Name = "StudentNameInput";
        StudentNameInput.Size = new System.Drawing.Size(499, 23);
        StudentNameInput.TabIndex = 0;
        // 
        // CourseInput
        // 
        CourseInput.FormattingEnabled = true;
        CourseInput.Location = new System.Drawing.Point(12, 671);
        CourseInput.Name = "CourseInput";
        CourseInput.Size = new System.Drawing.Size(499, 23);
        CourseInput.TabIndex = 1;
        // 
        // SchoolUnityInput
        // 
        SchoolUnityInput.FormattingEnabled = true;
        SchoolUnityInput.Location = new System.Drawing.Point(14, 739);
        SchoolUnityInput.Name = "SchoolUnityInput";
        SchoolUnityInput.Size = new System.Drawing.Size(497, 23);
        SchoolUnityInput.TabIndex = 2;
        // 
        // RegisterStudentButton
        // 
        RegisterStudentButton.Location = new System.Drawing.Point(14, 782);
        RegisterStudentButton.Name = "RegisterStudentButton";
        RegisterStudentButton.Size = new System.Drawing.Size(105, 42);
        RegisterStudentButton.TabIndex = 3;
        RegisterStudentButton.Text = "Cadastrar Aluno";
        RegisterStudentButton.UseVisualStyleBackColor = true;
        RegisterStudentButton.Click += cadastrar_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
        label1.Location = new System.Drawing.Point(14, 575);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(54, 23);
        label1.TabIndex = 4;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
        label2.Location = new System.Drawing.Point(14, 645);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(67, 23);
        label2.TabIndex = 5;
        label2.Text = "Course";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
        label3.Location = new System.Drawing.Point(16, 713);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(153, 23);
        label3.TabIndex = 6;
        label3.Text = "School Unity";
        // 
        // StudentDataView
        // 
        StudentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        StudentDataView.Location = new System.Drawing.Point(14, 298);
        StudentDataView.Name = "StudentDataView";
        StudentDataView.Size = new System.Drawing.Size(497, 262);
        StudentDataView.TabIndex = 7;
        StudentDataView.Text = "dataGridView1";
        // 
        // SearchStudentByNameInput
        // 
        SearchStudentByNameInput.Location = new System.Drawing.Point(14, 269);
        SearchStudentByNameInput.Name = "SearchStudentByNameInput";
        SearchStudentByNameInput.Size = new System.Drawing.Size(497, 23);
        SearchStudentByNameInput.TabIndex = 8;
        SearchStudentByNameInput.TextChanged += SearchStudentByNameInput_TextChanged;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
        label4.Location = new System.Drawing.Point(14, 243);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(248, 23);
        label4.TabIndex = 9;
        label4.Text = "Search by Student Name";
        // 
        // transformese
        // 
        transformese.Image = ((System.Drawing.Image)resources.GetObject("transformese.Image"));
        transformese.Location = new System.Drawing.Point(12, 12);
        transformese.Name = "transformese";
        transformese.Size = new System.Drawing.Size(499, 226);
        transformese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        transformese.TabIndex = 11;
        transformese.TabStop = false;
        // 
        // DeleteStudentButton
        // 
        DeleteStudentButton.Location = new System.Drawing.Point(406, 782);
        DeleteStudentButton.Name = "DeleteStudentButton";
        DeleteStudentButton.Size = new System.Drawing.Size(105, 42);
        DeleteStudentButton.TabIndex = 12;
        DeleteStudentButton.Text = "Apagar Aluno";
        DeleteStudentButton.UseVisualStyleBackColor = true;
        DeleteStudentButton.Click += deleteStudentButton_Click;
        // 
        // UpdateStudentButton
        // 
        UpdateStudentButton.Location = new System.Drawing.Point(210, 782);
        UpdateStudentButton.Name = "UpdateStudentButton";
        UpdateStudentButton.Size = new System.Drawing.Size(105, 42);
        UpdateStudentButton.TabIndex = 13;
        UpdateStudentButton.Text = "Atualizar Aluno";
        UpdateStudentButton.UseVisualStyleBackColor = true;
        UpdateStudentButton.Click += UpdateStudentButton_Click;
        // 
        // StudentForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(528, 836);
        Controls.Add(UpdateStudentButton);
        Controls.Add(DeleteStudentButton);
        Controls.Add(transformese);
        Controls.Add(label4);
        Controls.Add(SearchStudentByNameInput);
        Controls.Add(StudentDataView);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(RegisterStudentButton);
        Controls.Add(SchoolUnityInput);
        Controls.Add(CourseInput);
        Controls.Add(StudentNameInput);
        Text = "StudentForm";
        Load += StudentForm_Load;
        ((System.ComponentModel.ISupportInitialize)StudentDataView).EndInit();
        ((System.ComponentModel.ISupportInitialize)transformese).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button UpdateStudentButton;

    private System.Windows.Forms.Button DeleteStudentButton;

    private System.Windows.Forms.PictureBox transformese;

    private System.Windows.Forms.TextBox SearchStudentByNameInput;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.DataGridView StudentDataView;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button RegisterStudentButton;

    private System.Windows.Forms.ComboBox SchoolUnityInput;

    private System.Windows.Forms.ComboBox CourseInput;

    private System.Windows.Forms.TextBox StudentNameInput;

    #endregion
}