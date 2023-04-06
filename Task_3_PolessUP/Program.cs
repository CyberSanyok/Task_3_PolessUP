internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] ints = new int[6];
        for (int i = 0; i < ints.Length; i++) 
        {
            ints[i] = rnd.Next(0, 10);
        }
        Array.Sort(ints);
        Console.WriteLine("Целевое значение:");
        int target = 0;
        target = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] == target) 
            { 
                Console.WriteLine("Индекс:" + i);
                break;
            }
            if (ints[i] > target) 
            {
                if (i == 0) { Console.WriteLine("Индекс:" + i);break; }
                Console.WriteLine("Индекс, если бы целевое значение стояло по порядку:" + (i));
                break;
            }
            if(i==ints.Length-1) Console.WriteLine("Индекс:" + (i+1));
        }
        
        Console.WriteLine(string.Join(", ", ints) );
        Console.Read();
    }
}