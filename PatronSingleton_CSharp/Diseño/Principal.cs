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
    public partial class Principal : Form
    {
        private PersonServices personServices;
        int index;
        public Principal()
        {
            personServices = new PersonServices();
            index = -1;
            InitializeComponent();
        }
        private void Clear()
        {
            txtApellido.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTel.Clear();
            txtTelLaboral.Clear();
            dgv.ClearSelection();
            index = -1;
        }
        #region CRUDMETHODES
        private void Add()
        {
            Person person = new Person();
            person.Nombre = txtNombre.Text;
            person.Apellido = txtApellido.Text;
            person.Direccion = txtDireccion.Text;
            person.Telefono_Personal = txtTel.Text;
            person.Telefono_Trabajo = txtTelLaboral.Text;
            personServices.Add(person);
            GetAll();
            Clear();
        }
        private void GetAll()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = personServices.GetAll();
            dgv.DataSource = bindingSource;
            dgv.ClearSelection();
        }
        private void Update()
        {
            Person person = new Person();
            person.Nombre = txtNombre.Text;
            person.Apellido = txtApellido.Text;
            person.Direccion = txtDireccion.Text;
            person.Telefono_Personal = txtTel.Text;
            person.Telefono_Trabajo = txtTelLaboral.Text;
            personServices.Edit(index, person);
            GetAll();
            Clear();
        }

        private void Delete()
        {
            if (index < 0)
                MessageBox.Show("Debe seleccionar el registro que desea eliminar");
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Esta seguro que desea eliminar este registro?","Atencion",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    personServices.Delete(index);
                    GetAll();
                    Clear();
            }
            
            
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < 0)
                    Add();
                else
                    Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe llenar todos los campos correctamente" + ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtNombre.Text = dgv.Rows[index].Cells[0].Value.ToString();
            txtApellido.Text = dgv.Rows[index].Cells[1].Value.ToString();
            txtDireccion.Text = dgv.Rows[index].Cells[2].Value.ToString();
            txtTel.Text = dgv.Rows[index].Cells[3].Value.ToString();
            txtTelLaboral.Text = dgv.Rows[index].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seguro que desea cerrar la sesion?", "Atencion", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
                Clear();
                dgv.DataSource = null;
                UserRepository.Instancia.User = "";
                PersonRepository.Instancia.Person.Clear();
            }
        }
    }
}
