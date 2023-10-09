using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Progra1_CristoferSanchez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
  
         
            int opcion = 0;
            
            string[] afiliados = new string[0]; ;
            string[] tiposGanado = { "VACUDO", "CAPRINO", "OVINO", "BUFALINO" };
            int intentos = 0;
            bool autenticado = false;

            while (intentos < 2 && !autenticado)
            {
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Contraseña: ");
                string contraseña = Console.ReadLine();

                if ((usuario == "UPI23" && contraseña == "Chr0mE%") ||
                   (usuario == "PRO23" && contraseña == "1nT3rN3T%"))
                {
                    autenticado = true;
                    Console.WriteLine("Inicio de sesión exitoso, bienvenido.");
                }
                else
                {
                    intentos++;
                    Console.WriteLine("Nombre de usuario o contraseña incorrectos. Intento #" + intentos);
                }
            }
            do
            {
                Console.WriteLine(" BIENVENIDO");
                Console.WriteLine("------MENU------");
                Console.WriteLine(" DIGITE UNA OPCION");
                Console.WriteLine("PRODUCTORES DE LECHE");
                Console.WriteLine("1. AFILIACION");
                Console.WriteLine("2. ASOCIADOS ");
                Console.WriteLine("3. GANADO");
                Console.WriteLine("4. CALCULADORA");
                Console.WriteLine("5. SALIR");
             
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {


                    case 1:

                        
                        Console.Write("CANTIDAD DE AFILIADOS: ");
                        int cantidadAfiliados = int.Parse(Console.ReadLine());
                        afiliados = new string[cantidadAfiliados];
                        for (int i = 0; i < cantidadAfiliados; i++)
                        {
                            Console.Write("NOMBRE DEL AFILIADO " + (i + 1) + ": ");
                            afiliados[i] = Console.ReadLine();
                        }

                        break;

                    case 2:
                        Console.WriteLine("ASOCIADOS:");
                        foreach (string afiliado in afiliados)
                        {
                            Console.WriteLine(afiliado);
                        }
                        break;


                        case 3:

                        Console.WriteLine(" LOS TIPOS DE GANADO SON:");
                        foreach (string tipo in tiposGanado)
                        {
                            Console.WriteLine(tipo);
                        }
                        break;

                        case 4:

                        Console.Write("BUSCADOR DE ASOCIADO: ");
                        string asociadoBuscado = Console.ReadLine();
                        int indiceAsociado = Array.IndexOf(afiliados, asociadoBuscado);
                        if (indiceAsociado == -1)
                        {
                            Console.WriteLine("EL ASOCIADO NO SE ENCUENTRA, INTENTE DE NUEVO.");
                        }
                        else
                        {
                            Console.Write("FECHA DE RECOLECCIÓN DE LECHE: ");
                            string fechaRecoleccionleche = Console.ReadLine();
                            Console.Write("CANTIDAD DE LECHE EN GALONES: ");
                            double cantidadGalones = double.Parse(Console.ReadLine());

                            double precioPorLitro = 1300;
                            double totalPagar = cantidadGalones * precioPorLitro;
                            double aumento = 0;




                            if (totalPagar <= 5000)
                            {
                                aumento = totalPagar * 0.2;
                            }
                            else if (totalPagar > 5000 && totalPagar <= 10000)
                            {
                                aumento = totalPagar * 0.15;
                            }

                            double totalConAumento = totalPagar + aumento;

                            Console.WriteLine("PRODUCTORES DE LECHE");
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("ASOCIADO: " + afiliados[indiceAsociado]);
                            Console.WriteLine("GALONES " + cantidadGalones);
                            Console.WriteLine("LITROS: " + (cantidadGalones * 3.78541));
                            Console.WriteLine("ENTREGA: " + fechaRecoleccionleche);
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("PAGO: " + totalPagar);
                            Console.WriteLine("AUMENTO: " + aumento);
                            Console.WriteLine("TOTAL: " + totalConAumento);
                            Console.WriteLine("¡GRACIAS!");
                        }
                        break;

                    case 5:
                        Console.WriteLine("LA APLICACIÓN SE CERRARÁ.");
                        break;

                    default:
                        Console.WriteLine("Opción invalida.");
                        break;


                }

            } while (opcion != 5);




        }
    }
}
