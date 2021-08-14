
namespace ProyectoFinal
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cliente_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.imagen_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagen_button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxt_identidad = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.mtxt_telefono = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxt_identidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxt_telefono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(121, 54);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(196, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identidad:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(121, 137);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(196, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(61, 183);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(52, 13);
            this.Telefono.TabIndex = 6;
            this.Telefono.Text = "Telefono:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Location = new System.Drawing.Point(121, 227);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(196, 20);
            this.txt_direccion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección:";
            // 
            // cliente_dataGridView1
            // 
            this.cliente_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cliente_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_dataGridView1.Location = new System.Drawing.Point(64, 316);
            this.cliente_dataGridView1.Name = "cliente_dataGridView1";
            this.cliente_dataGridView1.Size = new System.Drawing.Size(555, 122);
            this.cliente_dataGridView1.TabIndex = 16;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(223, 274);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(385, 274);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(466, 274);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(141, 274);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 11;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(304, 274);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // imagen_pictureBox1
            // 
            this.imagen_pictureBox1.Location = new System.Drawing.Point(353, 54);
            this.imagen_pictureBox1.Name = "imagen_pictureBox1";
            this.imagen_pictureBox1.Size = new System.Drawing.Size(225, 193);
            this.imagen_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_pictureBox1.TabIndex = 10;
            this.imagen_pictureBox1.TabStop = false;
            // 
            // imagen_button1
            // 
            this.imagen_button1.Location = new System.Drawing.Point(584, 224);
            this.imagen_button1.Name = "imagen_button1";
            this.imagen_button1.Size = new System.Drawing.Size(75, 23);
            this.imagen_button1.TabIndex = 17;
            this.imagen_button1.Text = "Imagen...";
            this.imagen_button1.UseVisualStyleBackColor = true;
            this.imagen_button1.Click += new System.EventHandler(this.imagen_button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtxt_identidad
            // 
            this.mtxt_identidad.BeforeTouchSize = new System.Drawing.Size(196, 20);
            this.mtxt_identidad.Enabled = false;
            this.mtxt_identidad.Location = new System.Drawing.Point(121, 92);
            this.mtxt_identidad.Mask = "####-####-#####";
            this.mtxt_identidad.MaxLength = 15;
            this.mtxt_identidad.Name = "mtxt_identidad";
            this.mtxt_identidad.Size = new System.Drawing.Size(196, 20);
            this.mtxt_identidad.TabIndex = 18;
            // 
            // mtxt_telefono
            // 
            this.mtxt_telefono.BeforeTouchSize = new System.Drawing.Size(196, 20);
            this.mtxt_telefono.Enabled = false;
            this.mtxt_telefono.Location = new System.Drawing.Point(121, 176);
            this.mtxt_telefono.Mask = "####-####";
            this.mtxt_telefono.MaxLength = 9;
            this.mtxt_telefono.Name = "mtxt_telefono";
            this.mtxt_telefono.Size = new System.Drawing.Size(196, 20);
            this.mtxt_telefono.TabIndex = 19;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.mtxt_telefono);
            this.Controls.Add(this.mtxt_identidad);
            this.Controls.Add(this.imagen_button1);
            this.Controls.Add(this.cliente_dataGridView1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.imagen_pictureBox1);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = ".:Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxt_identidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxt_telefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imagen_pictureBox1;
        private System.Windows.Forms.DataGridView cliente_dataGridView1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button imagen_button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox mtxt_identidad;
        private Syncfusion.Windows.Forms.Tools.MaskedEditBox mtxt_telefono;
    }
}