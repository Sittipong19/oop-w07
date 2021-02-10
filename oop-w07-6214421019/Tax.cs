using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop-w07-6214421019
{
    class Tax
    {
        private int income;
        private int dispense;


        public Tax() { }
        public Tax(int i) { this.income = i; }

        public int Income { get => income; set => income = value; }
        public int Dispense { get => dispense; set => dispense = value; }

        public override string ToString()
        {
            double tax = 0;
            if (this.Income <= 150000)
            {
                tax = 0;
            }
            else if (this.Income <= 3000000)
            {
                tax = (this.Income - 150000) * (0.05);
            }
            else if (this.Income <= 500000)
            {
                tax = (this.Income - 300000) * 0.1 + 7500;
            }
            else if (this.Income <= 750000)
            {
                tax = (this.Income - 500000) * 0.15 + 7500 + 20000;
            }
            else if (this.Income <= 1000000)
            {
                tax = (this.Income - 750000) * 0.2 + 7500 + 20000 + 37500;
            }
            else if (this.Income <= 2000000)
            {
                tax = (this.Income - 2000000) * 0.3 + 7500 + 20000 + 37500 + 50000;
            }
            else if (this.Income <= 500000)
            {
                tax = (this.Income - 2000000) * 0.3 + 7500 + 20000 + 37500 + 50000 + 250000;
            }
            else
            {
                tax = (this.Income - 5000000) * 0.35 - 7500 + 20000 + 37500 + 50000 + 250000 + 900000;
            }
            return " ภาษีที่ต้องจ่าย = " + tax;
        }
    }
}
