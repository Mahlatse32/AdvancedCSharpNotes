namespace Generics
{
    public class Nullibe<T> where T : struct
    {
        private object _value;
        public Nullibe()
        {

        }
        public Nullibe(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get
            { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}


