// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine("Enter the value of Base");
//int bases = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the value of Height");
//int height = Convert.ToInt32(Console.ReadLine());

//int area;
//area = bases *  height / 2;

//Console.WriteLine(area);

//Console.WriteLine("AREA OF Perimeter Parallelogram");

//Console.WriteLine("Enter first Value");
//double a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second Value");
//double b = Convert.ToInt32(Console.ReadLine());

//int a_val = Convert.ToInt32(a);
//int b_val = Convert.ToInt32(b);

//int Parallelogram = 2 * (a_val + b_val);

//Console.WriteLine(Parallelogram);

//Console.WriteLine("Area of Circle");

//double pie = 3.142;

//Console.WriteLine("Enter the value of Radius");
//double rad = Convert.ToInt32(Console.ReadLine());

//int radius = Convert.ToInt32(rad);

//double circle = 2 * pie * rad;
//Console.WriteLine("Area of Circle" + circle);

//Console.WriteLine("FORM");

//Console.WriteLine("Enter your First Name");
//String  f_name = Console.ReadLine();

//Console.WriteLine("Enter your Last Name");
//string l_name = Console.ReadLine();

//Console.WriteLine("Enter your Email");
//string email = Console.ReadLine();

//Console.WriteLine("Enter your Gender (like M / F)");
//char gender =Convert.ToChar(Console.ReadLine());

//Console.WriteLine("Enter your Phone Number");
//double number = Convert.ToInt32(Console.ReadLine());
//int num = Convert.ToInt32(number);

//Console.WriteLine("Your First Name is " + f_name);
//Console.WriteLine("Your Last Name is " + l_name);
//Console.WriteLine("Your Email is " + email);
//Console.WriteLine("Your Gender is " + gender);
//Console.WriteLine("Your Number is " +  num);

Console.WriteLine("Enter Pakistani Rupee");
int pkr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What currency to convert to?");
string currency = Console.ReadLine();

int dollar = 278;

int euro = 301;

int ind = 3;

int riyal = 74;

if (currency == "dollar")
{
    int d_to_pak = pkr * dollar;
    Console.WriteLine("Pakistani Rupee convert to Dollar (" + d_to_pak +")");
}
else if (currency == "euro")
{
    int e_to_pak = pkr * euro;
    Console.WriteLine("Pakistani Rupee convert to Euro (" + e_to_pak + ")");
}
else if (currency == "indian")
{
    int i_to_pak = pkr * ind;
    Console.WriteLine("Pakistani Rupee convert to Indian Rupee (" + i_to_pak + ")");
}
else if (currency == "riyal")
        {
    int r_to_pak = pkr * riyal;
    Console.WriteLine("Pakistani Rupee convert to Riyal (" + r_to_pak + ")");
}
else
{
    Console.WriteLine("please select the country name");
};