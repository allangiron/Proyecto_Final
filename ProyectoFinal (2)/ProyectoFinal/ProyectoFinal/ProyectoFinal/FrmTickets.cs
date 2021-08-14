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
    public partial class FrmTickets : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmTickets()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            ticketdataGridView1.Columns.Add("cliente", "CLIENTE");
            ticketdataGridView1.Columns.Add("id cliente", "ID CLIENTE");
            ticketdataGridView1.Columns.Add("area", "AREA");
            ticketdataGridView1.Columns.Add("observacion", "OBSERVACION");

            ticketdataGridView1.Rows.Add(txt_cliente.Text,mtxt_identidad.Text, txt_area.Text, txt_observacion.Text);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_cliente.Clear();
            mtxt_identidad.Clear();
            txt_area.Clear();
            txt_observacion.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
