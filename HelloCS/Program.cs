//
Console.WriteLine("Hello ");
Console.WriteLine("World ");
Console.Write("Hello ");
Console.Write("World");
//
Console.WriteLine("Hello ");
Console.WriteLine("World!");
Console.WriteLine(24 + 56);
Console.WriteLine(6 * 3 * 2);
//
Console.WriteLine("5 + 5 = " + 10);
Console.WriteLine(5 + " + " + 5 + " = " +10);
Console.WriteLine("5 + 5 = " + 10);
//Первая задача
Console.WriteLine("Демидов");
Console.WriteLine("Александр");
Console.WriteLine("Юрьевич");
//Второя задача
Console.Write("0\n");
Console.Write("00\n");
Console.Write("000\n");
Console.Write("0000\n");
Console.Write("00000\n");
//
int a = 5;
Console.WriteLine(a);
//
int b = a * 6;
Console.WriteLine(b);
//
int c = b;
c = c + 18;
Console.WriteLine(c);
//
int d = -1 + 4 * 6;
int e = (35 + 5)% 7;
int f = 14 + (-4) * 6 / 11;
int g = 2 + 15 / 6 * 1 - 7%2;
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
//
Console.WriteLine($"Первое значение: {-1 + 4 * 6} Второе значение: {(35 + 5)% 7} Третье значение: {14 + (-4) * 6 / 11} Четвёртое значение: {2 + 15 / 6 * 1 - 7%2}");
Console.WriteLine($"Первое значение: {d} Второе значение: {e} Третье значение: {f} Четвёртое значение: {g}",d, e, f, g);
//
Console.WriteLine("Enter your name");
string? name = Console.ReadLine();
Console.WriteLine("Hello, {0}", name);
//
Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your height");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your financial situation, beggar");
decimal price = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Your name: {0} Your age: {1} Your height: {2} Your financial situation: {3}", name, age, height, price);
//
Console.WriteLine("Enter first number");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The product of three syllables is equal to {h * i * j}");
//Третья задача
Console.WriteLine("Enter cylinder radius");
double radius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter cylinder height");
double eight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"the volume of the cylinder is equal to {3.14 * radius * radius * height}");
//
Console.WriteLine("Enter distance");
double dist = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter time (min.sec)");
double time = Convert.ToDouble(Console.ReadLine());
int min = Convert.ToInt32(time);
double sec = Convert.ToInt32((time * 100)%100);
sec = sec + min * 60;
double speed = (dist / sec) * 3.6;
Console.WriteLine($"Your speed is {speed}km/h");
//
Console.WriteLine("Enter deposit amount");
double deposit = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter deposit rate");
double percent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of days of holding the deposit");
double day = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Your  deposit is {(deposit * percent * day) / 100}");

//
Console.WriteLine("Enter distance");
double dist_verst = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Converted distance is {dist_verst * 1.0668}");
//
Console.WriteLine("Enter weight");
double weight_lb = Convert.ToDouble(Console.ReadLine());
Console.Write($"Converted weight is {weight_lb *0.4059}");