using Newtonsoft.Json;
using System;

namespace RpaTestModule
{
    public class TestClass
    {
        public void �׽�Ʈ()
        {
            Console.WriteLine("�׽�Ʈ");
            JsonConvert.SerializeObject(new TestClass());
        }

        public int �׽�Ʈ(int a, int b)
        {
            return a + b;
        }
    }
}
