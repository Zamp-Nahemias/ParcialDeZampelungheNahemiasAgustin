using Clase.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Datos
{
    public class RepositorioDeEsfera
    {
        private List<Esfera> listaEsfera;
        public RepositorioDeEsfera()
        {
            listaEsfera = new List<Esfera>();
            listaEsfera = ManejadorArchivoSecuencial.leerArchivo();
        }
        public void Agregar(Esfera esfera)
        {
            listaEsfera.Add(esfera);
        }
        public int GetCantidad()
        {
            return listaEsfera.Count;
        }
        public List<Esfera> GetLista()
        {
            return listaEsfera;
        }
        public void Guardar()
        {
            ManejadorArchivoSecuencial.GuardarEnArchivoSecuencial(listaEsfera);
        }
    }
}
