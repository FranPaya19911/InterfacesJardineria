using Capa_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioLogin
    {
        
        public void PruebaInicial(string user, string pass)
        {
            EmpleadoADO empleado = new EmpleadoADO();
            List<Empleado> listaEmpleados = empleado.LeerEmpleados();
            bool comprobacion=false;
            int codigo = listaEmpleados.Count + 1;
            if (listaEmpleados.Exists(x => x.Nombre == user && x.Pass == pass) == false)
            {
                comprobacion = empleado.InsertarEmpleado(codigo,user, "admin", null, "admin", "admin@damin", "55",-1 , null, pass);
            }
            
            Debug.WriteLine(comprobacion);
        }
    }
}
