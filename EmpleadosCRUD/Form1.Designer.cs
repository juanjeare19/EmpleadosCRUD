
namespace EmpleadosCRUD
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butActualizar = new System.Windows.Forms.Button();
            this.butBuscar = new System.Windows.Forms.Button();
            this.butGuardar = new System.Windows.Forms.Button();
            this.dateTimeNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textDir = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textApe = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butReiniciar = new System.Windows.Forms.Button();
            this.butConsulta = new System.Windows.Forms.Button();
            this.textConsulta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butLimpiar);
            this.tabPage1.Controls.Add(this.butEliminar);
            this.tabPage1.Controls.Add(this.butActualizar);
            this.tabPage1.Controls.Add(this.butBuscar);
            this.tabPage1.Controls.Add(this.butGuardar);
            this.tabPage1.Controls.Add(this.dateTimeNac);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textDir);
            this.tabPage1.Controls.Add(this.textEdad);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textApe);
            this.tabPage1.Controls.Add(this.textNom);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butLimpiar
            // 
            this.butLimpiar.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLimpiar.Location = new System.Drawing.Point(488, 246);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 17;
            this.butLimpiar.Text = "LIMPIAR";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar.Location = new System.Drawing.Point(407, 246);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(75, 23);
            this.butEliminar.TabIndex = 16;
            this.butEliminar.Text = "ELIMINAR";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butActualizar
            // 
            this.butActualizar.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butActualizar.Location = new System.Drawing.Point(314, 246);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(87, 23);
            this.butActualizar.TabIndex = 15;
            this.butActualizar.Text = "ACTUALIZAR";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // butBuscar
            // 
            this.butBuscar.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBuscar.Location = new System.Drawing.Point(233, 246);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(75, 23);
            this.butBuscar.TabIndex = 14;
            this.butBuscar.Text = "BUSCAR";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // butGuardar
            // 
            this.butGuardar.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGuardar.Location = new System.Drawing.Point(152, 246);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(75, 23);
            this.butGuardar.TabIndex = 13;
            this.butGuardar.Text = "GUARDAR";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // dateTimeNac
            // 
            this.dateTimeNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNac.Location = new System.Drawing.Point(349, 187);
            this.dateTimeNac.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.dateTimeNac.Name = "dateTimeNac";
            this.dateTimeNac.Size = new System.Drawing.Size(96, 20);
            this.dateTimeNac.TabIndex = 12;
            this.dateTimeNac.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(436, 144);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(100, 20);
            this.textDir.TabIndex = 10;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(235, 144);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(55, 20);
            this.textEdad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Edad:";
            // 
            // textApe
            // 
            this.textApe.Location = new System.Drawing.Point(436, 102);
            this.textApe.Name = "textApe";
            this.textApe.Size = new System.Drawing.Size(100, 20);
            this.textApe.TabIndex = 6;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(235, 102);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres: ";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(305, 63);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butReiniciar);
            this.tabPage2.Controls.Add(this.butConsulta);
            this.tabPage2.Controls.Add(this.textConsulta);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resgistro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butReiniciar
            // 
            this.butReiniciar.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReiniciar.Location = new System.Drawing.Point(618, 42);
            this.butReiniciar.Name = "butReiniciar";
            this.butReiniciar.Size = new System.Drawing.Size(75, 33);
            this.butReiniciar.TabIndex = 4;
            this.butReiniciar.Text = "REINICIAR";
            this.butReiniciar.UseVisualStyleBackColor = true;
            this.butReiniciar.Click += new System.EventHandler(this.butConsul_Click);
            // 
            // butConsulta
            // 
            this.butConsulta.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConsulta.Location = new System.Drawing.Point(537, 42);
            this.butConsulta.Name = "butConsulta";
            this.butConsulta.Size = new System.Drawing.Size(75, 33);
            this.butConsulta.TabIndex = 3;
            this.butConsulta.Text = "CONSULTAR";
            this.butConsulta.UseVisualStyleBackColor = true;
            this.butConsulta.Click += new System.EventHandler(this.butConsulta_Click);
            // 
            // textConsulta
            // 
            this.textConsulta.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConsulta.Location = new System.Drawing.Point(26, 45);
            this.textConsulta.Name = "textConsulta";
            this.textConsulta.Size = new System.Drawing.Size(505, 25);
            this.textConsulta.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registro de Empleados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textApe;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.DateTimePicker dateTimeNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butLimpiar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butConsulta;
        private System.Windows.Forms.TextBox textConsulta;
        private System.Windows.Forms.Button butReiniciar;
    }
}

