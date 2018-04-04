using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linea
{
    public class Linea3D : LineaAbstracta<Punto3D>
    {
        public override Punto3D[] Puntos { get; }

        public Linea3D(Punto3D[] puntos)
        {
            Puntos = puntos;
        }

        public override double Distancia(Punto3D punto1, Punto3D punto2)
        {
            double X2 = Math.Pow(punto2.X - punto1.X, 2);
            double Y2 = Math.Pow(punto2.Y - punto1.Y, 2);
            double Z2 = Math.Pow(punto2.Z - punto1.Z, 2);
            double distancia = Math.Sqrt(X2 + Y2 + Z2);

            return distancia;
        }
    }
}
