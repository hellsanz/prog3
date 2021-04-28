using System;
using System.Collections.Generic;
using System.Text;

namespace juegoDados
{
    class Dado
    {
        private int lados { get; set; }
        public Dado()
        {

        }
        public Dado(int lados)//constructor
        {
            this.lados = lados;
        }

        public void setLados(int lados)
        {
            this.lados = lados;
        }
        public int getLados()
        {
            return this.lados;
        }
        //Metodo que selecciona un numero entre el rango de [1, 6] y compara con el elegido
        protected internal String numeroDado(int nroElegido)
        {
            Random r = new Random();
            int numero = r.Next(1, this.lados);

            if (nroElegido == numero)
            {
                return "CORRECTO, el numero es " + numero;
            }
            else
            {
                return "Casi casi pa, el numero que salio es " + numero.ToString();
            }

        }
        //Metodo de comprobacion numero ingresado
        protected internal int comprobacionNumero(int numeroElegido)
        {
            while ((numeroElegido < 1) || (numeroElegido > this.lados))
            {
                Console.WriteLine("Error, seleccione un numero valido del 1 al {0}",this.lados);
                numeroElegido = int.Parse(Console.ReadLine());
            }
            return numeroElegido;
        }

        public int ingresoLados()
        {
            Boolean condicion = false;

            while (condicion == false)
            {
                lados = int.Parse(Console.ReadLine());
                if ((lados >= 4) && (lados <= 20))
                {
                    condicion = true;
                    Console.WriteLine("Ud ha seleccionado un dado de {0} lados\n", lados);                    
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El numero minimo es de 4 y el maximo de 20\n");
                    Console.WriteLine("Ingrese nuevamente: ");
                }
            }
            return lados;
        }
    }

}
