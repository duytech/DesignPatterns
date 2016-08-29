namespace DesignPatterns.Core.Singleton
{
    using System;
    public sealed class SixthSingleton
    {
        private static readonly Lazy<SixthSingleton> lazy = new Lazy<SixthSingleton>(() => new SixthSingleton());

        public static SixthSingleton Instance { get { return lazy.Value; } }

        private SixthSingleton()
        {
        }
    }
}
