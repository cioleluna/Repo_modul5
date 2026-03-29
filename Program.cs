class DataGeneric<T> 
{
    public T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> nim = new DataGeneric<string>("103022400026");
        nim.PrintData();
    }
}
