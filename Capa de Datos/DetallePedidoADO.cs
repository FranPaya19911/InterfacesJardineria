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
    public class DetallePedidoADO: ADO
    {
        public List<Detalle_pedido> ListarDetallePedido(int id)
        {
            List<Detalle_pedido> listarProductos = new List<Detalle_pedido>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/detalle_pedido/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listarProductos = JsonConvert.DeserializeObject<List<Detalle_pedido>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listarProductos;
        }
    }
}
