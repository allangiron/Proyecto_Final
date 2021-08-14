using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmUsuarios : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private string operacion = string.Empty;

        BaseDatos bd = new BaseDatos();

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();

        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

            ListarUsuarios();
        }

        private void HabilitarControles()
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            txt_contraseña.Enabled = true;
            chb_estado.Enabled = true;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

            btn_modificar.Enabled = false;
            btn_nuevo.Enabled = false;
        }


        private void DesabilitarControles()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_contraseña.Enabled = false;
            chb_estado.Enabled = false;

            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;

            btn_modificar.Enabled = true;
            btn_nuevo.Enabled = true;
        }

        private void LimpiarControles()
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_contraseña.Clear();
            chb_estado.Checked = false;
        }

        private void ListarUsuarios()
        {
            dataGridView1.DataSource = bd.SeleccionarUsuarios();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                bool inserto = bd.InsertarUsuario(txt_codigo.Text, txt_nombre.Text, txt_contraseña.Text);
                ListarUsuarios();
                LimpiarControles();
            }
            else if (operacion == "Modificar")
            {
                bool edito = bd.EditarUsuario(txt_codigo.Text, txt_nombre.Text, txt_contraseña.Text, chb_estado.Checked);
                ListarUsuarios();
                LimpiarControles();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_codigo.Text = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
                txt_nombre.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txt_contraseña.Text = dataGridView1.CurrentRow.Cells["CLAVE"].Value.ToString();
                chb_estado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["ESTAACTIVO"].Value);
                ListarUsuarios();
                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = bd.EliminarUsuario(dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString());
                ListarUsuarios();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }

}
