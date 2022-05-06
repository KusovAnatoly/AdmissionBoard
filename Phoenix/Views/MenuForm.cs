namespace Phoenix.Views
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "parents.json");
        }

        private void ButtonSpecialties_Click(object sender, EventArgs e)
        {
            SpecialtyForm specialtyForm = new SpecialtyForm();
            specialtyForm.Show();
        }
    }
}
