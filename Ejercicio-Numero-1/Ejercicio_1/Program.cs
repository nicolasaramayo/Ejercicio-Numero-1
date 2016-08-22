using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";

            /*
             *  Ingresar 5 números por consola, guardándolos en una variable
             *  escalar. Luego calcular y mostrar: 
             *  el valor máximo, el valor mínimo y el promedio
             */

            int numero = 0;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            float promedio = 0f;
            //Constante de 5 numeros.
            const int CANTIDAD_TOTAL = 5;



            for (int contador = 0; contador < CANTIDAD_TOTAL; contador++)
            {
                Console.WriteLine("Ingrese un numero Por Favor: ");
                //Verifica que haya ingresado un número y no una letra.
                //(Int32.Tryparse) Convierte un 'string' a 'int', sino devuelve 'false' y entra en el while. 
                while (!(Int32.TryParse(Console.ReadLine(), out numero)))
                {
                    #region Pantalla/Sonido de Error.
                    //Vuelve color rojo las frase de error.
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Notifica con un sonido el error.
                    Console.Beep(658, 250);
                    #endregion

                    Console.WriteLine("Error, Reingrese numero: ");
                    Console.ResetColor();
                }

                acumulador += numero;

                //Cuando ingresamos el primer numero, siempre sera el máximo y mínimo.
                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }

                //Máximo.
                if (maximo < numero)
                {
                    maximo = numero;
                }

                //Mínimo.
                if (minimo > numero)
                {
                    minimo = numero;
                }
            }
            

            //Promedio.
            promedio = (float)(acumulador / CANTIDAD_TOTAL);

            //MUESTRO LOS RESULATADOS POR CONSOLA.
            Console.WriteLine("El numero maximo fue de {0}, el minimo {1}", maximo, minimo);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadKey();

        }
    }
}
