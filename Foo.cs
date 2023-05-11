using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReflectionBugRepro
{
    public class Foo : Bar
    {
        public string PublicFromFoo { get; set; }
        private string PrivateFromFoo { get; set; }
    }

    public class Bar
    {
        public string PublicFromBar { get; set; }
        protected string ProtectedFromBar { get; set; }
    }
}
