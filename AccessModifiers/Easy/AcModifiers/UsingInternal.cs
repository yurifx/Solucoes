using System;
using System.Collections.Generic;
using System.Text;

namespace AcModifiers
{
    class UsingInternal
    {
        private void TestingInternal()
        {
            var t = new Train();
            t.InternalTest(); //works because it is in the same assembly.
        }
    }
}
