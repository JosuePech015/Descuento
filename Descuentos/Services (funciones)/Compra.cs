using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Services__funciones_
{
    public class Compra
    {
        public float product1, product2, product3, product4, product5;
        public float tcompra;
        private int resp;
        public void Pedir ()
        {
            Console.WriteLine("Ingrese el precio del primer producto");
            product1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del segundo producto");
            product2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del tercer producto");
            product3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del cuarto producto");
            product4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del quinto producto");
            product5 = float.Parse(Console.ReadLine());
            Console.Clear();

            tcompra = product1 + product2 + product3 + product4 + product5;

            Console.WriteLine(tcompra);

            Operaciones operaciones = new();

            if (tcompra >= 10000)
            {
                Console.WriteLine("Felicidades, puedes elegir entre tener 6 o 12 meses sin interes por tu compra mayor a 10000");
                Console.WriteLine("cuantos meses sin interes prefieres tener 6 o 12");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 6:
                        tcompra = operaciones.SMesesSI(product1, product2, product3, product4, product5);
                        Console.WriteLine("Mensualmete pagarás " + tcompra + ":)");
                        break;
                    case 12:
                        tcompra = operaciones.DMesesSI(product1, product2, product3, product4, product5);
                        Console.WriteLine("Mensualmete pagarás " + tcompra + ":)");
                        break;

                }
            }
            else if (tcompra >= 8000)
            {
                tcompra = operaciones.TMesesSI(product1, product2, product3, product4, product5);
                Console.WriteLine("Felicidades, tienes 3 meses sin interes por haber tenido una compra mayor a  a 8000");
                Console.WriteLine("Mensualmete pagarás " + tcompra + ":)");
            }

            else if (tcompra >= 5000)
            {
                tcompra = operaciones.Descuento(product1, product2, product3, product4, product5);
                Console.WriteLine("Felicidades, tienes un descuento del 10% por haber tenido una compra mayor a 5000");
                Console.WriteLine(tcompra);
            }

           

            
        }

    }
}
