public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Array ar = Array.CreateInstance(typeof(int), 5);
        ar.SetValue(10, 0);//Setter - thiết lập ar[0]=10
        int x = (int)ar.GetValue(0);//Getter - lấy giá trị của ar[0]

        Array ar2 = Array.CreateInstance(typeof(int), 3, 4);
        ar2.SetValue(10, 0, 0);//ar2[0, 0] = 10
        int y = (int)ar2.GetValue(0, 0);//y = ar2[0, 0]
        
        Array ar3 = Array.CreateInstance(typeof(int), 2, 3, 4);
        
        Array ar4 = Array.CreateInstance(typeof(int),
            new int[] { 2, 3}, new int[] { 1, 1});
        ar4.SetValue(10, 1, 1);//ar4[1, 1] = 10

        Array ar5 = Array.CreateInstance(typeof(int),
            new int[] {5}, new int[] {1});
        for(int i=ar5.GetLowerBound(0); 
            i<ar5.GetLength(0)+ar5.GetLowerBound(0); i++)
            ar5.SetValue(i*i, i);//ar5[i] = i*i
        for(int i=ar5.GetLowerBound(0); 
            i<=ar5.GetUpperBound(0); i++)
            ar5.SetValue(i*i, i);//ar5[i] = i*i
        foreach(int v in ar5)
            Console.WriteLine(v);
    }
}