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

namespace Session20.CourseForms
{
    public partial class CourseEdit : Form
    {
        public CourseEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var itemToEdit = new Course();
            itemToEdit.ID = new Guid(txtID.Text);
            itemToEdit.Name = txtName.Text;
            itemToEdit.Point = Convert.ToInt32(txtPoint.Text);

            var selectedIndex = cmbCourses.SelectedIndex;
            FileHelper.UpdateFile("Course.txt", itemToEdit);
            LoadCmbCourseDataSource(selectedIndex);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCourse = (Course)cmbCourses.SelectedItem;
            txtID.Text = selectedCourse.ID.ToString();
            txtPoint.Text = selectedCourse.Point.ToString();
            txtName.Text = selectedCourse.Name;
        }

        private void LoadCmbCourseDataSource(int selectedItemIndex = 0)
        {
            var CoursesList = FileHelper.GetFromFile<Course>("Course.txt");

            cmbCourses.DataSource = CoursesList;
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "ID";

            cmbCourses.SelectedIndex = selectedItemIndex;
        }

        private void CourseEdit_Load(object sender, EventArgs e)
        {
            LoadCmbCourseDataSource();
        }
    }
}
