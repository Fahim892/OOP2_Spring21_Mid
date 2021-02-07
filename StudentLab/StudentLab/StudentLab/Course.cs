using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLab
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public String CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public String CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        internal void ShowInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Code : " + courseCode);
            Console.WriteLine("Course Credit : " + courseCredit);
        }
        static void Main()
        {
            Course cou1 = new Course();
            cou1.courseName = "X";
            cou1.courseCode = "1";
            cou1.courseCredit = 4;
            cou1.ShowInfo();
        }



