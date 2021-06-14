using Session20.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session20
{
    public static class FileHelper
    {
        public static void SaveToFile(BaseModel model, string fileName, bool showMessageBox = true)
        {
            var stringVlaue = model.GetStringValue("*#_#*");
            using (var sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(stringVlaue);
            }
            if (showMessageBox)
            {
                MessageBox.Show("Transaction successfully done.");
            }
        }


        #region Get From File   

        //public static List<Teacher> GetFromFile(string fileName)
        //{
        //    var teacherList = new List<Teacher>();

        //    using (var sr = new StreamReader(fileName))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            var stringValue = sr.ReadLine();

        //            var teacher = new Teacher();
        //            teacher.GetObjectFromString(stringValue, "*#_#*");
        //            teacherList.Add(teacher);
        //        }
        //    }

        //    return teacherList;
        //}

        //public static List<Course> GetCourseFromFile(string fileName)
        //{
        //    var courseList = new List<Course>();

        //    using (var sr = new StreamReader(fileName))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            var stringValue = sr.ReadLine();

        //            var course = new Course();
        //            course.GetObjectFromString(stringValue, "*#_#*");
        //            courseList.Add(course);
        //        }
        //    }

        //    return courseList;
        //}

        //public static List<Student> GetStudentsFromFile(string fileName)
        //{
        //    var studentList = new List<Student>();

        //    using (var sr = new StreamReader(fileName))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            var stringValue = sr.ReadLine();

        //            var student = new Student();
        //            student.GetObjectFromString(stringValue, "*#_#*");
        //            studentList.Add(student);
        //        }
        //    }

        //    return studentList;
        //}


        public static List<T> GetFromFile<T>(string fileName) where T : BaseModel
        {
            var studentList = new List<T>();

            using (var sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    var stringValue = sr.ReadLine();

                    var instance = (BaseModel) Activator.CreateInstance(typeof(T));
                    instance.GetObjectFromString(stringValue, "*#_#*");
                    studentList.Add((T)instance);
                }
            }

            return studentList;
        }

        #endregion

        #region Update File

        //internal static void UpdateFile(string fileName, Teacher itemToUpdate)
        //{
        //    var teachersList = GetFromFile(fileName);
        //    var selectedTeacher = teachersList.Find(t => t.ID == itemToUpdate.ID);
        //    selectedTeacher.Name = itemToUpdate.Name;
        //    selectedTeacher.Family = itemToUpdate.Family;

        //    SaveListToFile<Teacher>(teachersList, fileName);
        //}

        //internal static void UpdateFile(string fileName, Course itemToUpdate)
        //{
        //    var coursesList = GetCourseFromFile(fileName);
        //    var selectedTeacher = coursesList.Find(t => t.ID == itemToUpdate.ID);
        //    selectedTeacher.Name = itemToUpdate.Name;
        //    selectedTeacher.Point = itemToUpdate.Point;

        //    SaveListToFile<Course>(coursesList, fileName);
        //}

        //internal static void UpdateFile(string fileName, Student itemToUpdate)
        //{
        //    var studentsList = GetStudentsFromFile(fileName);
        //    var selectedTeacher = studentsList.Find(t => t.ID == itemToUpdate.ID);
        //    selectedTeacher.Name = itemToUpdate.Name;
        //    selectedTeacher.Family = itemToUpdate.Family;
        //    selectedTeacher.FatherName = itemToUpdate.FatherName;
        //    selectedTeacher.DateOfBirth = itemToUpdate.DateOfBirth;

        //    SaveListToFile<Student>(studentsList, fileName);
        //}

        internal static void UpdateFile<T>(string fileName, T itemToUpdate) where T : BaseModel
        {
            var coursesList = GetFromFile<T>(fileName);

            var selectedItem = coursesList.Find(t => t.ID == itemToUpdate.ID);
            selectedItem.CopyFrom(itemToUpdate);


            SaveListToFile<T>(coursesList, fileName);
        }

        #endregion

        #region Save List To File

        //private static void SaveListToFile(List<Teacher> model, string fileName)
        //{
        //    File.Delete(fileName);
        //    foreach (var item in model)
        //    {
        //        SaveToFile(item, fileName, false);
        //    }
        //    MessageBox.Show("Transaction successfully done.");
        //}

        //private static void SaveListToFile(List<Course> model, string fileName)
        //{
        //    File.Delete(fileName);
        //    foreach (var item in model)
        //    {
        //        SaveToFile(item, fileName, false);
        //    }
        //    MessageBox.Show("Transaction successfully done.");
        //}

        //private static void SaveListToFile(List<Student> model, string fileName)
        //{
        //    File.Delete(fileName);
        //    foreach (var item in model)
        //    {
        //        SaveToFile(item, fileName, false);
        //    }
        //    MessageBox.Show("Transaction successfully done.");
        //}

        private static void SaveListToFile<T>(List<T> model, string fileName) where T : BaseModel
        {
            File.Delete(fileName);
            foreach (var item in model)
            {
                SaveToFile(item, fileName, false);
            }
            MessageBox.Show("Transaction successfully done.");
        }

        #endregion
    }
}
