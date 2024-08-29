namespace MaxConsecutiveOnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 1, 0, 1, 1, 1, 0, 1, 1,1,1,0 };
            Console.WriteLine(FindMaxConsOnes(myArray));
        }

        static int FindMaxConsOnes(int[] a)
        {
            int count = 0, max = 0;

            for(int i = 0; i< a.Length; i++)
            {
                if (a[i] == 1)
                    count++;
                else
                    count = 0;

                if(count > max) 
                    max = count;
            }

            return max;
        }
    }
}