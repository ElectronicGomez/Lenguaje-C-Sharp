using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseDLL6a
{
    public class Class1  //public para que se pueda ver desde otro formulario
    {
        public int restar(int a, int b)
        {
            int r = a - b;
            return (r);
        }

        public int divide(int a, int b)  //public para poder verla desde otro formulario
        {
            int r = 0;
            try
            {
                 r = a / b;
            }
            catch (Exception ex)
            {
                r = 99990;
            }
            
            return (r);
        }

      

    }
}
