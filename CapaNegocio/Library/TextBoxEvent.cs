using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Library
{
    public class TextBoxEvent
    {
        public void SoloTextoSinSaltoNiEspacio(KeyPressEventArgs e)// solo letras de la A a la Z nada más
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; } // con false se permite números
            //condición que solo permite ingresat datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = false; } // con false se permite textos
            //condición que no permite dar saltos de línea al oprimir enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; } //con true se niega
            //Condición que nos permite utilizar la tecla backspace (flecha para borrar)
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condición que permite o niega el uso de tecla espaciadora
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            //permite que acepte puntuación
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }

        }

        public void SoloNumerosSinEspacios(KeyPressEventArgs e)
        {
            //condición que solo permite ingresat datos de tipo númerico
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; } // con false se permite
            //condición que no permite dar saltos de línea al oprimir enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; } //con true se niega
            //condición que NO ingresat datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; } // con true no permite
            //Condición que nos permite utilizar la tecla backspace (flecha para borrar)
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condición que permite o niega el uso de tecla espaciadora
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }// ya no puede ocupar tecla separadora
            else { e.Handled = true; }
        }

        public bool ComprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        public void ComprobarFormatoEmail(KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
