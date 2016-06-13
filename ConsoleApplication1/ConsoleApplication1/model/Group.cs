using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApplication1.model
{
    [XmlRoot]
    public class Group
    {
        public List<Employee> Employees = new List<Employee>();
    }

    [XmlInclude(typeof(Manager))]
    [XmlInclude(typeof(A))]
    [XmlInclude(typeof(B))]
    [XmlInclude(typeof(C))]
    [Serializable]
    public class Employee
    {
        [XmlAttribute]
        public string Name;
    }

    [Serializable]
    public class Manager : Employee
    {
        [XmlAttribute]
        public int Level;
    }
    [Serializable]
    public class A : Manager 
    {
        [XmlAttribute]
        public int Level;
    }
    [Serializable]
    public class B : Manager
    {
        [XmlAttribute]
        public int Level;
    }
    [Serializable]
    public class C : Manager
    {
        [XmlAttribute]
        public int Level;
    }
}
