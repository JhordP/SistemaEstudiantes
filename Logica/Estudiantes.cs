using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Libreria;

namespace Logica
{
    public class Estudiantes : Library
    {
        private List<TextBox> listTxtBox;
        private List<Label> listLbl;
        private PictureBox cajaFoto;

        public Estudiantes(List<TextBox> listTxtBox, List<Label> listLbl, Object[] objetos)
        {
            this.listTxtBox = listTxtBox;
            this.listLbl = listLbl;
            cajaFoto = (PictureBox)objetos[0];
        }

        public void Registrar()
        {
              string textoAlerta;
              string tituloAlerta;
              int camposVacios = 0;

            foreach (var txtbox in listTxtBox)
            {
                if (txtbox.Text.Equals(string.Empty)) camposVacios += 1;
            }

            if (camposVacios == 0) agregarSuccess();
            else agregarFailed();

            
            void agregarSuccess()
            {
                if (txtEvent.validarEmail(listTxtBox[3].Text) == true) 
                { 

                    textoAlerta = "Registro completado satisfactoriamente.";
                    tituloAlerta = "Registro agregado";
                        MessageBox.Show(textoAlerta,tituloAlerta,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (var txt in listTxtBox)
                    {
                        txt.Clear();
                    }

                    //Invoco al metodo que convierte la imagen en un arreglo de bytes y almaceno el return en este var.
                    var fotoByte = uploadImage.imageToByte(cajaFoto.Image); 

                }

                else
                {
                    textoAlerta = "El formato del Email no es valido.";
                    tituloAlerta = "Email invalido.";
                    MessageBox.Show(textoAlerta,tituloAlerta,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            void agregarFailed()
            {
                for (int i = 0; i < listTxtBox.Count; i++)
                {
                    if (listTxtBox[i].Text.Equals(string.Empty))
                    {
                        textoAlerta = $"El campo {listLbl[i].Text} es requerido. No puede estar vacio.";
                        tituloAlerta = $"Campo {listLbl[i].Text} Vacio";
                        //listLbl[0].Text = "El campo ID es requerido.";
                        MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        listLbl[i].ForeColor = Color.Red;
                        listTxtBox[i].Focus();
                        break;
                    }
                }
            }
            


            /*
            if (listTxtBox[0].Text.Equals(string.Empty)) //Validando si la propiedad Text del index 0 esta vacia o ""
            {
                textoAlerta = "El campo ID es requerido. No puede estar vacio.";
                tituloAlerta = "Campo ID Vacio";
                //listLbl[0].Text = "El campo ID es requerido.";
                var alertaID = MessageBox.Show(textoAlerta,tituloAlerta,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                listLbl[0].ForeColor = Color.Red;
                listTxtBox[0].Focus();
            }

            else if (listTxtBox[1].Text.Equals(string.Empty))
            {
                textoAlerta = "El campo Nombre es requerido. No puede estar vacio.";
                tituloAlerta = "Campo Nombre Vacio";
                var alertaID = MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listLbl[1].ForeColor = Color.Red;
                listTxtBox[1].Focus();
            }

            else if (listTxtBox[2].Text.Equals(string.Empty))
            {
                textoAlerta = "El campo Apellido es requerido. No puede estar vacio.";
                tituloAlerta = "Campo Apellido Vacio";
                var alertaID = MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listLbl[2].ForeColor = Color.Red;
                listTxtBox[2].Focus();
            }

            else if (listTxtBox[3].Text.Equals(string.Empty))
            {
                textoAlerta = "El campo Correo es requerido. No puede estar vacio.";
                tituloAlerta = "Campo Correo Vacio";
                var alertaID = MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listLbl[3].ForeColor = Color.Red;
                listTxtBox[3].Focus();
            }
            */

        }
    }
    
}
