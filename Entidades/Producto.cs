using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto :IComparable<Producto>
    {

        private string _codigoProducto, _nombre, _gama, _dimensiones, _proveedor, _descripcion;   
        private short _cantidadEnStock;
        private decimal _precioVenta;
        private decimal? _precioProveedor;

        public Producto()
        {
            _codigoProducto = "";
            _nombre = "";
            _gama = "";
            _dimensiones = "";
            _proveedor = "";
            _descripcion = "";
            _cantidadEnStock = 0;
            _precioVenta = 0;
            _precioProveedor = 0;
        }
        public Producto(string codigoProducto, string nombre, string gama, string dimensiones, string proveedor, string descripcion, short cantidadEnStock, decimal precioVenta, decimal? precioProveedor)
        {
            _codigoProducto = codigoProducto;
            _nombre = nombre;
            _gama = gama;
            _dimensiones = dimensiones;
            _proveedor = proveedor;
            _descripcion = descripcion;
            _cantidadEnStock = cantidadEnStock;
            _precioVenta = precioVenta;
            _precioProveedor = precioProveedor;
        }
        public Producto(Producto previousProducto)
        {
            _codigoProducto = previousProducto._codigoProducto;
            _nombre = previousProducto._nombre;
            _gama = previousProducto._gama;
            _dimensiones = previousProducto._dimensiones;
            _proveedor = previousProducto._proveedor;
            _descripcion = previousProducto._descripcion;
            _cantidadEnStock = previousProducto._cantidadEnStock;
            _precioVenta = previousProducto._precioVenta;
            _precioProveedor = previousProducto._precioProveedor;
        }
        ~Producto()
        {
            _codigoProducto = "";
            _nombre = "";
            _gama = "";
            _dimensiones = "";
            _proveedor = null;
            _descripcion = "";
            _cantidadEnStock = 0;
            _precioVenta = 0;
            _precioProveedor = null;
        }
        public override string ToString()
        {
            return _codigoProducto + " # " + _nombre + " # " + _gama + " # " + _dimensiones + " # " + _proveedor + " # " + _descripcion + " # " + _cantidadEnStock.ToString() + " # " + _precioVenta.ToString() + " # " + _precioProveedor.ToString();
        }

        public string Codigo_Producto
        {
            get
            {
                return _codigoProducto;
            }
            set
            {
                if (value.Length <= 15 && value != null)
                    _codigoProducto = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Length <= 70 && value != null)
                    _nombre = value;
            }
        }
        public string Gama
        {
            get
            {
                return _gama;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _gama = value;
            }
        }
        public string Dimensiones
        {
            get
            {
                return _dimensiones;
            }
            set
            {
                if (value.Length <= 25)
                    _dimensiones = value;
            }
        }
        public string Proveedor
        {
            get
            {
                return _proveedor;
            }
            set
            {
                if (value.Length <= 50)
                    _proveedor = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
        public short Cantidad_En_Stock
        {
            get
            {
                return _cantidadEnStock;
            }
            set
            {
                _cantidadEnStock = value;
            }
        }
        public decimal Precio_Venta
        {
            get
            {
                return _precioVenta;
            }
            set
            {
                if (value.ToString().Length <= 15)
                    _precioVenta = value;
            }
        }
        public decimal? Precio_Proveedor
        {
            get
            {
                return _precioProveedor;
            }
            set
            {
                if (value.ToString().Length <= 15)
                    _precioProveedor = value;
            }
        }

        public int CompareTo(Producto other)
        {
            return string.Compare(_nombre, other._nombre);
        }
    }
}
