using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager:Employee
    {
        private int performanceCount;
        private int mangerBouns;

        public int MangerBouns
        {
            get { return mangerBouns; }
            set { mangerBouns = value; }
        }

        public Manager(string id, string name, int baseSalary, int bouns)
        {
            this.Id = id;
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.mangerBouns = bouns;
        }
       
        public Manager(string id, string name, string baseSalary, string bouns)
            : this(id, name, int.Parse(baseSalary), int.Parse(bouns))
        {
        }

        virtual public double BaseSalary
        {
            get { return this.baseSalary; }
            set
            {
                this.baseSalary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n總薪:{0}"
                , this.mangerBouns + this.baseSalary);
        }
    }
}
