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

namespace Session20.StudentForms
{
    public partial class StudentEdit : Form
    {
        public StudentEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var itemToEdit = new Student();
            itemToEdit.ID = new Guid(txtID.Text);
            itemToEdit.Name = txtName.Text;
            itemToEdit.Family = txtFamily.Text;

            var selectedIndex = cmbStudents.SelectedIndex;
            FileHelper.UpdateFile("Students.txt", itemToEdit);
            LoadCmbStudentsDataSource(selectedIndex);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {
            LoadCmbStudentsDataSource();
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = (Student)cmbStudents.SelectedItem;
            txtID.Text = selectedStudent.ID.ToString();
            txtFamily.Text = selectedStudent.Family;
            txtName.Text = selectedStudent.Name;
            txtFatherName.Text = selectedStudent.FatherName;
            dtpDateOfBirth.Value = selectedStudent.DateOfBirth;
        }

        private void LoadCmbStudentsDataSource(int selectedItemIndex = 0)
        {
            var StudentsList = FileHelper.GetFromFile<Student>("Student.txt");

            cmbStudents.DataSource = StudentsList;
            cmbStudents.DisplayMember = "Family";
            cmbStudents.ValueMember = "ID";

            cmbStudents.SelectedIndex = selectedItemIndex;
        }
    }
}
