using System;
namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    class BAttribute : Attribute
    {
        public string Test { get; }
        public BAttribute(string value)
        {
            Test = value;
        }
    }
}
