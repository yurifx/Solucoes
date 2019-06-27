using System;

namespace Reflection
{
    internal class SomethingAttribute : Attribute
    {
        public bool Developer { get; set; }

        public SomethingAttribute(bool developer)
        {
            this.Developer = developer;
        }
    }
}