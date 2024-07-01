using System.Xml.Linq;
//Students_Names, Test Grades & Averange

string[] Students_name = { "Andres", "Marcela", "Daniela", "Juan" };
int[] Andres_grades = { 55, 85, 63, 40, 83 };
int[] Marcela_grades = { 90, 87, 98, 89, 95 };
int[] Daniela_grades = { 95, 65, 90, 80, 93 };
int[] Juan_grades = { 70, 45, 63, 60, 53 };
 

double AVGA = Queryable.Average(Andres_grades.AsQueryable());
double AVGM = Queryable.Average(Marcela_grades.AsQueryable());
double AVGD = Queryable.Average(Daniela_grades.AsQueryable());
double AVGJ = Queryable.Average(Juan_grades.AsQueryable());

double[] AVGStudents = {AVGA, AVGM, AVGD, AVGJ};
double AVGALL = Queryable.Average(AVGStudents.AsQueryable());

Console.WriteLine("Score Calculator");
Console.WriteLine("----------------------");

Console.WriteLine("Welcome to Your Grades");

Console.WriteLine("NAME    | Q1 | Q2 | Q3 | Q4 | Q5 | AVG  | GRADE |");

// Alphabetic Grades

double Letter = AVGStudents[0];

if (Letter < 60)
{
    Console.WriteLine($"Andres  | {Andres_grades[0]} | {Andres_grades[1]} | {Andres_grades[2]} | {Andres_grades[3]} | {Andres_grades[4]} | {AVGA} |   F |");
}
else if (Letter >= 60 && Letter < 70)
{
    Console.WriteLine($"Andres  | {Andres_grades[0]} | {Andres_grades[1]} | {Andres_grades[2]} | {Andres_grades[3]} | {Andres_grades[4]} | {AVGA} |   D   |");
}
else if (Letter >= 70 && Letter < 80)
{
    Console.WriteLine($"Andres  | {Andres_grades[0]} | {Andres_grades[1]} | {Andres_grades[2]} | {Andres_grades[3]} | {Andres_grades[4]} | {AVGA} |   C   |");
}
else if (Letter >= 80 && Letter < 90)
{
    Console.WriteLine($"Andres  | {Andres_grades[0]} | {Andres_grades[1]} | {Andres_grades[2]} | {Andres_grades[3]} | {Andres_grades[4]} | {AVGA} |   B   |");
}
else if (Letter >= 90 && Letter < 100)
{
    Console.WriteLine($"Andres  | {Andres_grades[0]} | {Andres_grades[1]} | {Andres_grades[2]} | {Andres_grades[3]} | {Andres_grades[4]} | {AVGA} |   A   |");
}
else
{
    // Acción por defecto en caso de que Letter no se encuentre en ninguno de los rangos anteriores.
}

double Letter1 = AVGStudents[1];

if (Letter1 < 60)
{
    Console.WriteLine($"Marcela | {Marcela_grades[0]} | {Marcela_grades[1]} | {Marcela_grades[2]} | {Marcela_grades[3]} | {Marcela_grades[4]} | {AVGM} |   F   |");
}
else if (Letter1 >= 60 && Letter1 < 70)
{
    Console.WriteLine($"Marcela | {Marcela_grades[0]} | {Marcela_grades[1]} | {Marcela_grades[2]} | {Marcela_grades[3]} | {Marcela_grades[4]} | {AVGM} |   D   |");
}
else if (Letter1 >= 70 && Letter1 < 80)
{
    Console.WriteLine($"Marcela | {Marcela_grades[0]} | {Marcela_grades[1]} | {Marcela_grades[2]} | {Marcela_grades[3]} | {Marcela_grades[4]} | {AVGM} |   C   |");
}
else if (Letter1 >= 80 && Letter1 < 90)
{
    Console.WriteLine($"Marcela | {Marcela_grades[0]} | {Marcela_grades[1]} | {Marcela_grades[2]} | {Marcela_grades[3]} | {Marcela_grades[4]} | {AVGM} |   B   |");
}
else if (Letter1 >= 90 && Letter1 < 100)
{
    Console.WriteLine($"Marcela | {Marcela_grades[0]} | {Marcela_grades[1]} | {Marcela_grades[2]} | {Marcela_grades[3]} | {Marcela_grades[4]} | {AVGM} |   A   |");
}
else
{
    // Acción por defecto en caso de que Letter1 no se encuentre en ninguno de los rangos anteriores.
}

double Letter2 = AVGStudents[2];

if (Letter2 < 60)
{
    Console.WriteLine($"Daniela | {Daniela_grades[0]} | {Daniela_grades[1]} | {Daniela_grades[2]} | {Daniela_grades[3]} | {Daniela_grades[4]} | {AVGD} |   F   |");
}
else if (Letter2 >= 60 && Letter2 < 70)
{
    Console.WriteLine($"Daniela | {Daniela_grades[0]} | {Daniela_grades[1]} | {Daniela_grades[2]} | {Daniela_grades[3]} | {Daniela_grades[4]} | {AVGD} |   D   |");
}
else if (Letter2 >= 70 && Letter2 < 80)
{
    Console.WriteLine($"Daniela | {Daniela_grades[0]} | {Daniela_grades[1]} | {Daniela_grades[2]} | {Daniela_grades[3]} | {Daniela_grades[4]} | {AVGD} |   C   |");
}
else if (Letter2 >= 80 && Letter2 < 90)
{
    Console.WriteLine($"Daniela | {Daniela_grades[0]} | {Daniela_grades[1]} | {Daniela_grades[2]} | {Daniela_grades[3]} | {Daniela_grades[4]} | {AVGD} |   B   |");
}
else if (Letter2 >= 90 && Letter2 < 100)
{
    Console.WriteLine($"Daniela | {Daniela_grades[0]} | {Daniela_grades[1]} | {Daniela_grades[2]} | {Daniela_grades[3]} | {Daniela_grades[4]} | {AVGD} |   A   |");
}
else
{
    // Acción por defecto en caso de que Letter2 no se encuentre en ninguno de los rangos anteriores.
}

char Letter3 = 'A';

if (AVGStudents[3] < 60)
{
    Letter3 = 'F';
}
else if (Letter3 >= 60 && Letter3 < 70)
{
    Letter3 = 'D';
}
else if (Letter3 >= 70 && Letter3 < 80)
{
    Letter3 = 'C';
}
else if (Letter3 >= 80 && Letter3 < 90)
{
    Letter3 = 'B';
}
else 
{
    Letter3 = 'A';
}

Console.WriteLine($"Juan    | {Juan_grades[0]} | {Juan_grades[1]} | {Juan_grades[2]} | {Juan_grades[3]} | {Juan_grades[4]} | {AVGJ} |   {Letter3}   |");

// Total AVG 

Console.WriteLine("-----------------------------------");
Console.WriteLine($"Total AVG On This Class: {AVGALL} ");