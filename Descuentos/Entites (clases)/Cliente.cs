using Descuentos.Services__funciones_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Entites__clases_
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get;set; }
        public double telefono { get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de telefono: ");
            telefono = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su correo electronico:");
            Correo = Console.ReadLine();

            Console.Clear();

            Compra compra = new Compra();
            compra.Pedir();
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.telefono);
            Console.WriteLine(this.Correo);
        }
    }
}
