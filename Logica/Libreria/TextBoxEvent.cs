using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class TextBoxEvent
    {
        public void txtKeyPressRESTRICCION_LETRAS(KeyPressEventArgs datoInsertado)
        {
            //Si es una letra la el dato insertado de tecla presionada, entonces la propiedad Handled es falsa.
            if (char.IsLetter(datoInsertado.KeyChar)) datoInsertado.Handled = false;

            //Condicion que no permite salto de linea cuando se oprime Enter.
            else if (datoInsertado.KeyChar == Convert.ToChar(Keys.Enter)) { datoInsertado.Handled = true; }

            //Condicion que permite utilizar la tecla BackSpace
            else if (char.IsControl(datoInsertado.KeyChar)) datoInsertado.Handled = false;

            //Condicion que permite utilizar la tecla espacio
            else if (char.IsSeparator(datoInsertado.KeyChar)) datoInsertado.Handled = false;

            //Todo lo demas, es ignorado
            else { datoInsertado.Handled = true; }

            //**NOTA: La propiedad Handled valida si es ignorada la operacion del evento.

        }

        public void txtKeyPressRESTRICCION_NUMEROS(KeyPressEventArgs datoInsertado)
        {
            if (char.IsDigit(datoInsertado.KeyChar)) datoInsertado.Handled = false;

            //Condicion que no permite salto de linea cuando se oprime Enter.
            else if (datoInsertado.KeyChar == Convert.ToChar(Keys.Enter)) { datoInsertado.Handled = true; }

            //Condicion que permite utilizar la tecla BackSpace
            else if (char.IsControl(datoInsertado.KeyChar)) datoInsertado.Handled = false;

            //Todo lo demas, es ignorado
            else { datoInsertado.Handled = true; }
        }

        public bool validarEmail(string email) //Metodo que verifica si el formato digitado del email es valido
        {
            return new EmailAddressAttribute().IsValid(email);
        }


    }
}
