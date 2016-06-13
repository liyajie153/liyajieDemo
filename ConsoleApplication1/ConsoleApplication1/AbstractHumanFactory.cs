using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   
   //public interface HumanFactory
   //{
   //    //制造一个黄色人种
   //    public Human createYellowHuman();
   //    //制造一个白色人种
   //    public Human createWhiteHuman();
   //    //制造一个黑色人种
   //    public Human createBlackHuman();
   //}
    public abstract class AbstractHumanFactory
    {
        public abstract T CreatHuman<T>(T c,string s) where T : Human;

    }
    public class HumanFactory : AbstractHumanFactory
    {
        public override T CreatHuman<T>(T c,string s)
        {
            Human human = null;
            try
            {
                human = (T)Activator.CreateInstance(Type.GetType(s));
            }
            catch (Exception ex)
            {
                Console.WriteLine("生产出错" + ex.ToString());
            }
            return (T)human;
        }
    }

}
