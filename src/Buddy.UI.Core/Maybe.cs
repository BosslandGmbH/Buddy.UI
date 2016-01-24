namespace Buddy.UI.Core
{
    public struct Maybe<T> where T : class
    {
        public bool HasValue { get; }

        public T Value { get; }

        public Maybe(T value)
        {
            HasValue = value != null;
            Value = value;
        }
    }
}