using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Calculator<T> where T : struct, IComparable, IConvertible, IFormattable
    {
        /* public double Add(double a,double b)
         {

             return a + b;
         }
        */



        /*
        public T Add(T a,T b)
      {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)((string)(object)a + (string)(object)b);
            }



            return (dynamic) a + (dynamic) b;
      }
        */


        public T Add(T a, T b)
        {
          
            return (dynamic)a + (dynamic)b;
        }
        public T subtract(T a, T b)
        {

            return (dynamic)b - (dynamic)a;
        }
        public T Miltiply(T a, T b)
        {

            return (dynamic) a * (dynamic)b;
        }
        public T Divide(T a, T b)
        {

            if((dynamic)b == 0 )
                throw new DivideByZeroException("Division by zero is not allowed");

            return (dynamic)a / (dynamic)b; 
        }

    }
}
