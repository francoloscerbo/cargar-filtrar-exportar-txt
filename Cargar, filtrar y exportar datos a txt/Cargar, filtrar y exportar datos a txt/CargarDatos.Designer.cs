namespace Cargar__filtrar_y_exportar_datos_a_txt
{
    partial class CargarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarDatos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.labDNI = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.boxDNI = new System.Windows.Forms.TextBox();
            this.BoxNombre = new System.Windows.Forms.TextBox();
            this.BoxApellido = new System.Windows.Forms.TextBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOtro = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.BoxHIjos = new System.Windows.Forms.TextBox();
            this.cmbCivil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDatos = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbEstado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(830, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDNI.Location = new System.Drawing.Point(23, 26);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(50, 23);
            this.labDNI.TabIndex = 4;
            this.labDNI.Text = "DNI";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(23, 60);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(90, 23);
            this.labNombre.TabIndex = 5;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(23, 96);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(94, 23);
            this.labApellido.TabIndex = 6;
            this.labApellido.Text = "Apellido";
            // 
            // labNacimiento
            // 
            this.labNacimiento.AutoSize = true;
            this.labNacimiento.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNacimiento.Location = new System.Drawing.Point(23, 132);
            this.labNacimiento.Name = "labNacimiento";
            this.labNacimiento.Size = new System.Drawing.Size(187, 23);
            this.labNacimiento.TabIndex = 7;
            this.labNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(215, 135);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(102, 22);
            this.dtpFechaNac.TabIndex = 8;
            // 
            // boxDNI
            // 
            this.boxDNI.Location = new System.Drawing.Point(79, 29);
            this.boxDNI.Name = "boxDNI";
            this.boxDNI.Size = new System.Drawing.Size(156, 22);
            this.boxDNI.TabIndex = 13;
            // 
            // BoxNombre
            // 
            this.BoxNombre.Location = new System.Drawing.Point(119, 65);
            this.BoxNombre.Name = "BoxNombre";
            this.BoxNombre.Size = new System.Drawing.Size(156, 22);
            this.BoxNombre.TabIndex = 14;
            // 
            // BoxApellido
            // 
            this.BoxApellido.Location = new System.Drawing.Point(123, 99);
            this.BoxApellido.Name = "BoxApellido";
            this.BoxApellido.Size = new System.Drawing.Size(156, 22);
            this.BoxApellido.TabIndex = 15;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.label4);
            this.gbEstado.Controls.Add(this.listView1);
            this.gbEstado.Controls.Add(this.btnActualizar);
            this.gbEstado.Controls.Add(this.btnCargar);
            this.gbEstado.Controls.Add(this.groupBox1);
            this.gbEstado.Controls.Add(this.BoxHIjos);
            this.gbEstado.Controls.Add(this.cmbCivil);
            this.gbEstado.Controls.Add(this.label2);
            this.gbEstado.Controls.Add(this.label1);
            this.gbEstado.Controls.Add(this.dtpFechaNac);
            this.gbEstado.Controls.Add(this.labDNI);
            this.gbEstado.Controls.Add(this.BoxApellido);
            this.gbEstado.Controls.Add(this.labNombre);
            this.gbEstado.Controls.Add(this.BoxNombre);
            this.gbEstado.Controls.Add(this.labApellido);
            this.gbEstado.Controls.Add(this.boxDNI);
            this.gbEstado.Controls.Add(this.labNacimiento);
            this.gbEstado.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.Location = new System.Drawing.Point(11, 18);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstado.Size = new System.Drawing.Size(368, 452);
            this.gbEstado.TabIndex = 17;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Datos";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Franco Loscerbo";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(387, -31);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 427);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(180, 351);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(55, 54);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Lime;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(107, 351);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(55, 54);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOtro);
            this.groupBox1.Controls.Add(this.radioButtonMujer);
            this.groupBox1.Controls.Add(this.radioButtonHombre);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 73);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButtonOtro
            // 
            this.radioButtonOtro.AutoSize = true;
            this.radioButtonOtro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOtro.Location = new System.Drawing.Point(200, 31);
            this.radioButtonOtro.Name = "radioButtonOtro";
            this.radioButtonOtro.Size = new System.Drawing.Size(61, 22);
            this.radioButtonOtro.TabIndex = 2;
            this.radioButtonOtro.TabStop = true;
            this.radioButtonOtro.Text = "Otro";
            this.radioButtonOtro.UseVisualStyleBackColor = true;
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMujer.Location = new System.Drawing.Point(123, 31);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(72, 22);
            this.radioButtonMujer.TabIndex = 1;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHombre.Location = new System.Drawing.Point(27, 31);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(90, 22);
            this.radioButtonHombre.TabIndex = 0;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // BoxHIjos
            // 
            this.BoxHIjos.Location = new System.Drawing.Point(149, 206);
            this.BoxHIjos.Name = "BoxHIjos";
            this.BoxHIjos.Size = new System.Drawing.Size(45, 22);
            this.BoxHIjos.TabIndex = 19;
            // 
            // cmbCivil
            // 
            this.cmbCivil.FormattingEnabled = true;
            this.cmbCivil.Location = new System.Drawing.Point(159, 170);
            this.cmbCivil.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCivil.Name = "cmbCivil";
            this.cmbCivil.Size = new System.Drawing.Size(147, 24);
            this.cmbCivil.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cant. Hijos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Estado Civil";
            // 
            // listViewDatos
            // 
            this.listViewDatos.BackColor = System.Drawing.Color.SandyBrown;
            this.listViewDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDatos.HideSelection = false;
            this.listViewDatos.Location = new System.Drawing.Point(398, 54);
            this.listViewDatos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDatos.Name = "listViewDatos";
            this.listViewDatos.Size = new System.Drawing.Size(466, 416);
            this.listViewDatos.TabIndex = 18;
            this.listViewDatos.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Datos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(790, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 42);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(875, 481);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewDatos);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.btnSalir);
            this.Name = "CargarDatos";
            this.Text = "CargarDatos";
            this.Load += new System.EventHandler(this.CargarDatos_Load);
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox boxDNI;
        private System.Windows.Forms.TextBox BoxNombre;
        private System.Windows.Forms.TextBox BoxApellido;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOtro;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox BoxHIjos;
        private System.Windows.Forms.ComboBox cmbCivil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listViewDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}