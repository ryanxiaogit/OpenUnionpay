using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Infrastructure.CommonTest
{
    public class TestJSonModel
    {
        public string Name { get; set; } = "testName";
        public int Age { get; set; } = 30;
        public TestSubModel SubItem { get; set; } = new TestSubModel();
    }
}
