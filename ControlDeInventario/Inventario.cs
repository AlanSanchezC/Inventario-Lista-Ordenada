/*
 *  Creado por Alan Francisco Sánchez Cazarez
 */

using System;

namespace ControlDeInventario
{
    class Inventario
    {
        private Producto inicio;

        public Inventario()
        {
            inicio = null;
        }

        public bool agregar(Producto p)
        {
            Producto pr = inicio;

            if (inicio == null)
            {
                inicio = p;
            }
            else
            { 
                if (p.nombre.CompareTo(pr.nombre) < 0)
                {
                    p.siguiente = pr;
                    inicio = p;
                }
                else 
                {
                    try
                    {
                        while (p.nombre.CompareTo(pr.siguiente.nombre) > 0)
                        {
                            pr = pr.siguiente;
                        }
                        p.siguiente = pr.siguiente;
                        pr.siguiente = p;
                    }
                    catch (System.NullReferenceException)
                    {
                        pr.siguiente = p;
                    }
                }
             }
            return true;
        }

        public string reporte()
        {
            string cad = "";
            Producto pr = inicio;

            while(pr != null)
            {
                cad += pr.ToString() + Environment.NewLine;
                pr = pr.siguiente;
            }

            return cad;
        }

        public Producto busqueda(string codigo)
        {
            Producto pr = inicio;

            while(pr.codigo != codigo)
            {
                pr = pr.siguiente;
            }
            return pr;
        }

        public void eliminar(string codigo)
        {
            Producto pr = inicio;
            bool encontrado = false;

            if (inicio.codigo == codigo)
            {
                inicio = inicio.siguiente;
                encontrado = true;
            }

            while (!encontrado)
            {
                if (pr.siguiente.codigo == codigo)
                {
                    pr.siguiente = pr.siguiente.siguiente;
                    encontrado = true;
                }
                pr = pr.siguiente;
            }
        }
    }
}
