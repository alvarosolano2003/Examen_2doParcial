namespace Presentation
{
    partial class FrmEstudiante
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
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnMostrarEstudiante = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(83, 56);
            this.btnAgregarEstudiante.TabIndex = 0;
            this.btnAgregarEstudiante.Text = "Agregar estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.BtnAgregarEstudiante_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(12, 28);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(776, 135);
            this.dgvEstudiantes.TabIndex = 1;
            this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnMostrarEstudiante
            // 
            this.btnMostrarEstudiante.Location = new System.Drawing.Point(92, 3);
            this.btnMostrarEstudiante.Name = "btnMostrarEstudiante";
            this.btnMostrarEstudiante.Size = new System.Drawing.Size(83, 56);
            this.btnMostrarEstudiante.TabIndex = 2;
            this.btnMostrarEstudiante.Text = "Mostrar estudiante";
            this.btnMostrarEstudiante.UseVisualStyleBackColor = true;
            this.btnMostrarEstudiante.Click += new System.EventHandler(this.BtnMostrarEstudiante_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(181, 3);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(83, 56);
            this.btnCalcularPromedio.TabIndex = 3;
            this.btnCalcularPromedio.Text = "Mejores promedios";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarEstudiante);
            this.flowLayoutPanel1.Controls.Add(this.btnMostrarEstudiante);
            this.flowLayoutPanel1.Controls.Add(this.btnCalcularPromedio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 261);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(371, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvEstudiantes);
            this.Name = "FrmEstudiante";
            this.Text = "FrmEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnMostrarEstudiante;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}