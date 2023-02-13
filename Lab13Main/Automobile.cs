using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    public class Automobile: Transport
    {
        public int wheels;

        public Automobile(): base()
        {
            this.wheels = 0;
        }

        public Automobile(in string name, in int maxSpeed, in int horsepowers): base(name, maxSpeed)
        {
            this.wheels = horsepowers;
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

            int maxWheels = 9;
            wheels = Program.rand.Next(maxWheels);
        }

        public override string ToString()
        {
            return name.ToString() + ": power - " + power.ToString() + ", wheels - " + wheels.ToString();
        }        
    }
}