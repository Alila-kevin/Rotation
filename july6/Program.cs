internal class Program
{
    public static void rotate(int[] arr, int d, int N)
    {
        int p = 1; //the starting part of the array to be moved
        // bellow while loop detamine how many times should rotation take 
        while(p <= d){

            int last = arr[0]; // the value which should rotate @
            //below loop detemine how many times should another array be added
            for(int i=0; i < N-1; i++)
            {

                arr[i] = arr[i + 1];//this add the size of array on which the swap number will be contained

            }
            arr[N - 1] = last;// after new legth has been provided we need another for given loop
            p++; // loop to meet the condition

            

        }
        // Below is to give the output of the function
        
        for (int j = 0; j < N; j++)
        {

            Console.WriteLine(arr[j].ToString() + "\t");
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Result in arrays");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 }; 
         var N = arr.Length;
        int d = 2;
         Program.rotate(arr, d, N);
        //end of array

        //starting link list
        Console.WriteLine("Result in linklist");
        List<int> inp
             = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //int d= 2;
        // Changing from list to deque structure
        Queue<int> deq = new Queue<int>(inp);

        // Rotating left using rotate function
        // To rotate left use (-), Ex: rotate(-3)
        // To rotate right by 3 elements Ex: rotate(3)
        for (int i = 0; i < d; i++)
        {
            int temp = deq.Dequeue();
            deq.Enqueue(temp);
        }

        Console.WriteLine(string.Join( " ", deq));

        Console.ReadKey();
    }
}