using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Student
    {
        private int _studentId;
        private string _studentFname;
        private string _studentLname;
        private char _studentGrade;

        public Student()
        {

        }
        public Student(int studentId, string studentFname, string studentLname, char studentGrade)
        {
            this.studentId = studentId;
            this.studentFname = studentFname;
            this.studentLname = studentLname;
            this.studentGrade = studentGrade;

        }
        public int studentId
        {
            get { return this._studentId; }
            set { this._studentId = value; }
        }

        public string studentFname
        {
            get { return this._studentFname; }
            set { this._studentFname = value; }
        }

        public string studentLname
        {
            get { return this._studentLname; }
            set { this._studentLname = value; }
        }

        public char studentGrade
        {
            get { return this._studentGrade; }
            set
            {
                if (value > 0)
                {
                    this._studentGrade = value;
                }
            }
        }
}
