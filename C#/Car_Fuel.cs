using System.Diagnostics;

class Car
{
    private bool stopped;
    public bool Stopped
    {
        get
        {
            return stopped;
        }
    }

    private int fuel;
    public int Fuel
    {
        get
        {
            return fuel;
        }

        set
        {
            fuel = value;
        }
    }

    public delegate void FuelLowDelegate(Car car);
    public event FuelLowDelegate FuelLow;

    public void Start()
    {
        const int MIN_FUEL = 5;
        stopped = false;

        while (fuel != 0 || !stopped)
        {
            if (fuel > MIN_FUEL)
            {
                Move();
            }
            else if (fuel < MIN_FUEL)
            {
                Debug.WriteLine("LOW FUEL"); //FuelLow();
                Move();
            }
            else
            {
                Debug.WriteLine("NO FUEL"); //FuelEmpty();
                break;
            }
        }

        Stop();
    }

    private void Move()
    {
        Debug.WriteLine("MOVING");   //throw new NotImplementedException();
        fuel--;
    }

    private void Stop()
    {
        Debug.WriteLine("STOPPED");
        stopped = true;
    }
}

class Program
{
    static void onFuelLow(Car car)
    {
        System.Console.WriteLine("LOW FUEL: {0}", car.Fuel);
    }

    static void Main(string[] args)
    {
        Car c = new Car();
        c.FuelLow += new Car.FuelLowDelegate(onFuelLow);
        c.Fuel = 10;
        c.Start();
        System.Console.ReadKey();
    }
}