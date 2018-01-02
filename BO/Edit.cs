using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BO
{
    public class Edit
    {
        private FileStream readFile;
        private StreamReader read;
        private FileStream deleteFile;
        private StreamWriter delete;
        private Data_Input info;

        public Edit()
        {
            readFile = null;
            read = null;
            deleteFile = null;
            delete = null;
            info = new Data_Input();
        }

        public void setSearch(string search)
        {
            info.setSearch(search);
        }

        public void setNewName(string name)
        {
            info.setAgainStudent_Name(name);
        }

        public void setNewID(string id)
        {
            info.setAgainStudent_ID(id);
        }

        public void setNewYear(string year)
        {
            info.setAgainStudent_Year(year);
        }

        public void setNewCGPA(string cgpa)
        {
            info.setAgainStudent_CGPA(cgpa);
        }

        public bool findID()
        {
            bool flag = false;
            try
            {
                readFile = new FileStream("Student Information System.txt", FileMode.Open, FileAccess.Read);
                read = new StreamReader(readFile);

                while (true)
                {
                    info.setStudent_Name(read.ReadLine());
                    info.setStudent_ID(read.ReadLine());
                    info.setStudent_Year(read.ReadLine());
                    info.setCalculate_CGPA(read.ReadLine());

                    if (info.getName() == null)
                    {
                        break;
                    }

                    if (info.getSearch().Equals(info.getName()) || info.getSearch().Equals(info.getID()))
                    {
                        flag = true;
                        break;
                    }
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

            return flag;
        }

        public void editInfoFromFile()
        {
            try
            {
                readFile = new FileStream("Student Information System.txt", FileMode.Open, FileAccess.Read);
                read = new StreamReader(readFile);

                deleteFile = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
                delete = new StreamWriter(deleteFile);

                while (true)
                {
                    info.setStudent_Name(read.ReadLine());
                    info.setStudent_ID(read.ReadLine());
                    info.setStudent_Year(read.ReadLine());
                    info.setCalculate_CGPA(read.ReadLine());

                    if (info.getName() == null)
                    {
                        break;
                    }

                    if (info.getSearch().Equals(info.getName()) || info.getSearch().Equals(info.getID()))
                    {
                        delete.WriteLine(info.getAgainStudent_Name());
                        delete.WriteLine(info.getAgainStudent_ID());
                        delete.WriteLine(info.getAgainStudent_Year());
                        delete.WriteLine(info.getAgainStudent_CGPA());
                    }
                    else
                    {
                        delete.WriteLine(info.getName());
                        delete.WriteLine(info.getID());
                        delete.WriteLine(info.getYear());
                        delete.WriteLine(info.getCGPA());
                    }
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
                    File.Delete("Student Information System.txt");
                }
                if (delete != null)
                {
                    delete.Close();
                    File.Move("temp.txt", "Student Information System.txt");
                    File.Delete("temp.txt");
                }
            }
        }
    }
}
