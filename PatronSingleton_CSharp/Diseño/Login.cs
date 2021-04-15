using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class Login : Form
    {
        private UserServices userServices;
        public Login()
        {
            userServices = new UserServices();
            InitializeComponent();
        }
        #region Logeo
        private void Loguear(string User, string Password)
        {
            bool state = userServices.GetUser(User ,true ,Password);
            if (state)
            {
                UserRepository.Instancia.User = User;
                Principal fm = new Principal();
                fm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("El nombre de usuario y/o contraseña son incorrectos");
            }
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Loguear(txtUser.Text, txtPassword.Text);
            }
            catch{
                MessageBox.Show("El usuario y/o contraseña son incorrectos");
            }
                
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }
    }
}
