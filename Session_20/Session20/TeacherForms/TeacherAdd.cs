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

namespace Session20.TeacherForms
{
    public partial class TeacherAdd : Form
    {
        private Teacher _teacher;
        public TeacherAdd()
        {
            InitializeComponent();
            _teacher = new Teacher();
            txtID.Text = _teacher.ID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _teacher.Name = txtName.Text;
            _teacher.Family = txtFamily.Text;


            FileHelper.SaveToFile(_teacher, "teacher.txt");
            ResetForm();
        }

        private void ResetForm()
        {
            _teacher = new Teacher();
            txtID.Text = _teacher.ID.ToString();
            txtFamily.Clear();
            txtName.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
    }
    }
}
