//var name = "Armando";

//Console.WriteLine("Hello, " + name + "!");
////Console.WriteLine($"Hello, {name}!");
//Console.WriteLine($"Hello, {name.ToUpper()}!");

//var names = new List<string>() { name, "Fifi", "Rachel", "Pedro" };

//foreach (var n in names)
//{
//    Console.WriteLine(n);
//}

////Console.Write("Congratulations");
////Console.Write(" ");
////Console.Write("You wrote your first lines of code.");

//Console.WriteLine("Congratulations");
//Console.Write("You wrote your first lines of code.");

//Console.WriteLine('b');
//Console.WriteLine(123);

///**
// * Float type --> precision
// * 
// * float --> ~6-9 digits ex: 0.1f
// * double --> ~15-17 digits ex: 0.1 <-- compiler default
// * decimal --> ~28-29 digits ex: 0.1m
// */

//Console.WriteLine(0.1f + 0.2f); // 0.3 No hay error de punto flotante!?

//decimal a = 0.1m;
//decimal b = 0.2m;

//Console.WriteLine(a + b); // 0.3

//Console.WriteLine(true); // True
//Console.WriteLine(false); // False

//string firstName;
////Console.WriteLine(firstName); // (2,19): error CS0165: Use of unassigned local variable 'firstName'

//var message = "Hello World!"; // var no es igual a en JS solo le dice al compilador que asuma el tipo de dato con la asignación
////message = 10.703m;//(2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'

//Console.WriteLine(34.40M);

//Console.WriteLine(@"  texto con formato
//                            esto sirve para json y dto.");

//// Kon'nichiwa World
//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // parece que tengo que tener los caracteres instalados para verlos

//// combinacion de interpolacion de cadenas y cadenas literales, mejor que JS
//// projectName = "First-Project";
//// Console.WriteLine($@"C:\output\{projectName}\app");

//string projectName = "ACME";

//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

//Console.WriteLine($@"View English output:
//    c:\Excercise\{projectName}\data.txt
//");
//Console.WriteLine($@"{russianMessage}:
//    c:\Excercise\{projectName}\ru-RU\data.txt");

///**
// * View English output:
// *      c:\Excercise\ACME\data.txt
// *
// * Посмотреть русский вывод:
// *      c:\Excercise\ACME\ru-RU\data.txt
// */

//int divA = 5;
//int divB = 7;

//decimal division  = (decimal)divA / (decimal)divB;
//Console.WriteLine(division);
//Console.WriteLine("resto: " + divA % divB);

//Console.WriteLine("W " + 1 + 1);
//Console.WriteLine( 5/10 );

//// Crear nuevo proyecto de consola desde cli
//// dotnet new console -o ./CsharpProjects/TestProject
//// dotnet build construye el proyecto
//// dotnet run lo ejecuta

///**
// * Para dar sensación de aleatoriedad, los desarrolladores del método Next() 
// * decidieron capturar la fecha y el tiempo hasta la fracción de un milisegundo y 
// * usarlo para inicializar un algoritmo que genera un número diferente cada vez. 
// * Aunque no es totalmente aleatorio, es suficiente para la mayoría de las aplicaciones.
// */
//var dice = new Random();
//int rol = dice.Next(1, 7);
//Console.WriteLine(rol);

//// Overloading methods
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine($"First roll: {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");

// Desafio Math max
//int firstValue = 500;
//int secondValue = 600;
//int largerValue = Math.Max(firstValue, secondValue);

//Console.WriteLine(largerValue);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//string message = "The quick brown fox jumps over the lazy dog.";
//bool result = message.Contains("dog");
//Console.WriteLine(result);

//if (message.Contains("fox"))
//{
//    Console.WriteLine("What does the fox say?");
//}

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    Console.WriteLine("You rolled doubles! +2 bonus to total!");
//    total += 2;
//}

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}

//if (total >= 15)
//{
//    Console.WriteLine("You win!");
//}
//else
//{
//    Console.WriteLine("Sorry, you lose.");
//}


// arrays o matrices en microsoft learn

//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
//// fraudulentOrderIDs[3] = "D000"; // !: Error out of boundries 

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//fraudulentOrderIDs[0] = "F000";

//Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//string[] fraudulentOrderIDs2 = ["A123", "B456", "C789"];
//string[] fraudulentOrderIDs3 = { "A123", "B456", "C789" }; // forma antigua, todavia es valida

//string[] names = { "Rowena", "Robin", "Bao" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

////int[] inventory = { 200, 450, 700, 175, 250 };
////int sum = 0;
////foreach (int items in inventory)
////{
////    sum += items;
////}

////Console.WriteLine($"We have {sum} items in inventory."); // could use a reducer

//int[] inventory = { 200, 450, 700, 175, 250 };
//int sum = 0;
//int bin = 0;
//foreach (int items in inventory)
//{
//    sum += items;
//    bin++;
//    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
//}
//Console.WriteLine($"We have {sum} items in inventory.");

//string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//foreach (string orderID in orderIDs)
//{
//    if (orderID.StartsWith('B'))
//    {
//        Console.WriteLine(orderID);
//    }
//}

//Random random = new Random();
//string[] orderIDs = new string[5];
//// Loop through each blank orderID
//for (int i = 0; i < orderIDs.Length; i++)
//{
//    // Get a random value that equates to ASCII letters A through E
//    int prefixValue = random.Next(65, 70);
//    // Convert the random value into a char, then a string
//    string prefix = Convert.ToChar(prefixValue).ToString();
//    // Create a random number, pad with zeroes
//    string suffix = random.Next(1, 1000).ToString("000");
//    // Combine the prefix and suffix together, then assign to current OrderID
//    orderIDs[i] = prefix + suffix;
//}
//// Print out each orderID
//foreach (var orderID in orderIDs)
//{
//    Console.WriteLine(orderID);
//}

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

//string originalMessage = "The quick brown fox jumps over the lazy dog.";

//char[] message = originalMessage.ToCharArray();
//Array.Reverse(message);

//int letterCount = 0;

//foreach (char letter in message)
//{
//    if (letter == 'o')
//    {
//        letterCount++;
//    }
//}

//string newMessage = new String(message);

//Console.WriteLine(newMessage);
//Console.WriteLine($"'o' appears {letterCount} times.");

// Scope!!!

//bool flag = true;
//if (flag)
//{
//    int value = 10;
//    Console.WriteLine($"Inside the code block: {value}");
//}
////Console.WriteLine($"Outside the code block: {value}"); // error de scope la variable value no existe fuera del if

//bool flag2 = true;
//if (flag2)
//    Console.WriteLine(flag); // igual que JS si es una sola linea no hacen falta las {} aunque mejoran legibilidad y generalmente hacen falta

//string name = "steve";
//if (name == "bob") Console.WriteLine("Found Bob");
//else if (name == "steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck");