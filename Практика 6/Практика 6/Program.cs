using System;
using System.Collections.Generic;
using System.Linq;

namespace Практика_6
{

    enum Education
    {
        Specialist,
        Вachelor,
        SecondEducation,
    }

    class Exam
    {


        public DateTime Date { get; set; }
        public string Subject { get; private set; }
        public int Mark { get; private set; }



        public Exam(string Subject, int Mark, DateTime DateOfExam)
        {
            this.Subject = Subject;
            this.Mark = Mark;
            this.Date = DateOfExam;
        }

        public Exam()
        {
            Subject = "IT Languages";
            Mark = 5;
            Date = new DateTime(2021, 1, 15, 14, 0, 0);
        }
        public override string ToString()
        {
            return "Exam : " + Subject + "\tMark: " + Mark.ToString() + "\tDate: " + Date.ToString("hh:mm , dd-mm-yyyy");
        }

        class Student
        {
            private Student data;
            private Education pay;
            private int number;
            private object sur;
            private object name;
            private object age;
            private object GroupID;
            private string v1;
            private int v2;
            private DateTime dateTime;

            public object Exams { get; private set; }
            public string Name { get; private set; }
            public object AverageMark { get; private set; }
            public bool Person { get; internal set; }

            public Student(Student info, Education pay, int number)
            {
                this.sur = info.sur;
                this.name = info.name;
                this.age = info.age;
                this.pay = info.pay;
                this.number = info.number;
                this.GroupID = info.GroupID;
            }

            public Student(string v1, int v2, DateTime dateTime)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.dateTime = dateTime;
            }

            public override string ToString()
            {
                return "Student : " + Name + "\tEducation : " + " " + "\tGroupID : " + GroupID.ToString()
                    + Sum(Exams, (x) => { return Environment.NewLine + x.ToString(); });
            }

            private string Sum(object exams, Func<object, object> p)
            {
                throw new NotImplementedException();
            }

            public string ToShortString()
            {
                return "Student : " /*+ StudentData.ToString()*/ + "\tEducation :" + " " + "\tGroupID :" + GroupID.ToString()
                    + "\tAvg. Mark : " + AverageMark.ToString();
            }

            public class Test
            {

            }

            internal void AddExams(Exam[] exams)
            {
                throw new NotImplementedException();
            }



            internal void AddTests(Exam.Test[] tests)
            {
                throw new NotImplementedException();
            }
        }

        internal class Test
        {
            private bool v1;
            private string v2;

            public Test(bool v1, string v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
        }

         


        class Program
            {
            static void Main(string[] args)
            {
                Student p1 = new Student("Ilyia", 18, new DateTime(2001, 9, 17));
                Student p2 = new Student("Rasim", 18, new DateTime(2001, 2, 10));
                Console.WriteLine(object.ReferenceEquals(p1, p2).ToString() + " " + p1.Equals(p2).ToString());

                Student student = new Student(p1, Education.Вachelor, 2);
                Exam[] exams = new Exam[4];
                exams[0] = new Exam("Metodologia", 5, new DateTime(2021, 1, 18, 10, 0, 0));
                exams[1] = new Exam("TMP", 5, new DateTime(2021, 1, 21, 13, 0, 0));
                exams[2] = new Exam("Math Analysis", 4, new DateTime(2021, 1, 24, 10, 0, 0));
                exams[3] = new Exam("IT Languages", 5, new DateTime(2021, 1, 28, 13, 0, 0));
                //student.AddExams(exams);
                Test[] tests = new Test[4];
                tests[0] = new Test(true, "Metodologia");
                tests[1] = new Test(true, "TMP");
                tests[2] = new Test(true, "Math Analysis");
                tests[3] = new Test(true, "IT Languages");
                //student.AddTests(tests);

                Console.WriteLine(student.Person);
                Console.WriteLine(student.ToString());
                }
            }
        }

    internal class Test
    {

    }
}

