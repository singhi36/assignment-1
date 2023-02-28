using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public class Person
    {
        string Name { get; set; }
        int Age { get; set; }


        public bool IsAdult() => this.Age >= 18;

        public Person(string takenName, int takenAge)
        {
            this.Name = takenName;
            this.Age = takenAge;
        }
    }
}
