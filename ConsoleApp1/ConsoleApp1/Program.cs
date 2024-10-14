using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = typeof(Child).GetCustomAttribute<BAttribute>();

            //A 클래스에 IB 를 상속받는 B 클래스를 상속받는데 따로 IB 를 상속받으면?
            //List<int> a = null;
            //var a2 = a.AsReadOnly();

            //C# Closure
            //List<Action> a = new();
            //for (int i = 0; i < 4; i++)
            //{
            //    int localI = i; // 로컬 변수로 복사
            //    Action action = () => Console.WriteLine(i);
            //    a.Add(action);
            //}
            //a.ForEach((x) => x());
            //Console.WriteLine(a.GetType());
        }

    }
    #region struct
    public struct StructExam
    {
        public int a;
    }
    #endregion
    #region class template
    [B("test")]
    public abstract class Parent
    {
    }
    public class Child : Parent
    {

    }
    #endregion
}
