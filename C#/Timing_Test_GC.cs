using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Timing_Test
{
    class Timing
    {
        TimeSpan startingTime;
        TimeSpan duration;

        public Timing()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void startTime()
        {
            GC.Collect;
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public void stopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
        }

        public TimeSpan Result()
        {
            return duration;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100000];
            arrayBuilder(nums);
            Timing timeObj = new Timing();
            timeObj.startTime();
            outputArray(nums);
            timeObj.stopTime();
            Console.WriteLine("\n Time (.NET) : " + timeObj.Result().TotalSeconds);
            Console.Read();
        }

        static void arrayBuilder(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
        }

        static void outputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
        }
    }
}