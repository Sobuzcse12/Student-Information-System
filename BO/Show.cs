using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BO
{
    public class Show
    {
        List<Student> stud;
        FileStream file;
        StreamReader read;
        Data_Input info;
        Student student;

        public Show()
        {
            stud = new List<Student>();
            info = new Data_Input();
        }

        public List<Student> getList()
        {
            return stud;
        }

        public void showAll()
        {
            try
            {
                file = new FileStream("Student Information System.txt", FileMode.Open, FileAccess.Read);
                read = new StreamReader(file);

                while (true)
                {
                    info.setStudent_Name(read.ReadLine());
                    info.setStudent_ID(read.ReadLine());
                    info.setStudent_Year(read.ReadLine());
                    info.setCalculate_CGPA(read.ReadLine());

                    student = new Student(info.getName(), info.getID(), info.getYear(), info.getCGPA());

                    if (info.getName() == null)
                    {
                        break;
                    }

                    stud.Add(student);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (read != null)
                {
                    read.Close();
                }
            }
        }
    }

    public class Student
    {
        private string name;
        private string id;
        private string year;
        private string cgpa;

        public Student(string name, string id, string year, string cgpa)
        {
            this.name = name;
            this.id = id;
            this.year = year;
            this.cgpa = cgpa;
        }


        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string CGPA
        {
            get
            {
                return cgpa;
            }
            set
            {
                cgpa = value;
            }
        }
    }
}
