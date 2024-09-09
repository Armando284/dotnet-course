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