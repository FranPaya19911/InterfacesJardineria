using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
// Para contactar con la WEB API
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;

namespace Capa_Datos
{
    public class ProductosADO: ADO
    {
        public Producto ListarDetallePedido(string id)
        {
            Producto Produto = new Producto();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/productos/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    Produto = JsonConvert.DeserializeObject<Producto>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return Produto;
        }
    }
}
