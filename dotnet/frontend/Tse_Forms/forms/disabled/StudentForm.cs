using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FSharp.Core;
using Tse_Backend.Application;
using Tse_Backend.Domain;

namespace Tse_Forms.forms;

[Localizable(false)]
public partial class StudentForm : Form
{
    private readonly CourseService _courseService;
    private readonly SchoolUnityService _schoolUnityService;
    private readonly StudentService _studentService;

    public StudentForm()
    {
        InitializeComponent();
        _studentService = DI.ServiceProvider.GetRequiredService<StudentService>();
        _courseService = DI.ServiceProvider.GetRequiredService<CourseService>();
        _schoolUnityService = DI.ServiceProvider.GetRequiredService<SchoolUnityService>();
        StudentDataView.SelectionChanged += StudentDataView_SelectionChanged;
    }

    private void StudentForm_Load(object sender, EventArgs e)
    {
        // Load Courses ComboBox
        var coursesResult = _courseService.GetAll();
        if (coursesResult.IsOk)
        {
            var courseData = coursesResult.Item.Select(c => new { c.Name, Value = c }).ToList();
            CourseInput.DataSource = courseData;
            CourseInput.DropDownStyle = ComboBoxStyle.DropDownList;
            CourseInput.DisplayMember = "Name";
            CourseInput.ValueMember = "Value";
        }
        else
        {
            MessageBox.Show($"Failed to load courses: {coursesResult.ErrorItem}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        // Load School Unities ComboBox
        var schoolUnitiesResult = _schoolUnityService.GetAll();
        if (schoolUnitiesResult.IsOk)
        {
            var schoolUnityData = schoolUnitiesResult.Item.Select(su => new { su.Name, Value = su }).ToList();
            SchoolUnityInput.DataSource = schoolUnityData;
            SchoolUnityInput.DropDownStyle = ComboBoxStyle.DropDownList;
            SchoolUnityInput.DisplayMember = "Name";
            SchoolUnityInput.ValueMember = "Value";
        }
        else
        {
            MessageBox.Show($"Failed to load school unities: {schoolUnitiesResult.ErrorItem}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        LoadStudents();
    }

    private void cadastrar_Click(object sender, EventArgs e)
    {
        if (CourseInput.SelectedValue is Course selectedCourse &&
            SchoolUnityInput.SelectedValue is SchoolUnity selectedSchoolUnity)
        {
            var studentName = StudentNameInput.Text;
            var courseOption = FSharpOption<Course>.Some(selectedCourse);
            var schoolUnityOption = FSharpOption<SchoolUnity>.Some(selectedSchoolUnity);

            var result = _studentService.Create(studentName, courseOption, schoolUnityOption);

            if (result.IsOk)
            {
                MessageBox.Show("Student registered successfully!");
                LoadStudents();
            }
            else
            {
                MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select a course and a school unity.", "Invalid Input", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void LoadStudents(string? nameFilter = null)
    {
        var studentsResult = _studentService.GetAll();
        if (studentsResult.IsError)
        {
            MessageBox.Show($"Failed to load students: {studentsResult.ErrorItem}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var students = studentsResult.Item.ToList();

        if (!string.IsNullOrWhiteSpace(nameFilter))
            students = students.Where(s => s.Person.Name.ToLower().Contains(nameFilter.ToLower())).ToList();

        var studentDisplayData = students.Select(s => new
        {
            s.Id,
            s.Person.Name,
            Course = s.Course?.Name ?? "N/A",
            SchoolUnity = s.SchoolUnity?.Name ?? "N/A"
        }).ToList();

        StudentDataView.DataSource = studentDisplayData;

        if (StudentDataView.Columns["Id"] != null) StudentDataView.Columns["Id"]!.Visible = false;
    }

    private void deleteStudentButton_Click(object sender, EventArgs e)
    {
        if (StudentDataView.SelectedRows.Count > 0)
        {
            var selectedRow = StudentDataView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is Guid studentId)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this student?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = _studentService.Delete(studentId);
                    if (result.IsOk)
                    {
                        MessageBox.Show("Student deleted successfully!");
                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void UpdateStudentButton_Click(object sender, EventArgs e)
    {
        if (StudentDataView.SelectedRows.Count > 0)
        {
            var selectedRow = StudentDataView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is Guid studentId)
            {
                if (CourseInput.SelectedValue is Course selectedCourse &&
                    SchoolUnityInput.SelectedValue is SchoolUnity selectedSchoolUnity)
                {
                    var studentName = StudentNameInput.Text;
                    var courseOption = FSharpOption<Course>.Some(selectedCourse);
                    var schoolUnityOption = FSharpOption<SchoolUnity>.Some(selectedSchoolUnity);

                    var result = _studentService.Update(studentId, studentName, courseOption, schoolUnityOption);

                    if (result.IsOk)
                    {
                        MessageBox.Show("Student updated successfully!");
                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a course and a school unity.", "Invalid Input", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a student to update.", "No Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void StudentDataView_SelectionChanged(object? sender, EventArgs e)
    {
        if (StudentDataView.SelectedRows.Count > 0)
        {
            var selectedRow = StudentDataView.SelectedRows[0];

            if (selectedRow.Cells["Name"].Value != null)
                StudentNameInput.Text = selectedRow.Cells["Name"].Value?.ToString();

            if (selectedRow.Cells["Course"].Value != null)
                CourseInput.Text = selectedRow.Cells["Course"].Value?.ToString();

            if (selectedRow.Cells["SchoolUnity"].Value != null)
                SchoolUnityInput.Text = selectedRow.Cells["SchoolUnity"].Value?.ToString();
        }
    }

    private void SearchStudentByNameInput_TextChanged(object sender, EventArgs e)
    {
        LoadStudents(SearchStudentByNameInput.Text);
    }
}