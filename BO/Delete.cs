using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BO
{
    public class DeleteFromFile
    {
        private StreamWriter Delete;
        private Data_Input info;
        private StreamReader Read;
        private FileStream DeleteFile;
        private FileStream ReadFile;

        public void setSearch(string search)
        {
            info.setSearch(search);
        }
        public DeleteFromFile()
        {
            DeleteFile = null;
            Delete = null;
            ReadFile = null;
            Read = null;
            info = new Data_Input();
        }

        public bool FindStudent_Info()
        {
            bool temp = false;
            try
            {
                ReadFile = new FileStream("Student Information System.txt", FileMode.Open, FileAccess.Read);
                Read = new StreamReader(ReadFile);

                while (true)
                {
                    info.setStudent_Name(Read.ReadLine());
                    info.setStudent_ID(Read.ReadLine());
                    info.setStudent_Year(Read.ReadLine());
                    info.setCalculate_CGPA(Read.ReadLine());

                    if (info.getName() == null)
                    {
                        break;
                    }

                    if (info.getSearch().Equals(info.getID()))
                    {
                        temp = true;
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
                if (Read != null)
                {
                    Read.Close();
                }
            }

            return temp;
        }

        public void deleteItemFromFile()
        {
            try
            {
                DeleteFile = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
                Delete = new StreamWriter(DeleteFile);

                ReadFile = new FileStream("Student Information System.txt", FileMode.Open, FileAccess.Read);
                Read = new StreamReader(ReadFile);

                while (true)
                {
                    info.setStudent_Name(Read.ReadLine());
                    info.setStudent_ID(Read.ReadLine());
                    info.setStudent_Year(Read.ReadLine());
                    info.setCalculate_CGPA(Read.ReadLine());

                    if (info.getName() == null)
                    {
                        break;
                    }

                    if (info.getSearch().Equals(info.getID()))
                    {
                        continue;
                    }
                    else
                    {
                        Delete.WriteLine(info.getName());
                        Delete.WriteLine(info.getID());
                        Delete.WriteLine(info.getYear());
                        Delete.WriteLine(info.getCGPA());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (Read != null)
                {
                    Read.Close();
                    File.Delete("Student Information System.txt");
                }
                if (Delete != null)
                {
                    Delete.Close();
                    File.Move("temp.txt", "Student Information System.txt");
                    File.Delete("temp.txt");
                }
            }

        }
    }
}
