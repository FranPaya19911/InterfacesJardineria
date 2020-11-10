using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_pedido
    {
        private int _codigoPedido, _cantidad;
        private string _codigoProducto;
        private decimal _precioUnitario;
        private short _numeroLinea;

        public Detalle_pedido()
        {
            _codigoPedido = 0;
            _codigoProducto = "";
            _cantidad = 0;
            _precioUnitario = 0;
            _numeroLinea = 0;
        }
        public Detalle_pedido(int codigoPedido, string codigoProducto, int cantidad, decimal precioUnitario, short numeroLinea)
        {
            _codigoPedido = codigoPedido;
            _codigoProducto = codigoProducto;
            _cantidad = cantidad;
            _precioUnitario = precioUnitario;
            _numeroLinea = numeroLinea;
        }
        public Detalle_pedido(Detalle_pedido previousPedido)
        {
            _codigoPedido = previousPedido._codigoPedido;
            _codigoProducto = previousPedido._codigoProducto;
            _cantidad = previousPedido._cantidad;
            _precioUnitario = previousPedido._precioUnitario;
            _numeroLinea = previousPedido._numeroLinea;
        }
        ~Detalle_pedido()
        {
            _codigoPedido = 0;
            _codigoProducto = "";
            _cantidad = 0;
            _precioUnitario = 0;
            _numeroLinea = 0;
        }

        public override string ToString()
        {
            return _codigoPedido.ToString() + " # " + _codigoProducto + " # " + _cantidad.ToString() + " # " + _precioUnitario.ToString() + " # " + _numeroLinea.ToString();
        }

        public int Codigo_Pedido
        {
            get
            {
                return _codigoPedido;
            }
            set
            {
                _codigoPedido = value;
            }
        }
        public string Codigo_producto
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
        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
        public decimal Precio_Unitario
        {
            get
            {
                return _precioUnitario;
            }
            set
            {
                if (value.ToString().Length <= 15)
                    _precioUnitario = value;
            }
        }
        public short Numero_Linea
        {
            get
            {
                return _numeroLinea;
            }
            set
            {
                _numeroLinea = value;
            }
        }
    }
}
