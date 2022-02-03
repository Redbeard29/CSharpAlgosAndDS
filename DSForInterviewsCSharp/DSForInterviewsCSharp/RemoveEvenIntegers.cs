using System;

namespace DSForInterviewsCSharp
{
    class RemoveEvenIntegers
    {
        static int[] removeEven(int[] initialArr)
        {
            int y = 0;
            for(int x = 0; x < initialArr.Length; x++)
            {
                if(initialArr[x] % 2 != 0)
                {
                    initialArr[y] = initialArr[x];
                    y++;
                }
            }
            int[] newArr = new int[y];
            for(int x = 0; x < y; x++) {
                newArr[x] = initialArr[x];
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for(int x = 0; x < arr.Length; x++) {
                arr[x] = x;
            }
            int[] newArr = removeEven(arr);
            Array.ForEach(newArr, Console.Write);
        }

    }
}
