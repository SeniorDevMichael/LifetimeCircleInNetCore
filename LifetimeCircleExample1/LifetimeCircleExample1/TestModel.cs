using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimeCircleExample1
{
    public class TestModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public string GUID1 { get; set; }
        public string GUID2 { get; set; }


        public TestModel(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public TestModel(string guid1, string guid12)
        {
            GUID1 = guid1;
            GUID2 = guid12;
        }
    }
}
