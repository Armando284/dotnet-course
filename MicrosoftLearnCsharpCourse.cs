var name = "Armando";

Console.WriteLine("Hello, " + name + "!");
//Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"Hello, {name.ToUpper()}!");

var names = new List<string>() { name, "Fifi", "Rachel", "Pedro" };

foreach (var n in names)
{
    Console.WriteLine(n);
}

//Console.Write("Congratulations");
//Console.Write(" ");
//Console.Write("You wrote your first lines of code.");

Console.WriteLine("Congratulations");
Console.Write("You wrote your first lines of code.");

Console.WriteLine('b');
Console.WriteLine(123);

/**
 * Float type --> precision
 * 
 * float --> ~6-9 digits ex: 0.1f
 * double --> ~15-17 digits ex: 0.1 <-- compiler default
 * decimal --> ~28-29 digits ex: 0.1m
 */

Console.WriteLine(0.1f + 0.2f); // 0.3 No hay error de punto flotante!?

decimal a = 0.1m;
decimal b = 0.2m;

Console.WriteLine(a + b); // 0.3

Console.WriteLine(true); // True
Console.WriteLine(false); // False

string firstName;
//Console.WriteLine(firstName); // (2,19): error CS0165: Use of unassigned local variable 'firstName'

var message = "Hello World!"; // var no es igual a en JS solo le dice al compilador que asuma el tipo de dato con la asignación
//message = 10.703m;//(2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'

Console.WriteLine(34.40M);

Console.WriteLine(@"  texto con formato
                            esto sirve para json y dto.");

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // parece que tengo que tener los caracteres instalados para verlos

// combinacion de interpolacion de cadenas y cadenas literales, mejor que JS
// projectName = "First-Project";
// Console.WriteLine($@"C:\output\{projectName}\app");

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\Excercise\{projectName}\data.txt
");
Console.WriteLine($@"{russianMessage}:
    c:\Excercise\{projectName}\ru-RU\data.txt");

/**
 * View English output:
 *      c:\Excercise\ACME\data.txt
 *
 * Посмотреть русский вывод:
 *      c:\Excercise\ACME\ru-RU\data.txt
 */

int divA = 5;
int divB = 7;

decimal division  = (decimal)divA / (decimal)divB;
Console.WriteLine(division);
Console.WriteLine("resto: " + divA % divB);

Console.WriteLine("W " + 1 + 1);
Console.WriteLine( 5/10 );

// Crear nuevo proyecto de consola desde cli
// dotnet new console -o ./CsharpProjects/TestProject
// dotnet build construye el proyecto
// dotnet run lo ejecuta