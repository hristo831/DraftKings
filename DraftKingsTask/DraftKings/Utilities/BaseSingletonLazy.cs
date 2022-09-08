using DraftKings.Endpoints;

namespace DraftKings.Utilities
{
    /// <summary>
    /// Base Singleton Lazy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseSingletonLazy<T>
        where T : new()
    {
        private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());


        public static T Instance => lazy.Value;

    }
}
