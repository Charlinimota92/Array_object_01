// See https://aka.ms/new-console-template for more information
using Array_object_01;

Console.WriteLine("Gestion de pelicula y serie");
Console.WriteLine();


Peliculas[] peli = new Peliculas[3];

for (int i = 0;i < peli.Length; i++)
{
    peli[i] = new Peliculas();
    Console.WriteLine("Datos de la pelicula o serie no." + (i + 1));


    Console.Write("Nombre: ");
    peli[i].Nombre = Console.ReadLine();

    Console.Write("Género: ");
    peli[i].Genero = Console.ReadLine();

    Console.Write("Duración: ");
    peli[i].Duracion = double.Parse(Console.ReadLine());

    Console.WriteLine();
}

//Imprimir los datos
for (int i = 0; i < peli.Length; i++)
{
    Console.WriteLine("Datos de la pelicula o serie no." + (i + 1));
    Console.WriteLine();
    Console.WriteLine("========================================");
    peli[i].ImprimirDatos();
    Console.WriteLine();
    Console.WriteLine("=======================================");
}


