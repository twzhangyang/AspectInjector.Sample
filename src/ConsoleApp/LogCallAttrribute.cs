using AspectInjector.Broker;
using System;

namespace ConsoleApp
{
    [Aspect(Scope.Global)]
    [Injection(typeof(LogCall))]
    class LogCall : Attribute
    {
        [Advice(Kind.Before)]
        public void LogEnter([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Calling {name}");   //you can debug it	
        }
    }
}
