Console.WriteLine("Class 2: Variables"); //Statement
Console.WriteLine("----------------");

// Tipos dde variables

int Age = 25;

double Salary = 17.50;

float  Amount = 20.50F;

String name = "Andres";

Char letter = 'A'; 

bool isMale = false;

Console.WriteLine(name);
Console.WriteLine("Name: " + name);
Console.WriteLine($"Name: {name} Salary: {Salary}");

int a = 10;
int b = 30;
int c = 0;
bool x = false;
c = a + b;
x = a == b;
x = a != b;

Console.WriteLine(c);


if (x == false)
{
    Console.WriteLine("Es mayor");
}
else if(5 == 5)
{
    Console.WriteLine("Es menor");
}
else
{
    // code
}

switch (c)
{
    case 0:

    case 1:

    case 3:
        Console.WriteLine("is juan");
        break;
    case 2:
        Console.WriteLine("is andres");
        break;
}


// Array 

//string[] cars;

string[] cars = { "toyota", "ferrari", "audi", "bmw" };

Console.WriteLine();