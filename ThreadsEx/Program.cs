public class Program
{
    static List<string> strings=new List<string>();
    public static void Main(string[] args)
    {
        Thread thread=new Thread(WorkerThreadOne); 
        Thread thread2=new Thread(WorkerThreadTwo);
        thread2.Start();
        thread.Start();

        thread2.Join();
        thread.Join();
        //Thread.Sleep(6000); 
        Console.WriteLine("All thread completed work");
    }
    public static void WorkerThreadOne()
    {
       
        Console.WriteLine("worker thread one started");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(Thread.GetCurrentProcessorId());
            
            Thread.Sleep(1000);
            Console.WriteLine(Thread
                .CurrentThread.ManagedThreadId);
        }
    }
    public static void WorkerThreadTwo()
    {
        //Console.WriteLine("dghgd"+Thread.GetCurrentProcessorId());
        Console.WriteLine("worker thread two started");
        Console.WriteLine(Thread
               .CurrentThread.ManagedThreadId);
    }
}
