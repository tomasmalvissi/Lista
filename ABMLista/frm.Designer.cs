namespace ABMLista
{
    partial class frm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAgregar = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOCarga = new System.Windows.Forms.Button();
            this.lblPorden = new System.Windows.Forms.Label();
            this.lblRepues = new System.Windows.Forms.Label();
            this.rbAlfab = new System.Windows.Forms.RadioButton();
            this.rbCarga = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(460, 23);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(128, 27);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(272, 20);
            this.s.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(34, 157);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 15);
            this.lbl.TabIndex = 4;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(460, 52);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(460, 80);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(129, 80);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(272, 20);
            this.txtNota.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOTA";
            // 
            // btnOCarga
            // 
            this.btnOCarga.Location = new System.Drawing.Point(460, 157);
            this.btnOCarga.Name = "btnOCarga";
            this.btnOCarga.Size = new System.Drawing.Size(75, 20);
            this.btnOCarga.TabIndex = 9;
            this.btnOCarga.Text = "Listar";
            this.btnOCarga.UseVisualStyleBackColor = true;
            this.btnOCarga.Click += new System.EventHandler(this.BtnOCarga_Click);
            // 
            // lblPorden
            // 
            this.lblPorden.AutoSize = true;
            this.lblPorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorden.ForeColor = System.Drawing.Color.White;
            this.lblPorden.Location = new System.Drawing.Point(200, 157);
            this.lblPorden.Name = "lblPorden";
            this.lblPorden.Size = new System.Drawing.Size(0, 15);
            this.lblPorden.TabIndex = 10;
            // 
            // lblRepues
            // 
            this.lblRepues.AutoSize = true;
            this.lblRepues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepues.ForeColor = System.Drawing.Color.White;
            this.lblRepues.Location = new System.Drawing.Point(128, 109);
            this.lblRepues.Name = "lblRepues";
            this.lblRepues.Size = new System.Drawing.Size(0, 15);
            this.lblRepues.TabIndex = 11;
            // 
            // rbAlfab
            // 
            this.rbAlfab.AutoSize = true;
            this.rbAlfab.ForeColor = System.Drawing.Color.White;
            this.rbAlfab.Location = new System.Drawing.Point(460, 109);
            this.rbAlfab.Name = "rbAlfab";
            this.rbAlfab.Size = new System.Drawing.Size(104, 17);
            this.rbAlfab.TabIndex = 12;
            this.rbAlfab.TabStop = true;
            this.rbAlfab.Text = "Orden Alfabetico";
            this.rbAlfab.UseVisualStyleBackColor = true;
            this.rbAlfab.CheckedChanged += new System.EventHandler(this.RbAlfab_CheckedChanged);
            // 
            // rbCarga
            // 
            this.rbCarga.AutoSize = true;
            this.rbCarga.ForeColor = System.Drawing.Color.White;
            this.rbCarga.Location = new System.Drawing.Point(460, 132);
            this.rbCarga.Name = "rbCarga";
            this.rbCarga.Size = new System.Drawing.Size(100, 17);
            this.rbCarga.TabIndex = 13;
            this.rbCarga.TabStop = true;
            this.rbCarga.Text = "Orden de Carga";
            this.rbCarga.UseVisualStyleBackColor = true;
            this.rbCarga.CheckedChanged += new System.EventHandler(this.RbCarga_CheckedChanged);
            // 
            // frm
            // 
            this.AcceptButton = this.btAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(569, 351);
            this.Controls.Add(this.rbCarga);
            this.Controls.Add(this.rbAlfab);
            this.Controls.Add(this.lblRepues);
            this.Controls.Add(this.lblPorden);
            this.Controls.Add(this.btnOCarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.s);
            this.Controls.Add(this.btAgregar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOCarga;
        private System.Windows.Forms.Label lblPorden;
        private System.Windows.Forms.Label lblRepues;
        private System.Windows.Forms.RadioButton rbAlfab;
        private System.Windows.Forms.RadioButton rbCarga;
    }
}

