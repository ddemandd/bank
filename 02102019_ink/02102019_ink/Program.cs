using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace _02102019_ink
{
    class Program
    {
        static void Main(string[] args)
        {
            //stopwatch stopwatch = new stopwatch();
            //stopwatch.start();
            //int a = 0;
            //int b = 0;
            //for (int i=0; i < 100000000; i++)
            //{ a++; }
              
            //stopwatch.stop();
            //timespan ts = stopwatch.elapsed;

            //string elapsedtime = string.format("{0:00}.{1:00}.{2:00}.{3:00}", ts.hours, ts.minutes, ts.seconds, ts.milliseconds / 10);
            //console.writeline("run time " + elapsedtime);
            //console.readline();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int a = 0;
            int b = 0;
            for (int i = 0; i < 2000000000; i++)
            { b=a++;}

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}.{1:00}.{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Run time " + elapsedTime);
            Console.ReadLine();
        }

        
    }
    
}
