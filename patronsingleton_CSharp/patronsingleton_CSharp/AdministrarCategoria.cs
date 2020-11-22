using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace patronsingleton_CSharp
{
    public class AdministrarCategoria
    {
        static Dictionary<int, DatosCategoria> Registros = new Dictionary<int, DatosCategoria>();
        static int cant = 0;

        private static AdministrarCategoria instancia;

        private AdministrarCategoria() { }

        public static AdministrarCategoria getInstancia()
        {
            if (instancia == null)
            {
                instancia = new AdministrarCategoria();
            }
            return instancia;
        }

        public bool AgregarRegistro(string nombre_c)
        {
            try
            {
                DatosCategoria reg = new DatosCategoria();
                reg.setId(cant + 1);
                reg.setNombre(nombre_c);
                reg.setEstado(true);

                Registros.Add(reg.getId(), reg);
                cant++;
                return true;
            }
            catch { return false; }
        }

        public ArrayList BuscarRegistro(int id_c)
        {
            ArrayList reg = new ArrayList();

            if (Registros.ContainsKey(id_c) == true)
            {
                reg.Add(Registros[id_c].getId());
                reg.Add(Registros[id_c].getNombre());
                reg.Add(Registros[id_c].getEstado());
            }

            return reg;
        }

        public bool ModificarRegistro(int id_c, string nombre_c, bool estado_c)
        {
            if (Registros.ContainsKey(id_c) == true)
            {
                DatosCategoria reg = new DatosCategoria();
                reg.setId(id_c);
                reg.setNombre(nombre_c);
                reg.setEstado(estado_c);

                Registros[id_c] = reg;
                return true;
            }
            else { return false; }
        }

        public bool EliminarRegistro(int id_c)
        {
            if (Registros.ContainsKey(id_c) == true)
            {
                Registros.Remove(id_c);
                return true;
            }
            else { return false; }
        }

        public ArrayList CargarCategoria()
        {
            ArrayList datos = new ArrayList();

            for (int i = 0; i <= cant; i++)
            {
                if (Registros.ContainsKey(i) == true && Registros[i].getEstado() == true)
                {
                    datos.Add(Registros[i].getNombre());
                }
            }
            return datos;
        }
    }
}
