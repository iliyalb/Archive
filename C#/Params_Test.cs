using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ParamsExpert
{
    public class Program
    {
        public static void Main()
        {
            //Initialization
            Parameter myparams = new Parameter();
            char a = '\"', b = ',';
            string c = a.ToString(), d = b.ToString(), e = c + d + c + d;
            StringBuilder sb = new StringBuilder();
            sb.Insert(0, e);
            //Get the current CPU load in percentage
            PerformanceCounter CPUPerformance = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            CPUPerformance.NextValue();

            //Unnecessary itterations
            try
            {
                do
                {
                    //Update performance values
                    float currentCPUPerformance = CPUPerformance.NextValue();

                    //Do the experiment
                    sb.Append(e);
                    Thread.Sleep(10);
                    myparams.Pars(sb.ToString());
                } while (currentCPUPerformance != 100);
            }
            //In case of unhandled exceptions
            catch (Exception ex)
            {
                throw ex;
            }
            //Free up system resources
            finally
            {
                myparams.Dispose();
            }
        }
    }

    class Parameter
    {
        //Finite parameter intake
        public void Pars(params string[] x)
        {
            foreach (string s in x)
                Console.Write(s);
        }

        //Manual Garbage Collection
        public void Dispose()
        {
            this.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}