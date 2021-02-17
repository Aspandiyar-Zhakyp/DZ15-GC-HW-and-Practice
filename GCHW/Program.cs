using System;
using System.Reflection;

namespace GCHW
{
    class Program
    {
       static void Main(string[] args)
       {
            var consoleType = typeof(Console);
        foreach (var type in consoleType.Assembly.GetTypes())
            {
            if (type.Name == "Console")
            {
                if (type.IsClass)
                {
                    foreach (var method in type.GetMethods())
                    {
                        if (method is MethodInfo)
                        {
                                Console.WriteLine(method);
                        }
                    }
                }
            }
       }

            var randomClass = new Random() { Id = 1, name = "Click", isRandom = false };
            foreach (var type in randomClass.GetType().Assembly.GetTypes())
            {
            if (type.IsClass)
            {
                foreach (var property in type.GetProperties())
                {
                    if (property is PropertyInfo)
                    {
                            Console.WriteLine($"{property.Name} = {property.GetValue(randomClass)}");
                    }
                }
            }
            }
        }
    }
}
