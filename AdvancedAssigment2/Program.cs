using System.Collections;
using System.Runtime.CompilerServices;

namespace AdvancedAssigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X. (1)
            //int[] arr = { 11, 5, 3 };
            //int NumOfQueries;
            //Console.WriteLine("enter number of queries");
            //int.TryParse(Console.ReadLine(),out NumOfQueries);
            //for (int i = 0; i < NumOfQueries; i++)
            //{
            //    int counter =0;
            //    Console.WriteLine($"enter number");
            //   int.TryParse(Console.ReadLine(),out int num);
            //    foreach(var n in arr)
            //    {
            //        if (n > num)
            //        {
            //            counter++;
            //        }

            //    }
            //    Console.WriteLine($"query {i + 1} : {counter} elements is greater");

            //}

            #endregion

            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.  (1)
            //int[] arr = {1,2,3,2,1 };
            //int l = 0;
            //int r = arr.Length-1;
            //while (l < r)
            //{
            //    if (arr[l] != arr[r])
            //    {
            //        Console.WriteLine("not plaindrome");
            //        break;
            //    }
            //    l++;
            //    r--;

            //}
            //if (l >= r)
            //{
            //    Console.WriteLine("plaindrome");
            //}
            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack. (1)
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Stack<int> stack = new Stack<int>();
            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}
            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}
            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack. (1)

            // Console.WriteLine(isbalanced("(]"));
            #endregion

            #region q5

            //int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            //Console.WriteLine("Original Array: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            //int[] result = RemoveDuplicates(arr);
            //Console.WriteLine("\nArray after removing duplicates: ");

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}



            #endregion

            #region q6

            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine("Original ArrayList: ");

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //RemoveOdd(list);


            //Console.WriteLine("\nArrayList after removing odd numbers: ");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}


            #endregion

            #region q7

            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Elements in the queue: ");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item + "   Type:   " + item.GetType());
            //}


            #endregion

            #region q8

            //SearchStack();

            #endregion

            #region q9

            //int[] arr1 = { 1, 2, 4, 5, 4 };
            //int[] arr2 = { 2, 3, 5, 7, 4 };

            //List<int> intersection = Intersection(arr1, arr2);
            //Console.WriteLine("Intersection of two arrays: ");
            //foreach (var item in intersection)
            //{
            //    Console.Write(item + " ");
            //}



            #endregion

            #region q10

            //ArrayList arr = new ArrayList() { 1, 2, 3, 7, 5, 4, 6 };
            //int target = 12;

            //ArrayList subArray = FindSubArray(arr, target);

            //if (subArray != null)
            //{
            //    Console.WriteLine("Continous sub list:  ");
            //    foreach (var item in subArray)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No sub array was found.");
            //}

            #endregion

            #region q11

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //int k = 3;

            //ReverseFirstKElement(queue, k);




            #endregion

        }
        private static bool isbalanced(string st)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in st)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else
                {
                    if(stack.Count == 0)
                        return false;
                    var openchar = stack.Peek();

                    if ((openchar == '(' && c == ')') || (openchar == '[' && c == ']') || (openchar == '{' && c == '}'))
                    {
                        stack.Pop();
                    }
                    else
                        return false;

                }
            }

            return stack.Count == 0;
        }

        public static int[] RemoveDuplicates(int[] arr)
        {

            List<int> list = new List<int>();

            foreach (var number in arr)
            {
                if (!list.Contains(number))
                {
                    list.Add(number);
                }
            }

            return list.ToArray();

        }

        public static void RemoveOdd(ArrayList list)
        {

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ((int)list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }

        }

        public static void SearchStack()
        {

            Stack<int> stack = new Stack<int>();

            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };


            foreach (int num in numbers)
            {

                stack.Push(num);

            }

            Console.WriteLine("Enter the target you want to search for : ");

            int.TryParse(Console.ReadLine(), out int target);

            int count = 0;
            bool found = false;

            while (stack.Count > 0)
            {

                count++;
                int top = stack.Pop();


                if (top == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    found = true;
                    break;
                }

            }

            if (!found)
            {
                Console.WriteLine("Target was not found");
            }

        }

        public static List<int> Intersection(int[] arr1, int[] arr2)
        {

            Array.Sort(arr1);
            Array.Sort(arr2);

            List<int> list = new List<int>();

            int i = 0;
            int j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {

                if (arr1[i] == arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }


            }

            return list;
        }

        public static ArrayList FindSubArray(ArrayList arr, int target)
        {

            int start = 0;
            int sum = 0;

            for (int end = 0; end < arr.Count; end++)
            {
                sum += (int)arr[end];
                while (sum > target && start <= end)
                {
                    sum -= (int)arr[start];
                    start++;
                }
                if (sum == target)
                {
                    ArrayList subArray = new ArrayList();
                    for (int i = start; i <= end; i++)
                    {
                        subArray.Add(arr[i]);
                    }
                    return subArray;
                }
            }

            return null;
        }


        public static void ReverseFirstKElement(Queue<int> queue, int k)
        {


            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
            {

                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {

                queue.Enqueue(stack.Pop());
            }

            int remain = queue.Count - k;
            for (int i = 0; i < remain; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine("Queue after reversing first k elements: ");

            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }


        }


    }
}