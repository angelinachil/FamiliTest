using System;
using InspectorLib;

class Program
{
    static void Main(string[] args)
    {
        FunctionInsp inspector = new FunctionInsp();

        Console.WriteLine("Название автоинспекции: " + inspector.GetCarInspection());
        Console.WriteLine("Главный инспектор: " + inspector.GetInspector());

        bool success = inspector.SetInspector("Зиронов Т.А.");
        Console.WriteLine($"Изменение главного инспектора успешно: {success}");
        Console.WriteLine("Новый главный инспектор: " + inspector.GetInspector());

        string generatedNumber = inspector.GenerateNumber("А");
        Console.WriteLine("Сгенерированный госномер: " + generatedNumber);

        Console.WriteLine("Список сотрудников:");
        foreach (var worker in inspector.GetWorkers())
        {
            Console.WriteLine(worker);
        }

        inspector.AddWorker("Петров П.П.");
        Console.WriteLine("\nСписок сотрудников после добавления:");
        foreach (var worker in inspector.GetWorkers())
        {
            Console.WriteLine(worker);
        }

        Console.ReadKey();
    }
}
