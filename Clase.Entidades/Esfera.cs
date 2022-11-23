using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Entidades
{
    public class Esfera
    {
        public float radio { get;set;}
        public ColorEsf ColorRelleno {get;set;}
        public Trazo trazo { get; set; }
        public float GetVolumen()
        {
            return (float)((0.75) * Math.PI * (radio*radio*radio));
        }
        public float GetArea()
        {
            return (float)(4 * Math.PI * (radio * radio));
        }
    }
}
