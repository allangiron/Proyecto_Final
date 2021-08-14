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
    public partial class FrmClientes : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        BaseDatos bd = new BaseDatos();
        string operacion = string.Empty;

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            cliente_dataGridView1.DataSource = bd.SeleccionarClientes();
        }

        private void imagen_button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagen_pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void HabilitarControles()
        {
            txt_id.Enabled = true; 
            mtxt_identidad.Enabled = true;
            txt_nombre.Enabled = true;
            mtxt_telefono.Enabled = true;
            txt_direccion.Enabled = true;

            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_nuevo.Enabled = false;
        }

        private void DesabilitarControles()
        {
            txt_id.Enabled = true;
            mtxt_identidad.Enabled = false;
            txt_nombre.Enabled = false;
            mtxt_telefono.Enabled = false;
            txt_direccion.Enabled = false;

            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_nuevo.Enabled = true;
        }
        private void LimpiarControles()
        {
            mtxt_identidad.Clear();
            txt_nombre.Clear();
            mtxt_telefono.Clear();
            txt_direccion.Clear();
            imagen_pictureBox1.Image = null;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxt_identidad.Text))
            {
                errorProvider1.SetError(mtxt_identidad, "Campo obligatorio, Debe ingresar una identidad");
                mtxt_identidad.Focus();
                return;
            }

            if (txt_nombre.Text == "")
            {
                errorProvider1.SetError(txt_nombre, "Campo obligatorio, Debe ingresar un nombre");
                txt_nombre.Focus();
                return;
            }


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagen_pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            if (operacion == "Nuevo")
            {
                try
                {
                    bool inserto = bd.InsertarClientes(mtxt_identidad.Text, txt_nombre.Text, Convert.ToInt32(mtxt_telefono.Text), txt_direccion.Text, ms.GetBuffer());
                    if (inserto)
                    {
                        ListarClientes();
                        DesabilitarControles();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el nuevo cliente");
                    }
                }
                catch (Exception)
                {
                }
            }
            else if (operacion == "Modificar")
            {

            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (cliente_dataGridView1.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                HabilitarControles();

                txt_id.Text = cliente_dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                mtxt_identidad.Text = cliente_dataGridView1.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                txt_nombre.Text = cliente_dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                mtxt_telefono.Text = cliente_dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txt_direccion.Text = cliente_dataGridView1.CurrentRow.Cells["DIRECCION"].Value.ToString();

                var temporal = bd.SeleccionarImagenCliente(Convert.ToInt32(cliente_dataGridView1.CurrentRow.Cells["ID"].Value.ToString()));

                if (temporal.Length > 0)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(temporal);
                    imagen_pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente_dataGridView1.SelectedRows.Count > 0)
                {
                    bool elimino = bd.EliminarCliente(Convert.ToInt32(cliente_dataGridView1.CurrentRow.Cells["ID"].Value.ToString()));

                    if (elimino)
                    {
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error, al eliminar el cliente");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error, al eliminar el cliente");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
