using Clase.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Datos
{
    public class ManejadorArchivoSecuencial
    {
        private static string archivo = "Esfera.txt";
        
        public static void GuardarEnArchivoSecuencial(List<Esfera> listaEsfera)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var esfera in listaEsfera)
                {
                    string linea = ConstruirLinea(esfera);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Esfera> leerArchivo()
        {
            List<Esfera> listaEsfera = new List<Esfera>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {

                        string linea = lector.ReadLine();
                        Esfera esfera = ConstruirEsfera(linea);
                        listaEsfera.Add(esfera);
                    }
                }
            }
            return listaEsfera;
        }

        private static Esfera ConstruirEsfera(string linea)
        {
            var campos = linea.Split('|');
            Esfera esfera = new Esfera()
            {
                radio = float.Parse(campos[0]),
                ColorRelleno = (ColorEsf) int.Parse(campos[1]),
                trazo=(Trazo) int.Parse(campos[2]),
                
            };
            return esfera;
        }

        private static string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.radio}|{(int)esfera.ColorRelleno}|{(int)esfera.trazo}";
        }
    }
}
