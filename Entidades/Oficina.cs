using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina
    {
        private string _codigoOficina, _ciudad, _pais, _region, _codigoPostal, _telefono, _lineaDireccion1, _lineaDireccion2;
                
        public Oficina()
        {
            _codigoOficina = "";
            _ciudad = "";
            _pais = "";
            _region = "";
            _codigoPostal = "";
            _telefono = "";
            _lineaDireccion1 = "";
            _lineaDireccion2 = "";
        }

        public Oficina(string codigoOficina, string ciudad, string pais, string region, string codigoPostal, string telefono, string lineaDireccion1, string lineaDireccion2)
        {
            _codigoOficina = codigoOficina;
            _ciudad = ciudad;
            _pais = pais;
            _region = region;
            _codigoPostal = codigoPostal;
            _telefono = telefono;
            _lineaDireccion1 = lineaDireccion1;
            _lineaDireccion2 = lineaDireccion2;
        }

        public Oficina(Oficina previousOficina)
        {
            _codigoOficina = previousOficina._codigoOficina;
            _ciudad = previousOficina._ciudad;
            _pais = previousOficina._pais;
            _region = previousOficina._region;
            _codigoPostal = previousOficina._codigoPostal;
            _telefono = previousOficina._telefono;
            _lineaDireccion1 = previousOficina._lineaDireccion1;
            _lineaDireccion2 = previousOficina._lineaDireccion2;
        }
        ~Oficina()
        {
            _codigoOficina = "";
            _ciudad = "";
            _pais = "";
            _region = null;
            _codigoPostal = "";
            _telefono = "";
            _lineaDireccion1 = "";
            _lineaDireccion2 = null;
        }

        public override string ToString()
        {
            return _codigoOficina + " # " + _ciudad + " # " + _pais + " # " + _region + " # " + _codigoPostal + " # " + _telefono + " # " + _lineaDireccion1 + " # " + _lineaDireccion2;
        }

        public string Codigo_Oficina
        {
            get
            {
                return _codigoOficina;
            }
            set
            {
                if (value.Length <= 10 && value != null)
                    _codigoOficina = value;
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
                if (value.Length <= 30 && value != null)
                    _ciudad = value;
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
                if (value.Length <= 50 && value != null)
                    _pais = value;
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
        public string Codigo_Postal
        {
            get
            {
                return _codigoPostal;
            }
            set
            {
                if (value.Length <= 10 && value != null)
                    _codigoPostal = value;
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
                if (value.Length <= 20 && value != null)
                    _telefono = value;
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

    }
}
