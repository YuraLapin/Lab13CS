using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    public class Train : Transport
    {
        public int cars;

        public Train() : base()
        {
            cars = 0;
        }

        public Train(in string name, in int maxSpeed, in int cars) : base(name, maxSpeed)
        {
            this.cars = cars;
        }

        public Train(in Train t): base (t)
        {
            cars = t.cars;
        }

        public override void RandomInit()
        {
            var sb = new StringBuilder();
            int nameSize = 5;
            string alphabet = "qwertyuiopasdfghjklzxcvbnm1234567890";
            for (int i = 0; i < nameSize; ++i)
            {
                sb.Append(alphabet[Program.rand.Next(alphabet.Length)]);
            }
            name = sb.ToString();

            int maxPower = 1000;
            power = Program.rand.Next(maxPower);

            int maxCars = 9;
            cars = Program.rand.Next(maxCars);
        }

        public override string ToString()
        {
            return name.ToString() + ": power - " + power.ToString() + ", cars - " + cars.ToString();
        }        

        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is Train t)
                {
                    //return Equals(this.name, t.name) && Equals(this.power, t.power) && Equals(this.cars, t.cars);
                    return Equals(this.ToString(), t.ToString());
                }
            }
            return false;
        }
    }
}