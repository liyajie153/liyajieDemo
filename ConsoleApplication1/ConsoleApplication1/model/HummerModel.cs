using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.model
{
  public abstract  class HummerModel
    {
      protected abstract void start();
      protected bool isStart;

      //public bool IsStart
      //{
      //    get { return isStart; }
      //    set { isStart = value; }
      //}
      
      public void run() 
      {
          if (this.isStart ) 
          {
              this.start();
          }
      }
    }
}
