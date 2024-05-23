using app_hdp2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_hdp2
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnModificar.Enabled = false;
            gbFormulario.Enabled = true;
            dtgUsuarios.Rows.Clear();
            ClearData();
            UsuariosDB usuariosDB = new UsuariosDB();
            List<Usuario> usuarios = usuariosDB.GetAll();
            foreach (Usuario user in usuarios)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgUsuarios);
                row.Cells[0].Value = user.getId();
                row.Cells[1].Value = user.getUsuario();
                row.Cells[2].Value = user.getClave();
                row.Cells[3].Value = user.getNombre();
                row.Cells[4].Value = user.getApellido();
                row.Cells[5].Value = user.getRoll();
                dtgUsuarios.Rows.Add(row);
            }
        }

        private void ClearData()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtRoll.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuariosDB usuariosDB = new UsuariosDB();
            usuariosDB.Delete(int.Parse(txtId.Text));
            Actualizar();
        }


        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = false;
            gbFormulario.Enabled = false;
            txtId.Text = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dtgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtClave.Text = dtgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNombre.Text = dtgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtApellido.Text = dtgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRoll.Text = dtgUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario newUser = new Usuario(int.Parse(txtId.Text),txtUsuario.Text,txtClave.Text,txtNombre.Text,txtApellido.Text,int.Parse(txtRoll.Text));
            UsuariosDB usuariosDB = new UsuariosDB();
            usuariosDB.Add(newUser);
            Actualizar();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            gbFormulario.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuario newUser = new Usuario(int.Parse(txtId.Text), txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, int.Parse(txtRoll.Text));
            UsuariosDB usuariosDB = new UsuariosDB();
            usuariosDB.Update(newUser, int.Parse(txtId.Text));
            Actualizar();
            btnActualizar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
