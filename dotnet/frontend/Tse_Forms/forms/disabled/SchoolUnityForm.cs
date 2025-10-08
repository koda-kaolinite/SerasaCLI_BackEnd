using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Tse_Backend.Application;

namespace Tse_Forms.forms;

[Localizable(false)]
public partial class SchoolUnityForm : Form
{
    private readonly SchoolUnityService _schoolUnityService;

    public SchoolUnityForm()
    {
        InitializeComponent();
        _schoolUnityService = DI.ServiceProvider.GetRequiredService<SchoolUnityService>();
        LoadSchoolUnities();
        schoolUnitiesDataGridView.SelectionChanged += SchoolUnitiesDataGridView_SelectionChanged;
    }

    private void cadastrar_Click(object sender, EventArgs e)
    {
        var result = _schoolUnityService.Create(schoolUnityNameTextBox.Text);

        if (result.IsOk)
        {
            MessageBox.Show("School Unity registered successfully!");
            LoadSchoolUnities();
        }
        else
        {
            MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void LoadSchoolUnities(string? nameFilter = null)
    {
        var result = _schoolUnityService.GetAll();

        if (result.IsError)
        {
            MessageBox.Show($"Failed to load school unities: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var schoolUnities = result.Item.ToList();

        if (!string.IsNullOrWhiteSpace(nameFilter))
            schoolUnities = schoolUnities.Where(su => su.Name.ToLower().Contains(nameFilter.ToLower())).ToList();

        var schoolUnityData = schoolUnities.Select(su => new
        {
            su.Id,
            su.Name
        }).ToList();

        schoolUnitiesDataGridView.DataSource = schoolUnityData;
        if (schoolUnitiesDataGridView.Columns["Id"] != null) schoolUnitiesDataGridView.Columns["Id"]!.Visible = false;
    }

    private void deleteSchoolUnityButton_Click(object sender, EventArgs e)
    {
        if (schoolUnitiesDataGridView.SelectedRows.Count > 0)
        {
            var selectedRow = schoolUnitiesDataGridView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is Guid schoolUnityId)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this school unity?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = _schoolUnityService.Delete(schoolUnityId);
                    if (result.IsOk)
                    {
                        MessageBox.Show("School Unity deleted successfully!");
                        LoadSchoolUnities();
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
            MessageBox.Show("Please select a school unity to delete.", "No Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void UpdateSchoolUnity_Click(object sender, EventArgs e)
    {
        if (schoolUnitiesDataGridView.SelectedRows.Count > 0)
        {
            var selectedRow = schoolUnitiesDataGridView.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is Guid schoolUnityId)
            {
                var result = _schoolUnityService.Update(schoolUnityId, schoolUnityNameTextBox.Text);
                if (result.IsOk)
                {
                    MessageBox.Show("School Unity updated successfully!");
                    LoadSchoolUnities();
                }
                else
                {
                    MessageBox.Show($"An error occurred: {result.ErrorItem}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Please select a school unity to update.", "No Selection", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void SchoolUnitiesDataGridView_SelectionChanged(object? sender, EventArgs e)
    {
        if (schoolUnitiesDataGridView.SelectedRows.Count > 0)
        {
            var selectedRow = schoolUnitiesDataGridView.SelectedRows[0];
            schoolUnityNameTextBox.Text = selectedRow.Cells["Name"].Value?.ToString();
        }
    }

    private void searchSchoolUnityByNameInput_TextChanged(object sender, EventArgs e)
    {
        LoadSchoolUnities(schoolUnityNameTextBox.Text);
    }
}