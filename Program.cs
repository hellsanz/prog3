using System;

namespace juegoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicion = false;
            Dado eldado = new Dado();            

            while (condicion == false)
            {
                Console.WriteLine("Cuantos lados tiene su dado?\n");
                try
                {
                    eldado.ingresoLados();
                    break;
                }
                catch (System.FormatException letras)
                {
                    Console.WriteLine("Error de Tipo de dato: " + letras.Message + "\n");
                }
                catch (System.OverflowException grande)
                {
                    Console.WriteLine("Error de Sobredimension: " + grande.Message + "\n");
                }
                Console.WriteLine("\n - - - - - - - - - - - - - - - - - - - \n");
            }
                    
            
            //Pedimos el ingreso de un numero para la apuesta
            Console.WriteLine("Hola, elija un numero del 1 al {0}: ", eldado.getLados());
            try
            {
                int nroElegido = int.Parse(Console.ReadLine());
                //Comprobamos si el numero ingresado es valido
                eldado.comprobacionNumero(nroElegido);

                //Si el numero es valido comparamos y mostramos el resultado
                Console.WriteLine(eldado.numeroDado(nroElegido));
            }            
            catch (System.FormatException letras)
            {
                Console.WriteLine("Error de Tipo de dato: "+letras.Message);
            }
            catch (System.OverflowException grande)
            {
                Console.WriteLine("Error de Sobredimension: "+grande.Message);
            }                        
            Console.ReadKey();
        }
    }   
}
