using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faradzen.utils.test.TestInfrastruct.Model
{
    internal class MyFoo
    {
        public int Oid { get; set; }

        public string Name { get; set; }

        public MyFooLink Link { get; set; }

        public MyFooBook Book { get; set; }
    }
}
