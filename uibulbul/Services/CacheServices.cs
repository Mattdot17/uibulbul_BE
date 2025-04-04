namespace uibulbul.Services
{
    public class CacheServices<T>
    {
        public Dictionary<int, T> cache = new();

        public bool GetKey(int id, out T value)
        {
            return cache.TryGetValue(id, out value);
        }

        public void SetKey(int id, T value)
        {
            cache[id] = value;
        }
    }
}
