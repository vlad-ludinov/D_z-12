using static System.Console;

WriteLine("Даны уравнения:");
WriteLine("y = k1 * x + b1");
WriteLine("y = k2 * x + b2");
Write("Введите k1, b1, k2, b2 через запятую: ");
string [] variables = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"y = {variables[0]} * x + {variables[1]}");
WriteLine($"y = {variables[2]} * x + {variables[3]}");
double [] answer = countXY(variables);
WriteLine($"(x, y) = ({Math.Round(answer[0], 2)}, {Math.Round(answer[1], 2)})");

double [] countXY(string[] varib)
{
    double [] xy = new double [2];
    double k = Convert.ToDouble(varib[0])-Convert.ToDouble(varib[2]);
    double b = Convert.ToDouble(varib[3])-Convert.ToDouble(varib[1]);
    xy[0] = b/k;
    xy[1] = Convert.ToDouble(varib[0])*xy[0]+Convert.ToDouble(varib[1]);
    return xy;
}