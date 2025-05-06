//26
int x;
x = 5;
//27
string name = "שלום";
Console.WriteLine(name);
//28
int y = 10 + 100;
//Console.WriteLine(y);
//29
double test1 = 80;
double test2 = 90;
double ave = (test1 + test2) / 2;
Console.WriteLine(ave);
//30
Console.WriteLine("אנא הקלט ברכה ליום הולדת");
string input = Console.ReadLine();
int length = input.Length;
Console.WriteLine(length);
//31
string name2 = Console.ReadLine();
string aeg = Console.ReadLine();
int age = Convert.ToInt32(aeg);
Console.Write($"{name2} בעוד 5 שנים תהיה בן {age + 5}");
//32
string st = Console.ReadLine();
string number = Console.ReadLine();
int numbe = Convert.ToInt32(number);
string a = string.Concat(Enumerable.Repeat(st, numbe));
Console.WriteLine(a);
//33
string inputa = Console.ReadLine();
string inputb = Console.ReadLine();
string inputc = Console.ReadLine();
int aa = Convert.ToInt32(inputa);
int bb = Convert.ToInt32(inputb);
int cc = Convert.ToInt32(inputc);
Console.WriteLine((aa + bb + cc) / 3);
//34
string strin = Console.ReadLine();
Console.WriteLine(strin.ToUpper());
35
string input2 = Console.ReadLine();
int num3 = Convert.ToInt32(input2);
if (num3 > 18)
    Console.WriteLine("yas");
else Console.WriteLine("no");
{

}
36
int numbes = Convert.ToInt32("1234");
Console.WriteLine(numbes);

//37
string input10 = Console.ReadLine();
string input11 = Console.ReadLine();

if (input10 == input11)
{
    Console.WriteLine('T');
}
else
    Console.WriteLine('f');
38
string input12 = Console.ReadLine();
int num13 = Convert.ToInt32(input12);
if (num13 % 2 == 0)
{
    Console.WriteLine('T');
}
else
    Console.WriteLine('F');
39
string input15 = Console.ReadLine();
if (input15.StartsWith('A'))
{
    Console.WriteLine("המחרוזת מתחיל עם A");
}
else
    Console.WriteLine("המספר לא מתחיל עם A");
40
string input20 = Console.ReadLine();
int num20 = Convert.ToInt32(input20);
Console.WriteLine(num20 * num20);
41
string input21 = Console.ReadLine();
double num21 = Convert.ToInt32(input21);
Console.WriteLine(num21);
Console.WriteLine(num21 * 39.3701);
42
string input24 = Console.ReadLine();
int num24;
if (int.TryParse(input24, out num24))
{
    Console.WriteLine("המחרוזת אפשרית לההמרה");
}
else
{
    Console.WriteLine("המחרוזת אינה אפשרית לההמרה");
}
//45
string input30 = Console.ReadLine();
int num30 = Convert.ToInt32(input30);

