using Session20.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session20.TeacherForms
{
    public partial class TeacherEdit : Form
    {
        public TeacherEdit()
        {
            InitializeComponent();
        }

        private void TeacherEdit_Load(object sender, EventArgs e)
        {
            LoadCmbTeachersDataSource();
        }

        private void cmbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTeacher = (Teacher)cmbTeachers.SelectedItem;
            txtID.Text = selectedTeacher.ID.ToString();
            txtFamily.Text = selectedTeacher.Family;
            txtName.Text = selectedTeacher.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var itemToEdit = new Teacher();
            itemToEdit.ID = new Guid(txtID.Text);
            itemToEdit.Name = txtName.Text;
            itemToEdit.Family = txtFamily.Text;

            var selectedIndex = cmbTeachers.SelectedIndex;
            FileHelper.UpdateFile("teacher.txt", itemToEdit);
            LoadCmbTeachersDataSource(selectedIndex);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCmbTeachersDataSource(int selectedItemIndex = 0)
        {
            var teachersList = FileHelper.GetFromFile<Teacher>("teacher.txt");

            cmbTeachers.DataSource = teachersList;
            cmbTeachers.DisplayMember = "Family";
            cmbTeachers.ValueMember = "ID";

            cmbTeachers.SelectedIndex = selectedItemIndex;
        }
    }
}
