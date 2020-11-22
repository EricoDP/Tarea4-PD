using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patronsingleton_CSharp
{
    public partial class MantenimientoCategoria : Form
    {
        int posY = 0;
        int posX = 0;
        int id = 0;
        AdministrarCategoria ACategoria = AdministrarCategoria.getInstancia();

        public MantenimientoCategoria()
        {
            InitializeComponent();
        }

        //Funcion Load
        private void MantenimientoCategoria_Load(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        //Botones de Funciones del Crud
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (nombre != "Nombre")
            {
                try
                {
                    if (ACategoria.AgregarRegistro(nombre))
                    {
                        MessageBox.Show("El registro se guardo de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            { MessageBox.Show("Debe ingresar un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "ID")
            {
                id = Convert.ToInt32(txtId.Text);

                try
                {
                    ArrayList datos = ACategoria.BuscarRegistro(id);

                    if (datos.Count > 0)
                    {
                        txtNombre.Text = (string)datos[1];
                        if ((bool)datos[2] == true) { rdbActivo.Checked = true; }
                        else { rdbInactivo.Checked = true; }
                        btnAgregar.Visible = false;
                        grpEstado.Enabled = true;
                        txtId.ForeColor = Color.Black;
                        txtNombre.ForeColor = Color.Black;
                        btnBuscar.Height = 82;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtId.Text = "ID";
                        txtId.ForeColor = Color.Silver;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Debe ingresar un ID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            bool estado = true;
            if (rdbActivo.Checked == true) { estado = true; }
            else { estado = false; }

            if (nombre != "Nombre")
            {
                try
                {
                    if (ACategoria.ModificarRegistro(id, nombre, estado))
                    {
                        MessageBox.Show("El registro se edito de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ACategoria.EliminarRegistro(id))
                {
                    MessageBox.Show("El registro se elimino de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Botones y funciones del Formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MoverFormulario(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        public void LimpiarForm()
        {
            txtId.Text = "ID";
            txtId.ForeColor = Color.Silver;

            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Silver;

            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
            btnAgregar.Visible = true;
            grpEstado.Enabled = false;
            btnBuscar.Height = 123;
        }

        //Funciones de formato de los elementos
        private void txtId_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.SelectAll();
        }
        private void txtId_Enter(object sender, EventArgs e)
        {
            txtId.SelectAll();
        }
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Silver;
            }
            else if (txtId.Text != "ID")
            { txtId.ForeColor = Color.Black; }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtId.Text;
            if (texto.Contains("D") || texto.Contains("I"))
            {
                txtId.Text = texto.Replace("D", "").Replace("I", "");
            }
            if (Char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtId.Text != "ID") { txtId.ForeColor = Color.Black; }
            if (e.KeyCode == Keys.Enter)
            { txtNombre.Focus(); }
        }
        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.SelectAll();
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
            else if (txtNombre.Text != "Nombre")
            { txtNombre.ForeColor = Color.Black; }
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.SelectAll();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtNombre.Text;
            if (texto.Contains("Nombre"))
            {
                txtNombre.Text = texto.Replace("Nombre", "");
            }
            if (txtNombre.Text != "Nombre") { txtNombre.ForeColor = Color.Black; }
        }
    }
}
