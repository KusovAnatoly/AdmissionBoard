using Phoenix.Models;
using PhoenixLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phoenix.Views
{
    public partial class SpecialtyForm : Form
    {
        public SpecialtyForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string profession = "Программа подготовки квалифицированных рабочих и служащих";
            string specialty = "Программа подготовки специалистов среднего звена";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "specialties.json");
            var specialties = JsonHelper.Deserialize<Specialty>(filePath);
            var temp = specialties
                .Select(x => new { Name = x.Name, Level = x.IsProffesion ? profession : specialty });
            _dataGridViewSpecialties.ReadOnly = true;
            _dataGridViewSpecialties.DataSource = temp.ToList();
            _dataGridViewSpecialties.Columns[0].HeaderText = "Наименование";
            _dataGridViewSpecialties.Columns[1].HeaderText = "Уровень образования";
            _dataGridViewSpecialties.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _dataGridViewSpecialties.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadData(string query)
        {
            string profession = "Программа подготовки квалифицированных рабочих и служащих";
            string specialty = "Программа подготовки специалистов среднего звена";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "specialties.json");
            var specialties = JsonHelper.Deserialize<Specialty>(filePath);
            var temp = specialties
                .Select(x => new { Name = x.Name, Level = x.IsProffesion ? profession : specialty });
            _dataGridViewSpecialties.ReadOnly = true;
            _dataGridViewSpecialties.DataSource = temp
                .Where(x => x.Name.Contains(query) | x.Level.Contains(query))
                .ToList();
            _dataGridViewSpecialties.Columns[0].HeaderText = "Наименование";
            _dataGridViewSpecialties.Columns[1].HeaderText = "Уровень образования";
            _dataGridViewSpecialties.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _dataGridViewSpecialties.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _textBoxSearch.Visible = false;
            _panelAddEdit.Visible = true;
            _panelSaveCancel.Visible = true;
            _buttonCancel.Visible = true;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "specialties.json");
            List<Specialty> specialties = JsonHelper.Deserialize<Specialty>(filePath);
            specialties.Add(new Specialty { Name = _textBoxName.Text, IsProffesion = _radioButtonProfession.Checked ? true : false });
            JsonHelper.Serialize(specialties, filePath);
            LoadData();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _textBoxSearch.Visible = true;
            _panelAddEdit.Visible = false;
            _panelSaveCancel.Visible = false;
            _buttonCancel.Visible = false;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var query = _textBoxSearch.Text;
            if (string.IsNullOrEmpty(query))
            {
                LoadData();
            }
            else
            {
                LoadData(query);
            }
        }
    }
}
