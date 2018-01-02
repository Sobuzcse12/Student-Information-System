using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BO
{
    public class Search
    {
        private Data_Input info;
        private FileStream file;
        private StreamReader read;

        public Search()
        {
            file = null;
            read = null;
            info = new Data_Input();
        }

        public void setSearch(string search)
        {
            info.setSearch(search);
        }

        public string getName()
        {
            return info.getSearchStudent_Name();
        }

        public string getID()
        {
            return info.getSearchStudent_ID();
        }

        public string getYear()
        {
            return info.getSearchStudent_Year();
        }

        public string getCGPA()
        {
            return info.getSearch_CGPA();
        }

        public bool searchFile()
        {
            bool flag = false;
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

                    if (info.getName() == null)
                    {
                        break;
                    }

                    if (info.getSearch().Equals(info.getName()) || info.getSearch().Equals(info.getID()))
                    {
                        info.setSearchStudent__Name(info.getName());
                        info.setSearchStudent_ID(info.getID());
                        info.setSearchStudent_Year(info.getYear());
                        info.setSearch_CGPA(info.getCGPA());
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
    }
}
