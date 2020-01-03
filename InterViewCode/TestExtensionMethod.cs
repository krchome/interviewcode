using System;
using ExtensionMethodSample;

namespace InterViewCode
{
    class TestExtensionMethod
    {
        static void Main()
        {
            string s = "Extension methods are a way to extend an " +
                "existing class without creating a new derived class";
            int i = s.WordCount();
            Console.WriteLine($"The number of words in 's' is {i}");
        }
    }
}
