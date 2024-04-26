using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
//[3,2,1,0,4]
namespace Solution{ 
    
    public class Solution055
    {
        public static bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            bool[] potentialList = new bool[nums.Length];
            for (int i = 0; i < potentialList.Length; i++)
            {
                potentialList[i] = true;
            }
            
            
            int endNodeIndex = nums.Length - 1;
            Stack<StackNode> myStack = new Stack<StackNode>();
            myStack.Push(new StackNode(0, nums[0]));
            StackNode currentNode;

            for (; myStack.Count != 0;)
            {
                currentNode = myStack.Peek();
                if (currentNode.value == 0)
                {
                    myStack.Pop();
                    continue;
                }
                
                for (int i = currentNode.value; i > 0 ; i--)
                {
                    if (currentNode.index + i > endNodeIndex)
                    {
                        continue;
                    }

                    if (currentNode.index + i == endNodeIndex)
                    {
                        return true;
                    }

                    if (currentNode.index + i < endNodeIndex)
                    {
                        if (potentialList[currentNode.index + i])
                        {
                            myStack.Push(new StackNode(currentNode.index + i,
                                nums[currentNode.index + i]));
                            potentialList[currentNode.index + i] = false;
                            i--;
                            currentNode.value = i;
                            break; 
                        }

                        currentNode.value--;
                        
                        
                    }
                    
                    
                }
            }
            return false;
        }

        public class StackNode
        {
            public int index;
            public int value;
            public bool potentialToReachEnd;

            public StackNode(int index, int value)
            {
                this.index = index;
                this.value = value;
            }
        }


        // public static void Main()
        // {
        //     int[] _list = [3, 2, 1, 0, 4];
        //
        //     bool _b = CanJump(_list);
        //     
        //     Console.Write(_b);
        // }
        
        
        
    }



}