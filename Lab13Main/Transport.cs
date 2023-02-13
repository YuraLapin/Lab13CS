using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    public class Transport
    {
        public string name;
        public int power;

        public Transport()
        {
            name = "";
            power = 0;
        }

        public Transport(in string name, in int maxSpeed)
        {
            this.name = name;
            this.power = maxSpeed;
        }

        public Transport(in Transport t)
        {
            this.name = t.name;
            this.power = t.power;
        }

        public virtual void RandomInit()
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
        }

        public override string ToString()
        {
            return name.ToString() + ": power - " + power.ToString();
        }        

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }       
        
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is Transport t)
                {
                    //return Equals(this.name, t.name) && Equals(this.power, t.power);
                    return Equals(this.ToString(), t.ToString());
                }
            }
            return false;
        }
    }
}