using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session20.Models;

namespace Session20.StudentForms
{
    public partial class StudentAdd : Form
    {
        private Student _student;
        public StudentAdd()
        {
            InitializeComponent();
            _student = new Student();
            txtID.Text = _student.ID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _student.Name = txtName.Text;
            _student.FatherName = txtFatherName.Text;
            _student.DateOfBirth = dtpDateOfBirth.Value;
            _student.Family = txtFamily.Text;
            FileHelper.SaveToFile(_student, "student.txt");
            ResetForm();
        }

        private void ResetForm()
        {
            _student = new Student();
            txtID.Text = _student.ID.ToString();
            txtFamily.Clear();
            txtName.Clear();
            txtFatherName.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
