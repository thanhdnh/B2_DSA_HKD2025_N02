public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        /*Array ar = Array.CreateInstance(typeof(int), 5);
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
            Console.WriteLine(v);*/
        
        int n = 10;
        Array arr = createArray(typeof(int), n);
        randomArray(arr);
        foreach(int v in arr)
            Console.Write(v + " ");
    }//Main

    /* Yêu cầu: Cho một mảng 1 chiều int gồm có 10 phần tử 
    được sinh ngẫu nhiên. Hãy:
    1/ Viết hàm tạo ra mảng trên
    2/ Viết hàm sinh giá trị ngẫu nhiên cho mảng
    3/ Viết hàm chia mảng thành 2 mảng con bằng nhau về
    số phần tử và không làm thay đổi chỉ số của chúng.
    4/ Viết hàm kết hợp 2 mảng con ở câu 3 thành 1 mảng mới
    bằng cách cộng hai phần tử tương ứng theo thứ tự.
    Ví dụ: Mảng đầu: [0]=5,...,[4]=2, [5]=3,...,[9]=7
    Mảng con 1: [0]=5,...,[4]=2
    Mảng con 2: [5]=3,...,[9]=7
    Mảng hợp: [0]=5+3,...,[4]=2+7
    */
    static Array createArray(Type type, int len){
        return Array.CreateInstance(type, len);
    }
    static void randomArray(Array input){
        Random r = new Random();
        for(int i=input.GetLowerBound(0); 
            i<=input.GetUpperBound(0); i++)
                input.SetValue(r.Next(100), i);
    }
    static void splitArray(Array input, Array o1, Array o2){
        
    }
    static Array combineArray(Array o1, Array o2){
        return null;
    }
}