using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop-w07-6214421001
{
    class Staff
    {
        private string name;
        private int income;
        private int dispense;

        public string Name { get => name; set => name = value; }

        public int Income { get => income; set => income = value; }

        public int Dispense { get => dispense; set => dispense = value; }

        public Staff(string n, int i, int d)
        {
            this.name = n;
            this.income = i;
            this.dispense = d;
        }

        public override string ToString()
        {
            int total_income = this.Income - this.Dispense;
            return this.Name + " รายรับรวม " + total_income;
        }
    }
    }

