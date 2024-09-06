// Este es un programa de consola simple en C# que demuestra varias características del lenguaje, 
// incluyendo clases, herencia, encapsulamiento, polimorfismo, y sobrecarga de métodos.

using System;
using System.Collections.Generic;
using System.Linq; // Para usar LINQ

class Program
{
    // El punto de entrada del programa
    static void Main(string[] args)
    {
        // ---- Concepto básico: Imprimir en consola ----
        // 'Console.WriteLine' imprime texto en la consola.
        // El método "WriteLine" es parte de la clase estática "Console", la cual contiene métodos para interactuar con la consola.
        Console.WriteLine("Hello, World!"); // Esto imprimirá "Hello, World!" en la consola.

        // ---- Concepto intermedio: Creación de objetos e invocación de métodos ----
        // Aquí creamos un objeto de la clase 'Sale'. La clase 'Sale' tiene un constructor que toma un precio como parámetro.
        var sale = new Sale(15.0f);  // Creamos un objeto de tipo 'Sale' con un precio de 15.0.

        // Invocamos el método 'GetInfo' que devuelve un string con el precio de la venta.
        // Esto demostrará encapsulamiento, ya que estamos accediendo a una propiedad privada a través de un método público.
        Console.WriteLine(sale.GetInfo()); // Salida: "El precio es: 15"

        // ---- Concepto avanzado: Herencia y polimorfismo ----
        // Ahora creamos un objeto de la clase derivada 'SaleWithTax', que hereda de 'Sale'.
        var saleWithTax = new SaleWithTax(20.0f, 1.15f); // El segundo argumento es la tasa de impuesto.

        // Usamos el método 'GetInfo' sobrescrito en 'SaleWithTax' para calcular el precio con impuestos.
        Console.WriteLine(saleWithTax.GetInfo()); // Salida: "El precio es: 23"

        // Modificamos la propiedad 'Tax' (tasa de impuesto).
        saleWithTax.Tax = 1.23f;

        // Este método sobrecargado permite pasar un parámetro adicional (el nombre de la tienda).
        Console.WriteLine(saleWithTax.GetInfo("Francia")); // Salida: "El precio en la tienda: Francia es: 24.6"
                                                           // ---- Impresión en consola y variables ----
        Console.WriteLine("---- Ejemplos básicos de C# ----");

        int num = 10;  // Declaración de una variable entera
        string message = "Hola, mundo";  // Declaración de una variable de texto
        Console.WriteLine(message + " El número es: " + num);

        // ---- Condicionales ----
        Console.WriteLine("\n---- Condicionales ----");
        if (num > 5)
        {
            Console.WriteLine("El número es mayor que 5");
        }
        else
        {
            Console.WriteLine("El número es menor o igual a 5");
        }

        // ---- Switch Case ----
        Console.WriteLine("\n---- Switch Case ----");
        switch (num)
        {
            case 10:
                Console.WriteLine("El número es 10");
                break;
            case 5:
                Console.WriteLine("El número es 5");
                break;
            default:
                Console.WriteLine("El número no es ni 5 ni 10");
                break;
        }

        // ---- Bucles ----
        Console.WriteLine("\n---- Bucles ----");

        // Bucle for
        Console.WriteLine("Bucle for:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // Bucle while
        Console.WriteLine("\nBucle while:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("j = " + j);
            j++;
        }

        // ---- Arreglos ----
        Console.WriteLine("\n---- Arreglos ----");
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Imprimir elementos del arreglo
        foreach (int n in numeros)
        {
            Console.WriteLine("Número: " + n);
        }

        // ---- Listas y Colecciones ----
        Console.WriteLine("\n---- Listas y Colecciones ----");
        List<string> nombres = new List<string> { "Juan", "Ana", "Carlos" };

        // Añadir y eliminar elementos
        nombres.Add("Maria");
        nombres.Remove("Carlos");

        // Imprimir elementos de la lista
        foreach (string nombre in nombres)
        {
            Console.WriteLine("Nombre: " + nombre);
        }

        // ---- LINQ ----
        Console.WriteLine("\n---- Uso de LINQ ----");
        var numerosFiltrados = numeros.Where(x => x > 3).ToList(); // Filtrar números mayores que 3
        Console.WriteLine("Números filtrados con LINQ: ");
        numerosFiltrados.ForEach(n => Console.WriteLine(n));

        // ---- Algoritmos básicos: Ordenamiento por burbuja ----
        Console.WriteLine("\n---- Algoritmo de Ordenamiento (Burbuja) ----");
        int[] arrayDesordenado = { 5, 3, 8, 4, 1 };
        BubbleSort(arrayDesordenado);
        Console.WriteLine("Array ordenado:");
        foreach (var item in arrayDesordenado)
        {
            Console.WriteLine(item);
        }

        // ---- Estructuras de Datos: Pila (Stack) ----
        Console.WriteLine("\n---- Estructura de Datos: Pila (Stack) ----");
        Stack<int> pila = new Stack<int>();
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        Console.WriteLine("Pila:");
        while (pila.Count > 0)
        {
            Console.WriteLine(pila.Pop()); // LIFO: Último en entrar, primero en salir
        }

        // ---- Patrones de Diseño: Singleton ----
        Console.WriteLine("\n---- Patrón de Diseño: Singleton ----");
        var singleton = Singleton.Instance;
        singleton.MostrarMensaje("Este es el patrón Singleton");

        // ---- Patrones de Diseño: Strategy ----
        Console.WriteLine("\n---- Patrón de Diseño: Strategy ----");
        var context = new Contexto(new OperacionSuma());
        Console.WriteLine("Suma: " + context.EjecutarOperacion(5, 3));

        context.SetStrategy(new OperacionResta());
        Console.WriteLine("Resta: " + context.EjecutarOperacion(5, 3));
    }

    // ---- Algoritmo: Ordenamiento por burbuja ----
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

// ---- Clases y Objetos en C# ----
// Definimos una clase 'Sale', que representa una venta con un precio. 
// Las clases son moldes para crear objetos, y pueden contener propiedades y métodos.
class Sale
{
    // ---- Propiedades y Encapsulamiento ----
    // Esta es una propiedad auto-implementada. El modificador 'private set' indica que solo puede ser modificada
    // dentro de la clase 'Sale', promoviendo el encapsulamiento (esconder detalles de implementación).
    public float Price { get; private set; }

    // ---- Constructor ----
    // El constructor es un método especial que se invoca cuando creamos un objeto de la clase.
    // Aquí inicializamos la propiedad 'Price' con el valor pasado como parámetro.
    public Sale(float price)
    {
        Price = price;
    }

    // ---- Polimorfismo y Métodos Virtuales ----
    // Este es un método virtual, lo que significa que las clases derivadas pueden sobrescribir su comportamiento.
    public virtual string GetInfo()
    {
        // Concatenación de strings para mostrar información de la venta.
        return "El precio es: " + Price;
    }
}

// ---- Herencia en C# ----
// La clase 'SaleWithTax' hereda de 'Sale' usando la sintaxis ': Sale'.
// Esto significa que 'SaleWithTax' tiene todas las propiedades y métodos de 'Sale', pero puede añadir o modificar comportamientos.
class SaleWithTax : Sale
{
    // ---- Propiedades con set/get ----
    // Esta propiedad pública permite establecer y obtener el valor del impuesto.
    // No tiene restricciones en el setter, por lo que se puede modificar desde fuera de la clase.
    public float Tax { get; set; }

    // ---- Constructor de Clases Derivadas ----
    // El constructor de 'SaleWithTax' usa 'base(price)' para llamar al constructor de la clase padre ('Sale') 
    // y pasarle el precio. Además, inicializa la propiedad 'Tax'.
    public SaleWithTax(float price, float tax) : base(price)
    {
        Tax = tax;
    }

    // ---- Sobrescritura de Métodos (Override) ----
    // Aquí sobrescribimos el método 'GetInfo' de la clase base 'Sale'.
    // En lugar de solo mostrar el precio, este método calcula el precio con el impuesto aplicado.
    public override string GetInfo()
    {
        return "El precio es: " + this.Price * Tax;
    }

    // ---- Sobrecarga de Métodos (Overloading) ----
    // Aquí estamos sobrecargando el método 'GetInfo', lo que significa que hay dos versiones del mismo método:
    // una que toma cero parámetros y otra que toma un parámetro adicional (el nombre de la tienda).
    public string GetInfo(string tienda)
    {
        return "El precio en la tienda: " + tienda + " es: " + this.Price * Tax;
    }
}

/*
    ---- Resumen de características demostradas ----
    1. Impresión en consola usando 'Console.WriteLine'.
    2. Creación de clases y objetos en C#.
    3. Uso de constructores para inicializar propiedades.
    4. Encapsulamiento: Propiedades privadas con acceso controlado mediante 'get' y 'set'.
    5. Herencia: 'SaleWithTax' hereda de 'Sale'.
    6. Polimorfismo: Uso de métodos virtuales y override.
    7. Sobrecarga de métodos: 'GetInfo' tiene dos versiones.
    8. Modificadores de acceso: 'public', 'private', y 'virtual'.
*/

// ---- Patrón de Diseño: Singleton ----
class Singleton
{
    // Una instancia privada y estática de la misma clase
    private static Singleton instance = null;

    // Constructor privado para evitar instanciación
    private Singleton() { }

    // Método para obtener la única instancia de la clase
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

// ---- Patrón de Diseño: Strategy ----
interface IStrategy
{
    int Operar(int num1, int num2);
}

class OperacionSuma : IStrategy
{
    public int Operar(int num1, int num2)
    {
        return num1 + num2;
    }
}

class OperacionResta : IStrategy
{
    public int Operar(int num1, int num2)
    {
        return num1 - num2;
    }
}

class Contexto
{
    private IStrategy _strategy;

    public Contexto(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public int EjecutarOperacion(int num1, int num2)
    {
        return _strategy.Operar(num1, num2);
    }
}

/*
    ---- Resumen de conceptos y características de C# ----

    1. Variables: int, string, etc.
    2. Condicionales: if-else, switch-case.
    3. Bucles: for, while.
    4. Arreglos: Declaración e iteración de arrays.
    5. Listas: Uso de List<T> y métodos como Add, Remove.
    6. LINQ: Filtrado de colecciones con expresiones lambda.
    7. Algoritmos: Ordenamiento por burbuja.
    8. Estructuras de Datos: Pila (Stack).
    9. Patrones de Diseño: Singleton, Strategy.
*/