using System;
using System.Reactive;
using System.Reactive.Linq;

namespace Reactive
{
    [ConsoleApp1.MSDNReference("https://learn.microsoft.com/en-us/previous-versions/dotnet/reactive-extensions/")]
    public class Program
    {
        public static void Main(string[] args)
        {
            static void Countdown(int seconds)
            {
                Observable.Timer(DateTimeOffset.UtcNow, TimeSpan.FromSeconds(1))
                .Subscribe((currentTime) =>
                {
                    Console.Write(currentTime);
                });
            }
            Countdown(5);
            Console.ReadLine();
        }
    }
}
