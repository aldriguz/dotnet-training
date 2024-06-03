using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCondition;

public class DemoRunner
{
    int resultValue = 1;

    void Work1() { resultValue = 1; }
    void Work2() { resultValue = 2; }
    void Work3() { resultValue = 3; }

    public static void Process()
    {
        DemoRunner runner = new DemoRunner();
        Thread worker1 = new Thread(runner.Work1);
        Thread worker2 = new Thread(runner.Work2);
        Thread worker3 = new Thread(runner.Work3);

        worker1.Start();
        worker2.Start();
        worker3.Start();

        Console.WriteLine(runner.resultValue);
        Console.Read();
    }
}