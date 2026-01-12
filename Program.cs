/*Thread mainthread = Thread.CurrentThread;

Console.WriteLine($"ID: {mainthread.ManagedThreadId}, State: {mainthread.ThreadState}, Name: {mainthread.Name}");

mainthread.Name = "TPthread";
Console.WriteLine($"Nouveau nom: {mainthread.Name}");
*/


using TPthreadCSharp;

static void affiche()
{
    while (true)
    {
        Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
        Thread.Sleep(1000);
    }
}
CTest test = new CTest();
/*
Thread Th1 = new Thread(affiche);
Th1.Name = "Thread 1";
Th1.Start();

Thread Th2 = new Thread(affiche);
Th2.Name = "Thread 2";
Th2.Start();



Thread Th3 = new Thread(test.afficheB);
Th3.Name = "thread 3";
Th3.Start();

Thread Th4 = new Thread(test.afficheC);
Th4.Name = "thread 4";
Th4.Start();*/

Thread th5 = new Thread(test.affiched);
Thread th6 = new Thread(test.affiched);
th5.Start(1);
th5.Join();



th6.Start(2);

th6.Join();







