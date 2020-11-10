using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido :IComparable<Pedido>
    {
        private int _codigoPedido, _codigoCliente;
        private DateTime _fechaPedido, _fechaEsperada;
        private DateTime? _fechaEntrega;
        private string _estado, _comentarios;

        public Pedido()
        {
            _codigoPedido = 0;
            _fechaPedido = DateTime.Now;
            _fechaEsperada = DateTime.Now;
            _fechaEntrega = DateTime.Now;
            _estado = "";
            _comentarios = "";
            _codigoCliente = 0;
        }
        public Pedido(int codigoPedido, DateTime fechaPedido, DateTime fechaEsperada, DateTime fechaEntrega, string estado, string comentario, int codigoCliente)
        {
            _codigoPedido = codigoPedido;
            _fechaPedido = fechaPedido;
            _fechaEsperada = fechaEsperada;
            _fechaEntrega = fechaEntrega;
            _estado = estado;
            _comentarios = comentario;
            _codigoCliente = codigoCliente;
        }
        public Pedido(Pedido previousPedido)
        {
            _codigoPedido = previousPedido._codigoPedido;
            _fechaPedido = previousPedido._fechaPedido;
            _fechaEsperada = previousPedido._fechaEsperada;
            _fechaEntrega = previousPedido._fechaPedido;
            _estado = previousPedido._estado;
            _comentarios = previousPedido._comentarios;
            _codigoCliente = previousPedido._codigoCliente;
        }
        ~Pedido()
        {
            _codigoPedido = 0;
            _fechaPedido = DateTime.Now;
            _fechaEsperada = DateTime.Now;
            _fechaEntrega = null;
            _estado = "";
            _comentarios = null;
            _codigoCliente = 0;
        }

        public override string ToString()
        {
            return _codigoPedido.ToString() + " # " +_fechaPedido.ToString() + " # " + _fechaEsperada.ToString() + " # " + _fechaEntrega.ToString()+ " # " +  _estado + " # " + _comentarios + " # " + _codigoCliente.ToString();
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
        public DateTime Fecha_Pedido
        {
            get
            {
                return _fechaPedido;
            }
            set
            {
                _fechaPedido = value;
            }
        }
        public DateTime Fecha_Esperada
        {
            get
            {
                return _fechaEsperada;
            }
            set
            {
                _fechaEsperada = value;
            }
        }
        public DateTime? Fecha_Entrega
        {
            get
            {
                return _fechaEntrega;
            }
            set
            {
                _fechaEntrega = value;
            }
        }
        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                if (value.Length <= 15 && value != null)
                    _estado = value;
            }
        }
        public string Comentarios
        {
            get
            {
                return _comentarios;
            }
            set
            {
                _comentarios = value;
            }
        }
        public int Codigo_Cliente
        {
            get
            {
                return _codigoCliente;
            }
            set
            {
                _codigoCliente = value;
            }
        }

        public int CompareTo(Pedido other)
        {
            int valor;

            valor = DateTime.Compare(_fechaPedido, other._fechaPedido);

            return valor;
        }
    }
}
