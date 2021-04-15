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
    public partial class Registro : Form
    {
        private UserServices userServices;
        private User user;
        public Registro()
        {
            user = new User();
            userServices = new UserServices();
            InitializeComponent();
        }
        private void addUser(string Name, string LastName, string User, string Password, string Password_Confirm)
        {
            if (Password == Password_Confirm)
            {
                bool result = userServices.GetUser(User, false);

                if (!result) 
                { 
                    user.Nombre = Name;
                    user.Apellido = LastName;
                    user.Usuario = User;
                    user.Contraseña = Password;
                    userServices.Add(user);
                    MessageBox.Show("Usuario agregado satisfactoriamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario no disponible");
                }

                
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
        private void btnNC_Click(object sender, EventArgs e)
        {
            addUser(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContra.Text, txtConContra.Text);
        }
    }
}
