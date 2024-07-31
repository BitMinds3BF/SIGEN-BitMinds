using SIGEN_BitMinds.Aplication.Ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    internal class Controlador
    {
        public static Controlador instance;

        public Login ventana {  get; set; }

        public static Controlador Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controlador();
                }
                return instance;
            }
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "btnLogin":
                        break;

                    default:
                        MessageBox.Show("¡Botón desconocido ha sido presionado!");
                        break;
                }
            }
        }

        public void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Texto Ingresado :: ");
            }
        }
    }
}
