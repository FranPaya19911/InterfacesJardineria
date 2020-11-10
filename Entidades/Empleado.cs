using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private int _codigoEmpleado, _codigoJefe; 
        private string _nombre, _apellido1, _apellido2, _extension, _email, _codigoOficina, _puesto, _nombreCompleto;

        public Empleado()
        {
            _codigoEmpleado = 0;
            _nombre = "";
            _apellido1 = "";
            _apellido2 = "";
            _extension = "";
            _email = "";
            _codigoOficina = "";
           _codigoJefe = 0;
            _puesto = "";
        }
        public Empleado(int codigoEmpleado, string nombre, string apellido1, string apellido2, string extension, string email, string codigoOficina, int codigoJeje, string puesto)
        {
            _codigoEmpleado = codigoEmpleado;
            _nombre = nombre;
            _apellido1 = apellido1;
            _apellido2 = apellido2;
            _extension = extension;
            _email = email;
            _codigoOficina = codigoOficina;
           _codigoJefe = codigoJeje;
            _puesto = puesto;
        }
        public Empleado(Empleado previousEmpleado)
        {
            _codigoEmpleado = previousEmpleado._codigoEmpleado;
            _nombre = previousEmpleado._nombre;
            _apellido1 = previousEmpleado._apellido1;
            _apellido2 = previousEmpleado._apellido2;
            _extension = previousEmpleado._extension;
            _email = previousEmpleado._email;
            _codigoOficina = previousEmpleado._codigoOficina;
           _codigoJefe = previousEmpleado._codigoJefe;
            _puesto = previousEmpleado._puesto;
        }
        ~Empleado()
        {
            _codigoEmpleado = 0;
            _nombre = "";
            _apellido1 = "";
            _apellido2 = null;
            _extension = "";
            _email = "";
            _codigoOficina = "";
           _codigoJefe = 0;
            _puesto = "";
        }

        public override string ToString()
        {
            return _codigoEmpleado.ToString() + " # " + _nombre + " # " + _apellido1 + " # " + _apellido2 + " # " + _extension + " # " + _email + " # " + _codigoOficina + " # " + _codigoJefe.ToString() + " # " + _puesto;
        }

        public int Codigo_Empleado
        {
            get
            {
                return _codigoEmpleado;
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
                if(value.Length <= 50 && value != null)
                    _nombre = value;
                
            }
        }
        public string Apellido1
        {
            get
            {
                return _apellido1;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _apellido1 = value;

                
            }
        }
        public string Apellido2
        {
            get
            {
                return _apellido2;
            }
            set
            {
                if (value.Length <= 50)
                    _apellido2 = value;
            }
        }
        public string Extension
        {
            get
            {
                return _extension;
            }
            set
            {
                if (value.Length <= 10 && value != null)
                    _extension = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length <= 100 && value != null)
                    _email = value;
            }
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
        public int Codigo_Jefe
        {
            get
            {
                return _codigoJefe;
            }
            set
            {
                if (value.ToString().Length <= 50)
                    _codigoJefe = value;
            }
        }
        public string Puesto
        {
            get
            {
                return _puesto;
            }
            set
            {
                if (value.Length <= 50)
                    _puesto = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                if(_apellido2 == null)
                {
                    return _nombreCompleto = _nombre + " " + _apellido1;
                }
                else
                {
                    return _nombreCompleto = _nombre + " " + _apellido1 + " " + _apellido2;
                }
                
            }
        }
    }
}
