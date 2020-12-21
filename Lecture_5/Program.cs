using System;

namespace Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //MinMaxElements();
            //AverageOfArray();
            // SwapArrayItems();
            //StackPush();
            //StackPop();
            //AddBinaryTreeItem();

            //Task 7 & 8
            SwapAllElements();
            SmallestElementAs1st();

        }

        private static void MinMaxElements()
        {
            // Task: Find Min and Max elements in the array
            // ============================================
            // 1. Start
            // 2. Define min, max
            // 3. Read array
            // 4. min=array[0], max=array[0]
            // 5. For each element of the array
            //      5.1. If element < min
            //          min=element
            //      5.2. If element > max
            //          max=element
            // 6. Display min, max
            // 7. End
        }

        private static void AverageOfArray()
        {
            // Task: Calculate average value of the array items
            // ================================================
            // 1. Start
            // 2. Define sum, count, avg
            // 3. Read array
            // 4. For each element of the array
            //      4.1. sum = sum + element
            //      4.2. count++
            // 5. avg = sum / count
            // 6. Display avg
            // 7. End
        }

        private static void SwapArrayItems()
        {
            // Task: Swap 2 arrays items
            // {1, 2, 3, 4 } => swap 1 and 3 => {3, 2, 1, 4}
            // =============================================
            // 1. Start
            // 2. Define temp
            // 3. Read array
            // 4. Read index1 and index2
            // 5. temp = array[index1]
            // 6. array[index1] = array[index2]
            // 7. array[index2] = temp
            // 8. End
        }

        private static void StackPush()
        {
            // Task: Add element into Stack data structure, stack is relized by array
            // ======================================================================
            // 1. Start
            // 2. Define element, isAdded
            // 3. Read new element
            // 4. isAdded = false
            // 5. For each item in array
            //      If item is empty
            //          5.1.   item = element
            //          5.2.   isAdded = true
            // 6. Return isAdded
            // 7. End
        }

        private static void StackPop()
        {
            // Task: Remove element from Stack data structure, stack is relized by array
            // {1,2,3,null,null,null} ==> 3
            // =========================================================================
            // 1. Start
            // 2. Define output
            // 3. For each item in array
            //     If item is null
            //          3.1. output = array[item index -1]
            //          3.2. array[item index -1] = null
            //          3.3. Exit foreach loop
            // 4. Return output
            // 5. End
        }
   
        private static void AddBinaryTreeItem()
        {
            // Task: Add element into Binary tree
            // ==================================
            // 1. Start
            // 2. Read newValue
            // 3. Define and Set CurrentNode = RootNode
            // 4. Move to CurrentNode
            //      3.1. If CurrentNode.Value > newValue
            //          3.1.1. If CurrentNode.LeftNode == null
            //              Add newValue as CurrentNode.LeftNode
            //          3.1.2. If CurrentNode.LeftNode != null
            //              CurrentNode = CurrentNode.LeftNode
            //              GO TO 3
            //      3.2. If CurrentNode.Value < newValue
            //          3.2.1. If CurrentNode.RightNode == null
            //              Add newValue as CurrentNode.LeftNode
            //          3.2.2. If CurrentNode.RightNode != null
            //              CurrentNode = CurrentNode.RightNode
            //              GO TO 3
            // 5. End
        }
        private static void SwapAllElements()
        {
            /* Swap all elements of 2 arrays
            1. start
            2. define 2 arrays, temp1, temp2
            3. 1) temp1 = current element of array1
               2) temp2 = current element of array2
               3) current element of array1 = temp2
               4) current element of array2 = temp1
            4. go to next element of array1 and array2 until the last element
            5. go to step 3 
            6. end            
             
             */

        }
        private static void SmallestElementAs1st()
        {
            /* Put smallest element as 1st item in the array
            1. start
            2. define array, temp
            3.0.1) for current element of array:
                   3.1.1) for current element array:
                              3.2) if current element > next element:
                                       3.3) temp = next element
                                            next element = current element
                                            current elemnt = temp
                                    else: current=current               
                   3.1.2) go to next element until the last element
                   3.1.3) go to step 3.1.1                                                
            3.0.2) go to next element until the last element
            3.0.3) go to step 3.0.1
            4. display array
            8. end   
            
             */


            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            Console.WriteLine("Initial:");
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
        }
    }
} 
    
 


