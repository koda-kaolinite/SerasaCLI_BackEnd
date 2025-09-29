using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Tse_Backend.Application;

namespace Tse_Forms.forms;

[Localizable(false)]
public partial class CourseForm : Form
{
    private readonly CourseService _courseService;

    public CourseForm()
    {
        InitializeComponent();
        // Resolve the service from the DI container
        _courseService = DI.ServiceProvider.GetRequiredService<CourseService>();
        LoadCourses();
        CourseDataView.SelectionChanged += CourseDataView_SelectionChanged;
    }

    private void cadastrar_Click(object sender, EventArgs e)
    {
        if (ushort.TryParse(WorkLoadInput.Text, out var workLoad))
        {
            var result = _courseService.Create(CourseName.Text, workLoad);

            if (result.IsOk)
            {
                MessageBox.Show("Course registered successfully!");
                LoadCourses();
            }
            else
            {
                MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please enter a valid workload.", "Invalid Input", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    private void LoadCourses(string? nameFilter = null)
    {
        var result = _courseService.GetAll();

        if (result.IsError)
        {
            MessageBox.Show($"Failed to load courses: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var courses = result.Item.ToList();

        if (!string.IsNullOrWhiteSpace(nameFilter))
            courses = courses.Where(c => c.Name.ToLower().Contains(nameFilter.ToLower())).ToList();

        var courseData = courses.Select(c => new
        {
            c.Id,
            c.Name,
            c.WorkLoad
        }).ToList();

        CourseDataView.DataSource = courseData;
        if (CourseDataView.Columns["Id"] != null) CourseDataView.Columns["Id"]!.Visible = false;
    }

    private void deleteCourseButton_Click(object sender, EventArgs e)
    {
        if (CourseDataView.SelectedRows.Count > 0)
        {
            var selectedRow = CourseDataView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is Guid courseId)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this course?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = _courseService.Delete(courseId);
                    if (result.IsOk)
                    {
                        MessageBox.Show("Course deleted successfully!");
                        LoadCourses();
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
            MessageBox.Show("Please select a course to delete.", "No Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void UpdateCourseButton_Click(object sender, EventArgs e)
    {
        if (CourseDataView.SelectedRows.Count > 0)
        {
            var selectedRow = CourseDataView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is Guid courseId)
            {
                if (ushort.TryParse(WorkLoadInput.Text, out var workLoad))
                {
                    var result = _courseService.Update(courseId, CourseName.Text, workLoad);
                    if (result.IsOk)
                    {
                        MessageBox.Show("Course updated successfully!");
                        LoadCourses();
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid workload.", "Invalid Input", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a course to update.", "No Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void CourseDataView_SelectionChanged(object? sender, EventArgs e)
    {
        if (CourseDataView.SelectedRows.Count > 0)
        {
            var selectedRow = CourseDataView.SelectedRows[0];
            if (selectedRow.Cells["Name"].Value != null) CourseName.Text = selectedRow.Cells["Name"].Value.ToString();

            if (selectedRow.Cells["WorkLoad"].Value != null)
                WorkLoadInput.Text = selectedRow.Cells["WorkLoad"].Value.ToString();
        }
    }

    private void searchStudentByNameInput_TextChanged(object sender, EventArgs e)
    {
        LoadCourses(CourseName.Text);
    }
}