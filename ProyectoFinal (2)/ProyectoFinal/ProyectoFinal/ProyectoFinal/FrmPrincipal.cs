using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmPrincipal : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        FrmUsuarios FormularioUsuario;
        FrmClientes formularioClientes;
        FrmTickets FomularioTickets;
        private void TSB_usuarios_Click(object sender, EventArgs e)
        {
            if (FormularioUsuario == null)
            {
                FormularioUsuario = new FrmUsuarios();
                FormularioUsuario.MdiParent = this;
                FormularioUsuario.FormClosed += Formulario_FormClosed;
                FormularioUsuario.Show();
            }
            else
            {
                FormularioUsuario.Activate();
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioUsuario = null;
        }

        private void TSB_clientes_Click(object sender, EventArgs e)
        {
            if(formularioClientes == null)
            {
                formularioClientes = new FrmClientes();
                formularioClientes.MdiParent = this;
                formularioClientes.FormClosed += Formulario1_FormClosed;
                formularioClientes.Show();
            }
            else
            {
                formularioClientes.Activate();
            }
            
        }

        private void Formulario1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioClientes = null;
        }

        
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            Application.Exit();

        }

        private void TSB_Tickets_Click(object sender, EventArgs e)
        {
            if (FomularioTickets == null)
            {
                FomularioTickets = new FrmTickets();
                FomularioTickets.MdiParent = this;
                FomularioTickets.FormClosed += Formulario_FormClosed;
                FomularioTickets.Show();
            }
            else
            {
                FomularioTickets.Activate();
            }
        }
    }
}
