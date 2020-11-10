using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gama_producto
    {
        private string _gama, _descripcionTexto, _descripcionHtml, _imagen;

        public Gama_producto()
        {
            _gama = "";
            _descripcionTexto = "";
            _descripcionHtml = "";
            _imagen = "";
        }

        public Gama_producto(string gama, string descripcionTexto, string descripcionHtml, string imagen)
        {
            _gama = gama;
            _descripcionTexto = descripcionTexto;
            _descripcionHtml = descripcionHtml;
            _imagen = imagen;
        }

        public Gama_producto(Gama_producto previousGamaProducto)
        {
            _gama = previousGamaProducto._gama;
            _descripcionTexto = previousGamaProducto._descripcionTexto;
            _descripcionHtml = previousGamaProducto._descripcionHtml;
            _imagen = previousGamaProducto._imagen;
        }

        ~Gama_producto()
        {
            _gama = "";
            _descripcionTexto = null;
            _descripcionHtml = null;
            _imagen = null;
        }

        public override string ToString()
        {
            return _gama + " # " + _descripcionTexto + " # " + _descripcionHtml + " # " + _imagen;
        }

        public string Gama
        {
            get
            {
                return _gama;
            }
            set
            {
                if (value.Length <= 50 && value != null)
                    _gama = value;
            }
        }
        public string Descripcion_Texto
        {
            get
            {
                return _descripcionTexto;
            }
            set
            {
                _descripcionTexto = value;
            }
        }
        public string Descripcion_Html
        {
            get
            {
                return _descripcionHtml;
            }
            set
            {
                _descripcionHtml = value;
            }
        }
        public string Imagen
        {
            get
            {
                return _imagen;
            }
            set
            {
                if (value.Length <= 256 && value != null)
                    _imagen = value;
            }
        }
    }
}
