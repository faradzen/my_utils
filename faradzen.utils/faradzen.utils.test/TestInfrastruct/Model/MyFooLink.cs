using System;

namespace faradzen.utils.test.TestInfrastruct.Model
{
    internal class MyFooLink
    {
        public string Value { get; set; }

        public DateTime Created { get; set; }

        public MyFooLink Child { get; set; }
    }
}
