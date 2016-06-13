using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.model
{
    class Model1:HummerModel
    {
        protected override void start()
        {
            Console.WriteLine("1号车启动");
        }
        public void bStart(bool b) 
        {
            base.isStart = b;
        }
    }
}
