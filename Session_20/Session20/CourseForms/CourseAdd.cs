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

namespace Session20.CourseForms
{
    public partial class CourseAdd : Form
    {
        private Course _course;

        public CourseAdd()
        {
            InitializeComponent();
            _course = new Course();
            txtID.Text = _course.ID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _course.Name = txtName.Text;
            _course.Point = Convert.ToInt32(txtPoint.Text);
            FileHelper.SaveToFile(_course, "course.txt");
            ResetForm();
        }

        private void ResetForm()
        {
            _course = new Course();
            txtID.Text = _course.ID.ToString();
            txtPoint.Clear();
            txtName.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
