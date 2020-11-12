using Entidades;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Http;
using System.Runtime.InteropServices;


namespace Capa_Datos
{
    public class EmpleadoADO: ADO
    {
        public List<Empleado> LeerEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/empleados").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaEmpleados;
        }


        //retocar
        public bool InsertarEmpleado(int codigoEmpleado,string nombre, string apellido1, string apellido2, string extension, string email, string codigoOficina, int codigoJeje, string puesto, string pass)
        {
            try
            {
                Empleado empleado = new Empleado(codigoEmpleado ,nombre, apellido1, apellido2, extension, email, codigoOficina, codigoJeje, puesto, pass);

                var response = client.PostAsync("api/empleados", new StringContent(JsonConvert.SerializeObject(empleado),
                        Encoding.UTF8, "application/json")).Result;

                // El objeto retornado lo podemos obtener con JsonConvert.DeserializeObject<Pago>(response.Content.ReadAsStringAsync().Result

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
                return false;
            }
        }
    }
}
