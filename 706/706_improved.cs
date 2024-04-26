namespace Solution;
public class MyHashMap1 {
    private LinkedList<KeyValueEntry>[] map;
    private readonly int baseCount = 1024;
    public MyHashMap1() {
        map = new LinkedList<KeyValueEntry>[baseCount];
        for (int i = 0; i < baseCount; i++) {
            map[i] = new LinkedList<KeyValueEntry>();
        }
    }
    
    public void Put(int key, int value) {
        int mapIndex = Hash(key);
        var list = map[mapIndex];
        foreach(var item in list)
        {
            if(item.Key == key)
            {
                item.Value = value;
                return;
            }
        }
        list.AddLast(new KeyValueEntry(key, value));
    }
    
    public int Get(int key) {
        var mapIndex = Hash(key);
        var list = map[mapIndex];
        foreach(var item in list)
        {
            if(item.Key == key)
            {
                return item.Value;
            }
        }
        return -1;
    }
    
    public void Remove(int key) {
        var mapIndex = Hash(key);
        var list = map[mapIndex];
        foreach(var item in list)
        {
            if(item.Key == key)
            {
                list.Remove(item);
                break;
            }
        }
    }

    private int Hash(int key)
    {
        return key % baseCount;
    }
}

public class KeyValueEntry
{
    public int Key{get;set;}
    public int Value{get;set;}
    public KeyValueEntry(int key, int value)
    {
        Key = key;
        Value = value;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */