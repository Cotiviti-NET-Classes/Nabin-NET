//Write a funtion which takes array of numbers as parameter and returns both average and sum of those numbers.


namespace Assignment1;

class Assignment1
{
    int sum=0, avg;
    void show()
    {
        int [] array={2,3,4,5,6,7};
        for(int i=0; i<array.Length; i++)
        {
            sum=sum+array[i];
            return sum;
        }
        avg = sum/array.Length;
        return avg;
         //Console.WriteLine("The sum is:", sum);
         //Console.WriteLine("The avg is:", avg);

    }
//OR
    void display(int[] arr)
    {
        int sum=0, avg;
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine("The sum of array is:",sum+arr[i]);
            Console.WriteLine("The avg of array is:",sum/arr.Length);
        }
    }

}