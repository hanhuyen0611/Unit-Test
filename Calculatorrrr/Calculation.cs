using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorrrr
{
    public class Calculation
    {
        private int a, b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
       public int Execture(string operation)
        {
            int result = 0;
            switch(operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a *b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }    
            return result;

        }
        }
    }
