using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   public interface Human
    {
        //每个人种的皮肤都有相应的颜色
         void getColor();
        //人类会说话
         void talk();
         //void sex();
    }
   public class BlackHuman : Human
   {
       public void getColor()
       {
           Console.WriteLine("黑色人种的皮肤颜色是黑色的！");
       }
       public void talk()
       {
           Console.WriteLine("黑人会说话，一般人听不懂。");
       }
   }
   public class WhiteHuman : Human
   {
       public void getColor()
       {
           Console.WriteLine("白色人种的皮肤颜色是黑色的！");
       }
       public void talk()
       {
           Console.WriteLine("白人会说话，单音节。");
       }
   }
   public class YellowHuman : Human
   {
       public void getColor()
       {
           Console.WriteLine("黄色人种的皮肤颜色是黑色的！");
       }
       public void talk()
       {
           Console.WriteLine("黄人会说话，双音节。");
       }
   }
   public class FemaleYellowHuman : YellowHuman 
   {
       public void sex() 
       {
           Console.WriteLine("黄人男。");
       }
   }
   public class MaleYellowHuman : YellowHuman
   {
       public void sex()
       {
           Console.WriteLine("黄人女。");
       }
   }
   public class FemaleBlackHuman : BlackHuman
   {
       public void sex()
       {
           Console.WriteLine("黑人男。");
       }
   }
   public class MaleBlackHuman : BlackHuman
   {
       public void sex()
       {
           Console.WriteLine("黑人女。");
       }
   }
   public class FemaleWhiteHuman : WhiteHuman
   {
       public void sex()
       {
           Console.WriteLine("白人男。");
       }
   }
   public class MaleWhiteHuman : YellowHuman
   {
       public void sex()
       {
           Console.WriteLine("白人女。");
       }
   }
}
