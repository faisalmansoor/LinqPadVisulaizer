using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQPadVisualizer;
using Newtonsoft.Json;

namespace LINQPadVisualizerTest
{
    
    public class TestData
    {
        public int testInt { get; set; }
        public string MyProperty { get; set; }
        public object root { get; set; }

    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var tst = new TestData
            {
                MyProperty = "asasa",
                testInt = 121231,
                root = new
                {
                    child1 = new
                    {
                        child2 = new
                        {
                            child3 = new
                            {
                                child4 = new
                                {
                                    child5 = new
                                    {
                                        name = "child 5"
                                    }
                                }
                            }
                        }
                    }
                }
            };

            string json = JsonConvert.SerializeObject(tst, Formatting.Indented);
            Console.WriteLine(json);

            LINQPadVisualizer4JS.DebugShowVisualizer(new System.WeakReference(tst));
        }
    }
}
