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
        private OpenFileDialog files = new OpenFileDialog();

        public void subirFoto (PictureBox foto)
        {
            foto.WaitOnLoad = true; //No permite usar la UI hasta que la imagen es cargada.
            string filtro = "Imágenes|*.jpg;*.png;*.svg;*.bmp"; //Establece el filtro de la ventana

            files.Filter = filtro; //Asigna el filtro a la ventana
            
            files.ShowDialog(); //Muestra la ventana sin permitir hacer click fuera de ella.

            //Si el nombre del archivo no esta vacio, asigna el URL del nombre de la imagen a la URL del pictureBox
            if (files.FileName != string.Empty) foto.ImageLocation = files.FileName;

        }
        /* //Metodos completos de Conversion byte[]/Image
        
        public byte[] imageToByte(Image image) 
        {
            var imgConverter = new ImageConverter();
            var bytedImage = (byte[])imgConverter.ConvertTo(image, typeof(byte[]));
            return bytedImage;
        }
        public Image byteToImage(byte[] fotobyte)
        {
            var imgConverter = new ImageConverter();
            var Imagedbyte = (Image)imgConverter.ConvertFrom(fotobyte);
            return Imagedbyte;
        }
        */

        //Metodos cortos de Conversion byte[]/Image
        public byte[] imageToByte(Image image) => (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));

        public Image byteToImage(byte[] fotobyte) => (Image)new ImageConverter().ConvertFrom(fotobyte);
    }
}
