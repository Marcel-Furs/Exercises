using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2
{
    public class Administrator : User
    {
        private double bonus;

        public Administrator(string name, string email, string password, int salary, double bonus) : base(name, email, password, salary)
        {
            this.bonus = bonus;
        }

        public override double Payment()
        {
            return base.Payment() + bonus * Salary;
        }
    }
}
