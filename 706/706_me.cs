namespace Solution;
public class MyHashMap {
    public class Pair
    {
        public int key;
        public int value;
        
        public Pair(int key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
    
    public static int Base = 769;
    public List<Pair> pairs;

    public int Hash(int key)
    {
        return key % Base;
    }
    
    public MyHashMap()
    {
        pairs = new List<Pair>();
        for (int i = 0; i < Base; i++)
        {
            pairs.Add(new Pair(-1,-1));
        }
    }
    
    public void Put(int key, int value)
    {
        int favoredIndex = Hash(key);
        var list = pairs[favoredIndex];
        for (int i = favoredIndex; i < pairs.Count; i++)
        {
            if (pairs[i].key == -1 || pairs[i].key == key)
            {
                pairs[i].key = key;
                pairs[i].value = value;
                return;
            }
        }
        pairs.Add(new Pair(key, value));
    }
    
    public int Get(int key)
    {
        int favoredIndex = Hash(key);
        for (int i = 0; i < pairs.Count; i++)
        {
            if (pairs[i].key  == key)
            {
                return pairs[i].value;
            }
        }

        return -1;
    }
    
    public void Remove(int key) {
        int favoredIndex = Hash(key);
        for (int i = favoredIndex; i < pairs.Count; i++)
        {
            if (pairs[i].key  == key)
            {
                pairs[i].key = -1;
                pairs[i].value = -1;
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */