using System;
using System.Reflection;

namespace PRN_SE1624_APP_DOMAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain defaultAd = AppDomain.CurrentDomain;
            Assembly[] loadAssemblies = defaultAd.GetAssemblies();
            Console.WriteLine($"The assemblies loaded in {defaultAd.FriendlyName}");
            foreach(Assembly a in loadAssemblies)
            {
                Console.WriteLine($"Name: {a.GetName().Name}, Version: {a.GetName().Version}");
            }
        }
    }
}
