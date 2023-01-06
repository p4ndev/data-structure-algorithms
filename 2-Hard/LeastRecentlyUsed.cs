using System.Collections;

namespace Hard;

/// <summary>
/// Design and implement a data structure for least recently used cache, It should support only two main operations (get and put).
/// <para>When the cache reached its capacity, it should <c>invalidate the least recently used</c> item before inserting a new item.</para>
/// </summary>
public class LeastRecentlyUsed : IProblem{
    
    private Hashtable _cache = new();
    private int _lru = -1, _total = 0, _capacity = 0;

    public void EntryPoint(){

        _capacity = 2;

        Put(1, 1);
        Put(2, 2);
        Display.Out(input: 1, expected: 1);

        Put(3, 3);
        Display.Out(input: 2, expected: -1);

        Put(4, 4);
        Display.Out(input: 1, expected: -1);

        Display.Out(input: 3, expected: 3);
        Display.Out(input: 4, expected: 4);

    }

    private int Get(int key) {
        if (_cache.ContainsKey(key))
            return (int)_cache[key]!;
        return -1;
    }

    private void Put(int key, int value) {
        if (!Get(key).Equals(-1)) return;
        if (_total >= _capacity) {
            
            _cache.Remove(_lru);
            var cursor = _cache.GetEnumerator();
            if (cursor.MoveNext())
                _lru = (int)cursor.Key;

        } else {
            
            _total++;
            _lru = key;

        }
        _cache.Add(key, value);
    }

}
