using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class FourthSingleton
    {
        private static readonly FourthSingleton instance = new FourthSingleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static FourthSingleton()
        {
        }

        private FourthSingleton()
        {
        }

        public static FourthSingleton Instance => instance;
    }
}
