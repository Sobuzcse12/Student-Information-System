using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BO
{
    public class Save
    {
        private FileStream file;
        private StreamWriter write;
        private Data_Input info;

        public Save()
        {
            file = null;
            write = null;
            info = new Data_Input();
        }

        public void setName(string name)
        {
            info.setStudent_Name(name);
        }

        public void setID(string id)
        {
            info.setStudent_ID(id);
        }

        public void setYear(string year)
        {
            info.setStudent_Year(year);
        }

        public void setCGPA(string cgpa)
        {
            info.setCalculate_CGPA(cgpa);
        }

        public void writeIntoFile()
        {
            try
            {
                file = new FileStream("Student Information System.txt", FileMode.Append, FileAccess.Write);
                write = new StreamWriter(file);

                write.WriteLine(info.getName());
                write.WriteLine(info.getID());
                write.WriteLine(info.getYear());
                write.WriteLine(info.getCGPA());

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            finally
            {
                if (write != null)
                {
                    write.Close();
                }
            }

        }
    }
}
