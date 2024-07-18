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
        do
        {
            Console.Write(@"
###############################################################################################
#                                        MENU                                                 #    
###############################################################################################

1. Registrar Venta.
2. Calcular Valor Total De Venta De Una Factura Específica.
3. Calcular Promedio De Ventas Diarias.
4. Mostrar Empleado Del Mes. 
5. Mostrar Cliente Del Mes.
6. Mostrar Ventas Realizadas Después De Una Fecha Específica.
7. Mostrar Vendedores Que Realizaron Ventas Por Encima De Cierto Valor.
8. Agrupar Las Ventas Por Mes y Calcular El Total De Ventas Mensuales.
9. Encontrar El Vendedor Con El Mayor Número De Ventas En Un Período Específico.
10. Ordenar las ventas por valor total descendente y mostrar las primeras N ventas.
11. Encontrar los productos más vendidos por cantidad en un año determinado.
12. Validar si existe alguna venta con un valor específico.
13. Buscar todas las ventas realizadas a un cliente específico.
14. Calcular el total de ventas para cada vendedor y mostrar el promedio de ventas por vendedor.
15. Encontrar el mes con el mayor número de ventas y mostrar las ventas de ese mes.
16. Agregar Vendedor.
17. Salir.

Selecciona una opcion: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
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
