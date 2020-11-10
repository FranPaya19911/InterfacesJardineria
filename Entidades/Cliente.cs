using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        
        private int _codigoCliente;
        private string _nombreCliente, _nombreContacto, _apellidoContacto,_telefono, _fax, _lineaDireccion1, _lineaDireccion2, _ciudad, _region, _pais, _codigoPostal;
        private int? _codigoEmpleadoRepVentas;
        private decimal? _limiteCredito;
        public Cliente()
        {
            _codigoCliente = 0;
            _nombreCliente = "";
            _nombreContacto = "";
            _apellidoContacto = "";
            _fax = "";
            _lineaDireccion1 = "";
            _lineaDireccion2 = "";
            _ciudad = "";
            _region = "";
            _pais = "";
            _codigoPostal = "";
            _codigoEmpleadoRepVentas = 0;
            _limiteCredito = 0;
        }
        public Cliente(int codigoCliente, string nombreCliente, string nombreContacto, string apellidoContacto, string telefono, string fax, string lineaDireccion1, string lineaDireccion2, string ciudad, string region, string pais, string codigoPostal, int? codigoEmpleadoRepVentas, decimal? limiteCredito)
        {
            _codigoCliente = codigoCliente;
            _nombreCliente = nombreCliente;
            _nombreContacto = nombreContacto;
            _apellidoContacto = apellidoContacto;
            _telefono = telefono;
            _fax = fax;
            _lineaDireccion1 = lineaDireccion1;
            _lineaDireccion2 = lineaDireccion2;
            _ciudad = ciudad;
            _region = region;
            _pais = pais;
            _codigoPostal = codigoPostal;
            _codigoEmpleadoRepVentas = codigoEmpleadoRepVentas;
            _limiteCredito = limiteCredito;
        }
        public Cliente(Cliente previousCliente)
        {
            _codigoCliente = previousCliente. _codigoCliente;
            _nombreCliente = previousCliente._nombreCliente;
            _nombreContacto = previousCliente._nombreContacto;
            _apellidoContacto = previousCliente._apellidoContacto;
            _telefono = previousCliente._telefono;
            _fax = previousCliente._fax;
            _lineaDireccion1 = previousCliente._lineaDireccion1;
            _lineaDireccion2 = previousCliente._lineaDireccion2;
            _ciudad = previousCliente._ciudad;
            _region = previousCliente._region;
            _pais = previousCliente._pais;
            _codigoPostal = previousCliente._codigoPostal;
            _codigoEmpleadoRepVentas = previousCliente._codigoEmpleadoRepVentas;
            _limiteCredito = previousCliente._limiteCredito;
        }
        ~Cliente()
        {
            _codigoCliente = 0;
            _nombreCliente = "";
            _nombreContacto = null;
            _apellidoContacto = null;
            _telefono = "";
            _fax = "";
            _lineaDireccion1 = "";
            _lineaDireccion2 = null;
            _ciudad = "";
            _region = null;
            _pais = null;
            _codigoPostal = null;
            _codigoEmpleadoRepVentas = null;
            _limiteCredito = null;
        }

        public override string ToString()
        {
            return _codigoCliente.ToString() + " # " + _nombreCliente + " # " + _nombreContacto + " # " + _apellidoContacto +"#" + _telefono + " # " + _fax + " # " + _lineaDireccion1 + " # " + _lineaDireccion2 + " # " + _ciudad + " # " + _region + " # " + _pais + " # " + _codigoPostal + " # " + _codigoEmpleadoRepVentas.ToString() + " # " + _limiteCredito.ToString();
        }

        public int Codigo_Cliente
        {
            get
            {
                return _codigoCliente;
            }
        }
        public string Nombre_Cliente
        {
            get
            {
                return _nombreCliente;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _nombreCliente = value;
            }
        }
        public string Nombre_Contacto
        {
            get
            {
                return _nombreContacto;
            }
            set
            {
                if (value.Length <= 30)
                    _nombreContacto = value;
            }
        }
        public string Apellido_Contacto
        {
            get
            {
                return _apellidoContacto;
            }
            set
            {
                if (value.Length <= 30)
                    _apellidoContacto = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                if (value.Length <= 15 && value != null)
                    _telefono = value;
            }
        }

        public string Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                if (value.Length <= 15 && value != null)
                    _fax = value;
            }
        }
        public string Linea_Direccion1
        {
            get
            {
                return _lineaDireccion1;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _lineaDireccion1 = value;
            }
        }
        public string Linea_Direccion2
        {
            get
            {
                return _lineaDireccion2;
            }
            set
            {
                if (value.Length <= 50)
                    _lineaDireccion2 = value;
            }
        }
        public string Ciudad
        {
            get
            {
                return _ciudad;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _ciudad = value;
            }
        }
        public string Region
        {
            get
            {
                return _region;
            }
            set
            {
                if (value.Length <= 50)
                    _region = value;
            }
        }
        public string Pais
        {
            get
            {
                return _pais;
            }
            set
            {
                if (value.Length <= 50)
                    _pais = value;
            }
        }
        public string Codigo_Postal
        {
            get
            {
                return _codigoPostal;
            }
            set
            {
                if (value.Length <= 10)
                    _codigoPostal = value;
            }
        }
        public int? Codigo_Empleado_Rep_Ventas
        {
            get
            {
                return _codigoEmpleadoRepVentas;
            }
            set
            {
                _codigoEmpleadoRepVentas = value;
            }
        }
        public decimal? Limite_Credito
        {
            get
            {
                return _limiteCredito;
            }
            set
            {
                if (value.ToString().Length <= 15)
                    _limiteCredito = value;
            }
        }

    }
}
