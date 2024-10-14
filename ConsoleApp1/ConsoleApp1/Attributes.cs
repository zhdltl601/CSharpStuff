using System;
namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class MSDNReferenceAttribute : Attribute
    {
        public MSDNReferenceAttribute(string msdnLink)
        {

        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    internal class BAttribute : Attribute
    {
        public string Test { get; }
        public BAttribute(string value)
        {
            Test = value;
        }
    }
}
