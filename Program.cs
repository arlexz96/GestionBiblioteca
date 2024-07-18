using TallerSemana_Biblioteca.Models;

namespace TallerSemana_Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Program.Menu();
    }

        public static void Menu()
    {
        int option;
        Biblioteca oBiblioteca = new Biblioteca();
        do
        {
            Console.Write(@"
###############################################################################################
#                                        MENU                                                 #    
###############################################################################################

1. Agregar Libro.
2. Mostrar Libros.
17. Salir.

Selecciona una opcion: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    oBiblioteca.AgregarLibro();
                    break;
                case 2:
                    Console.Clear();
                    oBiblioteca.MostrarLibros();
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    Console.WriteLine("Aplicacion finalizada con exito!");
                    break;
                default:
                Console.WriteLine("Opción inválida, por favor intente de nuevo");
                    break;
            }
        } while (option != 17);
    }
}
