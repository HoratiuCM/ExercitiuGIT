using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuGIT_Mar
{
    public class Apple
    {
        public string color;
        public int size;

        public Apple(string colorParam, int sizeParam) {
        
            this.color = colorParam;
            this.size = sizeParam;

        }

        public void rot()
        {
            Console.WriteLine("Mar stricat");
        }

    }

    //commit si nebunii pe Branch1 
}
