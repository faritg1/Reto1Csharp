using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaPushUp.Retos;

namespace PruebaPushUp.Menu;
public class Main
{
    public void MenuMain(){
    int op = 0;
    bool entrando = true;
    RetoUno retoUno = new RetoUno();
    RetoDos retoDos = new RetoDos();
    RetoTres retoTres = new RetoTres();
    do
    {
        /* try{ */
            Console.WriteLine("|------------------------PushUp Dev Farit---------------------------|");
            Console.WriteLine("|                       1. Reto Fibonacci                           |");
            Console.WriteLine("|                       2. Reto 2                                   |");
            Console.WriteLine("|                       3. Reto 3                                   |");
            Console.WriteLine("|                       4. Reto 4                                   |");
            Console.WriteLine("|                       5. Reto 5                                   |");
            Console.WriteLine("|                       0. Salir                                    |");
            Console.WriteLine("|___________________________________________________________________|");
            Console.Write("--> ");
            op = int.Parse(Console.ReadLine());

            switch (op){
                case 0:
                    Console.Clear();
                    Console.WriteLine("|--------------------------------------|");
                    Console.WriteLine("|    Gracias por usar este programa    |");
                    Console.WriteLine("|--------------------------------------|");
                    entrando = false;
                break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Bienvenido al ejercicio Fibonacci");
                    retoUno.Reto1();
                break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Bienvenido al ejercicio 2");
                    retoDos.Reto2();
                break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Bienvenido al ejercicio 3");
                    retoTres.retoTres();
                break;
                default:
                    Console.WriteLine("Te Saliste del RANGO");
                    Console.Write("ESPERE UN MOMENTO ...");
                    Thread.Sleep(2000);
                    Console.Clear();
                break;
            }
        /* }
        catch (Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
            Console.Write("ESPERE UN MOMENTO ...");
            Thread.Sleep(2000);
            Console.Clear();
        } */
    } while (entrando);
}
}





