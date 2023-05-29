using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Services__funciones_
{
    public class Operaciones 
    {
        
        public float Descuento(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            float descuento = tcompra * 0.10f;
            float tpagar = tcompra - descuento;
            return tpagar;
            
            /*float tpagar = tpagar * porcentaje;
            float porcentaje = 0.10f;           //f is for using the variable decimal
            float descuento = tpagar * porcentaje;
            tpagar = descuento - tpagar;
            return tpagar;*/
        }

        public float TMesesSI(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            tcompra = tcompra / 3;
            return tcompra;

        }
        public float SMesesSI(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            tcompra = tcompra / 6;
            return tcompra;
        }
        public float DMesesSI(float product1, float product2, float product3, float product4, float product5)
        {
            float tcompra = product1 + product2 + product3 + product4 + product5;
            tcompra = tcompra / 12;
            return tcompra;
        }

    }
}
