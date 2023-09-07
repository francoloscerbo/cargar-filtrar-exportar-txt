namespace Cargar__filtrar_y_exportar_datos_a_txt
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnNuevoPerfil = new System.Windows.Forms.Button();
            this.btnFiltrado = new System.Windows.Forms.Button();
            this.labBienbenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoPerfil
            // 
            this.btnNuevoPerfil.BackColor = System.Drawing.Color.LightYellow;
            this.btnNuevoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPerfil.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPerfil.Image")));
            this.btnNuevoPerfil.Location = new System.Drawing.Point(434, 265);
            this.btnNuevoPerfil.Name = "btnNuevoPerfil";
            this.btnNuevoPerfil.Size = new System.Drawing.Size(59, 52);
            this.btnNuevoPerfil.TabIndex = 0;
            this.btnNuevoPerfil.UseVisualStyleBackColor = false;
            this.btnNuevoPerfil.Click += new System.EventHandler(this.btnNuevoPerfil_Click);
            // 
            // btnFiltrado
            // 
            this.btnFiltrado.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFiltrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrado.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrado.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrado.Image")));
            this.btnFiltrado.Location = new System.Drawing.Point(346, 265);
            this.btnFiltrado.Name = "btnFiltrado";
            this.btnFiltrado.Size = new System.Drawing.Size(59, 52);
            this.btnFiltrado.TabIndex = 2;
            this.btnFiltrado.UseVisualStyleBackColor = false;
            this.btnFiltrado.Click += new System.EventHandler(this.btnFiltrado_Click);
            // 
            // labBienbenido
            // 
            this.labBienbenido.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBienbenido.Location = new System.Drawing.Point(325, 101);
            this.labBienbenido.Name = "labBienbenido";
            this.labBienbenido.Size = new System.Drawing.Size(204, 39);
            this.labBienbenido.TabIndex = 3;
            this.labBienbenido.Text = "Bienvenido";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "  En este programa podra cargar personal como tambien filtrar sus datos para expo" +
    "rtarlos en un archivo .txt\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Franco Loscerbo";
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
            this.button1.Location = new System.Drawing.Point(805, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 42);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(847, 489);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labBienbenido);
            this.Controls.Add(this.btnFiltrado);
            this.Controls.Add(this.btnNuevoPerfil);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPerfil;
        private System.Windows.Forms.Button btnFiltrado;
        private System.Windows.Forms.Label labBienbenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}