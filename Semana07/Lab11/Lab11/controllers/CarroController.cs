using Lab11.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.controllers
{
    internal class CarroController
    {
        private Queue<Carro> cola = new Queue<Carro>();

        public CarroController() { }

        public Queue<Carro> ObtenerCola()
        {
            return cola;
        }

        public void Ingresar(Carro carro)
        {
            cola.Enqueue(carro);
        }

        public int Salir(String matricula)
        {

            int movimientos = 1;
            bool encontrado = false;

            Queue<Carro> nuevaCola = new Queue<Carro>();

            while (cola.Count > 0)
            {
                // Encontrar el carro en primera posición
                Carro carro = cola.Peek();
                if (carro.Matricula.Equals(matricula))
                {
                    cola.Dequeue();
                    encontrado = true;
                }
                else
                {
                    // Pasa a la nuevaCola
                    nuevaCola.Enqueue(carro);
                    cola.Dequeue();
                    if (!encontrado)
                    {
                        movimientos++;
                    }
                }
            }
            cola = nuevaCola;
            return movimientos;
        }
    }
}
