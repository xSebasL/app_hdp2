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
    public partial class frmRoll : Form
    {
        public frmRoll()
        {
            InitializeComponent();
        }

        private void frmRoll_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Actualizar();
        }

        private void Actualizar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnModificar.Enabled = false;
            gbFormulario.Enabled = true;
            dtgRoles.Rows.Clear();
            ClearData();
            RolesDB rolesDB = new RolesDB();
            List<Roll> roles = rolesDB.GetAll();
            foreach (Roll roll in roles)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgRoles);
                row.Cells[0].Value = roll.getId();
                row.Cells[1].Value = roll.getDescripcion();
                dtgRoles.Rows.Add(row);
            }
        }

        private void ClearData()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Roll newRoll = new Roll(1, txtDescripcion.Text);
            RolesDB rolesDB = new RolesDB();
            rolesDB.Add(newRoll);
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
            Roll newRoll = new Roll(int.Parse(txtId.Text), txtDescripcion.Text);
            RolesDB rolesDB = new RolesDB();
            rolesDB.Update(newRoll, int.Parse(txtId.Text));
            Actualizar();
            btnActualizar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RolesDB rolesDB = new RolesDB();
            rolesDB.Delete(int.Parse(txtId.Text));
            Actualizar();
        }

        private void dtgRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbFormulario.Enabled = false;
            txtId.Text = dtgRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescripcion.Text = dtgRoles.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
