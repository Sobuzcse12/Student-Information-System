using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Data_Input
    {
        private string Name;
        private string ID;
        private string Year;
        private string CPGA;

        private string Student_Name;
        private string Student_ID;
        private string Student_Year;
        private string Again_CGPA;

        private string Search_Name;
        private string Search_ID;
        private string Search_Year;
        private string Search_CGPA;

        private string search;

        public void setStudent_Name(string name)
        {
            this.Name = name;
        }

        public void setStudent_ID(string id)
        {
            this.ID = id;
        }

        public void setStudent_Year(string year)
        {
            this.Year = year;
        }

        public void setCalculate_CGPA(string cgpa)
        {
            this.CPGA = cgpa;
        }

        public void setAgainStudent_Name(string name)
        {
            this.Student_Name = name;
        }

        public void setAgainStudent_ID(string id)
        {
            this.Student_ID = id;
        }

        public void setAgainStudent_Year(string year)
        {
            this.Student_Year = year;
        }

        public void setAgainStudent_CGPA(string cgpa)
        {
            this.Again_CGPA = cgpa;
        }

        public void setSearchStudent__Name(string name)
        {
            this.Search_Name = name;
        }

        public void setSearchStudent_ID(string id)
        {
            this.Search_ID = id;
        }

        public void setSearchStudent_Year(string year)
        {
            this.Search_Year = year;
        }

        public void setSearch_CGPA(string cgpa)
        {
            this.Search_CGPA = cgpa;
        }

        public string getName()
        {
            return Name;
        }

        public string getID()
        {
            return ID;
        }

        public string getYear()
        {
            return Year;
        }

        public string getCGPA()
        {
            return CPGA;
        }

        public string getAgainStudent_Name()
        {
            return Student_Name;
        }

        public string getAgainStudent_ID()
        {
            return Student_ID;
        }

        public string getAgainStudent_Year()
        {
            return Student_Year;
        }

        public string getAgainStudent_CGPA()
        {
            return Again_CGPA;
        }

        public string getSearchStudent_Name()
        {
            return Search_Name;
        }

        public string getSearchStudent_ID()
        {
            return Search_ID;
        }

        public string getSearchStudent_Year()
        {
            return Search_Year;
        }

        public string getSearch_CGPA()
        {
            return Search_CGPA;
        }


        public void setSearch(string search)
        {
            this.search = search;
        }

        public string getSearch()
        {
            return search;
        }
    }
}
