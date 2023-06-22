namespace _4;
class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[8]
        {
             new Train("Станция северная", "41212521", "13:14:00"),
             new Train("Станция южная", "5212521", "12:14:00"),
             new Train("Станция западная", "234121", "12:14:00"),
             new Train("Станция восточная", "123421", "12:14:00"),
             new Train("Станция марс", "23412521", "12:14:00"),
             new Train("Станция круг", "555210", "12:14:00"),
             new Train("Станция 1", "9932521", "12:14:00"),
             new Train("Станция 3", "675211", "12:14:00"),
        };

        Console.Write("Введите : ");
        string? number = Console.ReadLine();
        Train? find = null;
        Console.WriteLine();
        Array.Sort(trains, new OldeerSort<int>());
        foreach (var item in trains)
        {
            Console.WriteLine(item);
            if (item.NumberTrain == number)
            {
                find = item;
            }
        }

        if (find == null ) Console.WriteLine("Поезд который вы искали нет");
        else
        {
            Console.WriteLine();
            Console.WriteLine("Найден поезд!");
            Console.WriteLine(find);
        }
    }
}
