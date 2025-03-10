using System;

// Створити об’єкт класу „арифметична прогресія”. Клас характеризується першим членом a 0 , різницею d та кількістю членів n . 
// Визначити за допомогою методу класу суму прогресії.

class ArithmeticProgression
{
    // Поля класу
    private double a0; // Перший член прогресії
    private double d;  // Різниця
    private int n;     // Кількість членів

    // Конструктор
    public ArithmeticProgression(double d, int n)
    {
        Random random = new Random();
        this.a0 = Math.Round(random.NextDouble() * (5 - 0.1) + 0.1, 2); // Випадкове число від 0.1 до 5
        this.d = d;
        this.n = n;
    }

    // Властивості для доступу до полів
    public double A0
    {
        get { return a0; }
    }

    public double D
    {
        get { return d; }
        set { d = value; }
    }

    public int N
    {
        get { return n; }
        set { n = value; }
    }

    // Метод для обчислення суми прогресії
    public double CalculateSum()
    {
        return n * (2 * a0 + (n - 1) * d) / 2;
    }

    // Метод для виведення інформації
    public void DisplayInfo()
    {
        Console.WriteLine($"Перший член (випадкове число): {a0}, Різниця: {d}, Кількість членів: {n}");
        Console.WriteLine($"Сума прогресії: {CalculateSum()}");
    }
}

// Приклад використання класу
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу з випадковим першим членом
        ArithmeticProgression progression = new ArithmeticProgression(2, 5);

        // Виведення інформації
        progression.DisplayInfo();

        // Зміна значень інших параметрів
        progression.D = 3;
        progression.N = 7;

        // Повторне виведення інформації
        Console.WriteLine("\nПісля зміни значень:");
        progression.DisplayInfo();
    }
}
