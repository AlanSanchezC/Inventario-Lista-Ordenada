/*
 *  Creado por Alan Francisco Sánchez Cazarez
 */

using System;

namespace ControlDeInventario
{
    class Producto
    {
        private string _codigo;
        public string codigo
        {
            get { return _codigo; }
        }
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
        }
        private int _cantidad;
        public int cantidad
        {
            get { return _cantidad; }
        }
        private double _precio;
        public double precio
        {
            get { return _precio; }
        }

        private Producto _siguiente;
        public Producto siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Producto(string codigo, string nombre, int cantidad, double precio)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._cantidad = cantidad;
            this._precio = precio;
        }

        public override string ToString()
        {
            string s = codigo.ToString() + " - " + nombre.ToString() + Environment.NewLine +
                        "Cantidad: " + cantidad.ToString() + Environment.NewLine +
                        "Precio: " + precio.ToString() + Environment.NewLine;
            return s; 
        }
    }
}
