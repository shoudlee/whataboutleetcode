using System.Collections;

namespace Solution;

public class Solution380
{
    public class RandomizedSet
    {
        public Hashtable myTable;
        public List<int> myList;
        
        
        public RandomizedSet()
        {
            myTable = new Hashtable(); 
            myList = new List<int>();
        }
    
        public bool Insert(int val) {
            if (myTable.Contains(val))
            {
                return false;
            }
            else
            {
                myTable.Add(val, myList.Count);
                myList.Add(val);
                return true;
            }
        }
    
        public bool Remove(int val) {
            if (myTable.Contains(val))
            {
                int index = (int)myTable[val];
                if (index  == myList.Count -1)
                {
                    myTable.Remove(val);
                    myList.RemoveAt(myList.Count -1);
                }
                else
                {
                    myList[index] = myList[myList.Count - 1];
                    myList.RemoveAt(myList.Count - 1);
                    myTable[myList[index]] = index;
                    myTable.Remove(val);
                }
                
                
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public int GetRandom()
        {
            Random rnd = new Random();
            return myList[rnd.Next(myList.Count)];
        }
    }

    // public static void Main()
    // {
    //     RandomizedSet randomizedSet = new RandomizedSet();
    //     randomizedSet.Insert(1);
    //     randomizedSet.Insert(2);
    //     randomizedSet.Insert(2);
    //     Console.WriteLine(randomizedSet.myList.Count);
    //     Console.WriteLine(randomizedSet.GetRandom());
    //     randomizedSet.Remove(1);
    //     randomizedSet.Insert(2);
    //     Console.WriteLine(randomizedSet.GetRandom());
    // }
}