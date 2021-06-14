using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session20
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new CourseForms.CourseAdd());
        }

        private void addProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMdiForm(new TeacherForms.TeacherAdd());
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new StudentForms.StudentAdd());
        }

        private void editProfessorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new TeacherForms.TeacherEdit());
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new CourseForms.CourseEdit());
        }

        private void editStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new StudentForms.StudentEdit());
        }

        private void ShowMdiForm(Form form)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].GetType() == form.GetType())
                {
                    MessageBox.Show("You have an instace of this form Open. Please close it first;");
                    return;
                }
            }

            form.MdiParent = this;
            form.Show();
        }
    }
}
