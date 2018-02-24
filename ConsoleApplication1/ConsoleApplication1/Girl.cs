using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Girl:IGreatTemperamentGirl,IGoodBodyGirl
    {
        public void greatTemperament()
        {
            Console.WriteLine("气质1");
        }

        public void goodLooking()
        {
            Console.WriteLine("外表");
        }

        public void niceFigure()
        {
            Console.WriteLine("外表");
        }
    }
}
