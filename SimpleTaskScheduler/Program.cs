namespace SimpleTaskScheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job1 job1 = new Job1();
            Job2 job2 = new Job2();
            Job3 job3 = new Job3();

            // config to run job1 every 5000 miliseconds (5 seconds)
            Thread task1 = new Thread(()=> job1.DoJob(7000));
            // config to run job2 every 10000 miliseconds (10 seconds)
            Thread task2 = new Thread(() => job2.DoJob(10000));
            // config to run job3 every 15000 miliseconds (15 seconds)
            Thread task3 = new Thread(() => job3.DoJob(17000));


            task1.Start();
            task2.Start();
            task3.Start();
        }
    }
}
