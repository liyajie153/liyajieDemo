using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ConsoleApplication1.model;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Group g = new Group();
            g.Employees.Add(new A() { Name = "A", Level = 1 });
            g.Employees.Add(new B() { Name = "B", Level = 2 });
            g.Employees.Add(new C() { Name = "C", Level = 3 });
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                XmlWriterSettings xmlSetting = new XmlWriterSettings();
                xmlSetting.Encoding = Encoding.UTF8;
                xmlSetting.Indent = true;
                XmlWriter utf8wr = XmlWriter.Create(ms, xmlSetting);
                XmlSerializer mySerializer = new XmlSerializer(typeof(Group), "http://www.thermo.com/informatics/xmlns/limsml/1.0");
               
                mySerializer.Serialize(utf8wr, g);
         
                string url = "ftp://10.0.144.43/";
                string filename = "Workflow/" + string.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now) + ".xml";
                string strtmp = Encoding.UTF8.GetString(ms.ToArray());

                XmlSerializer serializer = new XmlSerializer(typeof(Group), "http://www.thermo.com/informatics/xmlns/limsml/1.0");
                MemoryStream ms2 = new MemoryStream(Encoding.UTF8.GetBytes(strtmp));
                StreamReader sr = new StreamReader(ms2, Encoding.UTF8);

                Group m2 = (Group)serializer.Deserialize(sr);

                //return strtmp;
            }
          
            //int[] array = new int[] { 1, 22, 45, 1234, 67, 31 };
            //for (int i = 0; i < array.Length; i++) 
            //{
            //    for (int j = i+1; j < array.Length; j++) 
            //    {
            //        if (array[i] < array[j]) 
            //        {
            //            int temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}

            Model1 m1 = new Model1();
            // m1.IsStart = true;
            m1.bStart(false);
             m1.run();
            //AbstractHumanFactory yinyanglu = new HumanFactory();
            //Human white = yinyanglu.CreatHuman(new WhiteHuman(),typeof(WhiteHuman).ToString());
            //white.getColor();
            //white.talk();
            //IGreatTemperamentGirl g = new Girl();
           
            //ArrayList list = new ArrayList();
          
            //foreach (var v in list) { }
            //Father<int> f = new Father<int>();
            //f.AddHead(10);
            //f.AddHead(1);
            //f.AddHead(2);
            //f.AddHead(3);
            //f.AddHead(4);
            //foreach (int i in f)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}
