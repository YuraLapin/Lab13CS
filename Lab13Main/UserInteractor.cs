using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    public class UserInteractor
    {
        public static int GetIntFromUser(string? msg, bool checkMinus = false)
        {
            bool finished = false;
            int inp = 0;
            string? buf;
            do
            {
                Console.Write(msg + ": ");
                buf = Console.ReadLine();
                if (buf == "" || buf == null)
                {
                    Console.WriteLine("Не введено число");
                }
                else if (!int.TryParse(buf, out inp))
                {
                    bool isInt = true;
                    for (int i = 0; i < buf.Length; ++i)
                    {
                        if ("0123456789".IndexOf(buf[i]) < 0)
                        {
                            isInt = false;
                        }
                    }
                    if (isInt)
                    {
                        Console.WriteLine("Число слишком большое");
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть целым и состоять только из цифр");
                    }
                }
                else
                {
                    inp = int.Parse(buf);
                    if (checkMinus)
                    {
                        if (inp < 0)
                        {
                            inp = 0;
                            Console.WriteLine("Число должно быть положительным");
                        }
                        else
                        {
                            finished = true;
                        }
                    }
                    else
                    {
                        finished = true;
                    }
                }
            }
            while (!finished);
            return inp;
        }
    }
}