using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class UploadImage
    {
        private OpenFileDialog ventanaFoto = new OpenFileDialog();

        public void subirFoto (PictureBox foto)
        {
            foto.WaitOnLoad = true; //No permite usar la UI hasta que la imagen es cargada.
            string filtro = "Imágenes|*.jpg;*.png;*.svg;*.bmp"; //Establece el filtro de la ventana

            ventanaFoto.Filter = filtro; //Asigna el filtro a la ventana
            
            ventanaFoto.ShowDialog(); //Muestra la ventana sin permitir hacer click fuera de ella.

            //Si el nombre del archivo no esta vacio, asigna el URL del nombre de la imagen a la URL del pictureBox
            if (ventanaFoto.FileName != string.Empty) foto.ImageLocation = ventanaFoto.FileName;

        }

        public byte[] imageToByte(Image image) 
        {
            var imgConverter = new ImageConverter();
            return (byte[])imgConverter.ConvertTo(image, typeof(byte[]));
        }
    }
}
