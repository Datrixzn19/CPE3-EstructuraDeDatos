/*

Aplicación para el registro de libros en una biblioteca

*/

using System;


class Program
{
    static void Main()
    {
        // Conjunto de libros
        Dictionary<string, string> libros = new Dictionary<string, string>();

        /*
        He visto conveniente hacer un menu, para que el programa sea interactivo
        Daremos opciones basicas 
        */
        while (true)//va a entrar simpre porque esta en true
        {
            Console.WriteLine("\n****************************\n****************************");
            Console.WriteLine("Bienvenidos a mi bliblioteca vitual");
            Console.WriteLine("Seleccione una de las opciones");
            Console.WriteLine("1. Agregar un libro");
            Console.WriteLine("2. Eliminar un libro");
            Console.WriteLine("3. Buscar un libro");
            Console.WriteLine("4. Listar los libros agregados");
            Console.WriteLine("5. Cerrar el programa");

            Console.Write("Ingrese su opción: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarLibro(libros);
                    break;
                case "2":
                    EliminarLibro(libros);
                    break;
                case "3":
                    BuscarLibro(libros);
                    break;
                case "4":
                    ListarLibros(libros);
                    break;
                case "5":
                Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Lo sentimos, la opcion elegina no es valida, intentalo de nuevo.");
                    break;
            }
        }
    }



//metodo para agregar un libro
    static void AgregarLibro(Dictionary<string, string> libros)
    {
        //vamosa  pedir una clave que sera el titulo
        //y un valor que será el autor
        Console.Write("Ingrese el título del libro: ");
        string? titulo = Console.ReadLine(); //guardamos el titulo que nos de el usuario
        Console.Write("Ingrese el autor del libro: ");
        string? autor = Console.ReadLine(); //guardamos el autor que nos de el usuario

        if (libros.ContainsKey(titulo))// si hay esa clave ingresa a este if y nos avisara que ya existe
        {
            Console.WriteLine("El libro ingresado ya existe en la biblioteca");
        }
        else // si el libro no existe entonces lo agregamos
        {
            libros.Add(titulo, autor);//con el método  .Add agreganmos la clave y valor
            Console.WriteLine("Libro agregado con éxito ☑");
        }
    }


//método para elimninar un libro
    static void EliminarLibro(Dictionary<string, string> libros)
    {
        Console.Write("Ingrese el título del libro que desea eliminar: ");
        string titulo = Console.ReadLine();//pedimos el titulo del libro a eliminar

        if (libros.ContainsKey(titulo))//vemos si existe
        {
            libros.Remove(titulo);//usamos remove y pasamos como parametro el titulo que escriba el usuario
            Console.WriteLine("eL libro a sido eliminado correctamente ☑");
        }
        else//en caso de que no exista ese titulo
        {
            Console.WriteLine("Lo sentimos, el libro que desea eliminar no existe en la biblioteca");
        }
    }


//método para buscar un libro
    static void BuscarLibro(Dictionary<string, string> libros)
    {
        Console.Write("Por favor, ingrese el título del libro que desea buscar: ");
        string? titulo = Console.ReadLine();

        if (libros.ContainsKey(titulo))//si contine esa clave nuestra biblioteca
        {
            // {libros[titulo]} nos da la clave de titulo
            Console.WriteLine($"Hemos econtrado el libro llamado: '{titulo}', fue escrito por: {libros[titulo]}");
        }
        else//si no encontramos esa clave
        {
            Console.WriteLine("Lo sentimos, el libro que esta buscando no existe en la biblioteca");
        }
    }



    static void ListarLibros(Dictionary<string, string> libros)
    {
        if (libros.Count == 0)//en caso de que hayan 0 libros
        {
            Console.WriteLine("Lo sentimos, actualmente no hay libros en la biblioteca");
        }
        else//en caso de que minimo exista un libro
        {
            Console.WriteLine("Lista de libros:");
            foreach (var libro in libros)//imprimimos todos los libros de la biblioteca
            {
                Console.WriteLine($"Titulo: {libro.Key}, escrito por: {libro.Value}");//mostramos clave y valor
            }
        }
    }
    
}
