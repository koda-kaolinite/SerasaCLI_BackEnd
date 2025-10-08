namespace Tse_Forms.forms;

public partial class StartMenu : Form
{
    public StartMenu()
    {
        InitializeComponent();
    }

    private void AlunosImagem_Click(object sender, EventArgs e)
    {
        var studentsForm = new StudentForm();
        studentsForm.Show();
    }

    private void CursosImagem_Click(object sender, EventArgs e)
    {
        var courseForm = new CourseForm();
        courseForm.Show();
    }

    private void UnidadesEnsinoImagem_Click(object sender, EventArgs e)
    {
        var schoolUnityForm = new SchoolUnityForm();
        schoolUnityForm.Show();
    }
}