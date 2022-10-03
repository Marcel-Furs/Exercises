using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2
{
    //internal - tylko w projekcie
    //public - rowniez mozna uzyc w innym projecie
    public class User
    {
        private string name;
        private string email;
        private string password;
        private int salary;

        public string Name //property
        {
            get
            {
                return name;
            }
            set
            {
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }

        public double Pi => 3.14;

        public string Email { get => email; set => email = value; }

        public string Password => password; //sam getter

        public int Id { get; set; }
        public int Salary { get => salary; set => salary = value; }

        public User(string name, string email, string password, int salary)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.Salary = salary;
        }

        public override string? ToString()
        {
            return $"User: {name} ({email})";
        }

        public virtual double Payment()
        {
            return salary;
        }
    }
}
