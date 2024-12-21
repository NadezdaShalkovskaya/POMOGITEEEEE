using System;

class ObservedObject
{
    
    public string Name { get; set; }

    public ObservedObject(string name)
    {
        Name = name;
    }

    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Объект наблюдения: {Name}");
    }
}

class MovingObservedObject : ObservedObject
{
    
    public double Speed { get; set; } // м/сек
    public double Distance { get; set; } // метров

    public MovingObservedObject(string name, double speed) : base(name)
    {
        Speed = speed;
        Distance = 0; // Начальное значение для расстояния
    }

    
    public double CalculateTime(double distance)
    {
        Distance = distance;
        return Distance / Speed; // Время в секундах
    }

    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Скорость: {Speed} м/с");
        Console.WriteLine($"Пройденное расстояние: {Distance} метров");
    }
}

class Program
{
    static void Main()
    {
        
        MovingObservedObject observedObject = new MovingObservedObject("Автомобиль", 15.0);

       
        observedObject.DisplayInfo();

        
        Console.Write("Введите расстояние, которое хочет пройти объект (в метрах): ");
        double distance = double.Parse(Console.ReadLine());

        
        double time = observedObject.CalculateTime(distance);
        Console.WriteLine($"Время, необходимое для прохождения {distance} метров: {time} секунд.");
    }
}