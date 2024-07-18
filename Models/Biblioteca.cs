using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerSemana_Biblioteca.Models
{
    public class Biblioteca
    {
        List<Libro> Libros = new List<Libro>(){
            {
                new Libro
                (
                    "The Catcher in the Rye",
                    "1951",
                    "978-0-316-76948-0",
                    "J.D. Salinger",
                    "Ficción literaria",
                    100000
                )
            },
            {
                new Libro
                (
                    "Brave New World", 
                    "1932", 
                    "978-0-06-085052-4", 
                    "Aldous Huxley", 
                    "Distopía, Ciencia ficción", 
                    150000
                )
            },
            {
                new Libro
                (
                    "Pride and Prejudice", 
                    "1813",
                    "978-0-19-953556-9", 
                    "Jane Austen", 
                    "Ficción, Romance", 
                    200000
                )
            },
            {
                new Libro
                (
                    "The Hobbit", 
                    "1937", 
                    "978-0-618-00221-3", 
                    "J.R.R. Tolkien", 
                    "Fantasía", 
                    250000
                )
            }
        };

        public void AgregarLibro(){
            string Titulo, Isbn, AnoPublicacion, Autor, Genero;
            double Precio;

            Console.Write("Ingrese el Titulo del libro: ");
            Titulo = Console.ReadLine();
            Console.Write("\nIngrese el ISBN del libro: ");
            Isbn = Console.ReadLine();
            Console.Write("\nIngrese el año de publicacion del libro: ");
            AnoPublicacion = Console.ReadLine();
            Console.Write("\nIngrese el autor del libro: ");
            Autor = Console.ReadLine();
            Console.Write("\nIngrese el genero del libro: ");
            Genero = Console.ReadLine();
            Console.Write("\nIngrese el precio del libro: ");
            Precio = Convert.ToDouble(Console.ReadLine());

            Libro libro = new Libro(Titulo,Isbn,AnoPublicacion,Autor, Genero,Precio);

            Console.Write("\nLibro Agregado exitosamente!\n");

            libro.MostrarDatos();

            Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
            Console.ReadKey();
            Console.Clear();
        }

/*         public void EliminarLibro(){
            int opt
        } */

        public void MostrarLibros(){
            Console.WriteLine($@" ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        | Precio
------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var libro in Libros)
            {
                Console.WriteLine($@" {libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}| {libro.Precio}");
            }
        }
    }
}