using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        private int _codigoCliente;
        private string _formaPago, _idTransaccion;
        private DateTime _fechaPago;
        private decimal _total;

        public Pago()
        {
            _codigoCliente = 0;
            _formaPago = "";
            _idTransaccion = "";
            _fechaPago = DateTime.Now;
            _total = 0;
        }

        public Pago(int codigoCliente, string formaPago, string idTransaccion, DateTime fechaPago, decimal total)
        {
            _codigoCliente = codigoCliente;
            _formaPago = formaPago;
            _idTransaccion =idTransaccion;
            _fechaPago = fechaPago;
            _total = total;
        }

        //Copia
        public Pago(Pago previousPago)
        {
            _codigoCliente = previousPago._codigoCliente;
            _formaPago = previousPago._formaPago;
            _idTransaccion = previousPago._idTransaccion;
            _fechaPago = previousPago._fechaPago;
            _total = previousPago._total;
        }

        // Destructor
        ~Pago()
        {
            _codigoCliente = 0;
            _formaPago = "";
            _idTransaccion = "";
            _fechaPago = DateTime.Now;
            _total = 0;
        }

        public override string ToString()
        {
            return _codigoCliente.ToString() + " # " + _formaPago + " # " + _idTransaccion + " # " + _fechaPago.ToString() + " # " + _total.ToString();
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
        public string Forma_pago
        {
            get
            {
                return _formaPago;
            }
            set
            {
                if (value.Length <= 40 && value != null)
                    _formaPago = value;
            }
        }
        public string Id_Transaccion
        {
            get
            {
                return _idTransaccion;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _idTransaccion = value;
            }
        }
        public DateTime Fecha_Pago
        {
            get
            {
                return _fechaPago;
            }
            set
            {
                _fechaPago = value;
            }
        }
        public decimal Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (value.ToString().Length <= 15)
                    _total = value;
            }
        }
    }
}
