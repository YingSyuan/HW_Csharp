using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Form
{
    internal class MyClass
    {
    }
    public class Bar
    {
        public string Name { get; set; }
        public int Dollar { get; set; }
        public string Total { get; set; }
        public Bar(string name, int dollar,string total)  
        {
            Name = name;
            Dollar = dollar;
            Total = total;
        }
    }
    public struct Grade
    {
        public string Name;
        public int Chinese;
        public int English;
        public int Math;
    }
}
