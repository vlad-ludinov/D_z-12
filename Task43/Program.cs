using static System.Console;

WriteLine("Даны уравнения:");
WriteLine("y = k1 * x + b1");
WriteLine("y = k2 * x + b2");
Write("Введите k1, b1, k2, b1 через запятую:");
string [] variables = ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);


