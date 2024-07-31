using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controler;



namespace SIGEN_BitMinds.Aplication.Ventanas
{
    public partial class Login : Form
    {

        public static Login instance;


        private Login()
        {
            InitializeComponent();

            Controlador controlador = Controlador.Instance;
            controlador.ventana = this;

            btnLogin.Click += new EventHandler(controlador.OnButtonClick);
            txtUsuario.KeyPress += new KeyPressEventHandler(controlador.OnKeyPress);
        }

        public static Login Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
