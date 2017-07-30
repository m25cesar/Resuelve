namespace Resuelve
{
    partial class FormResuelve
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
            this.labelFInicio = new System.Windows.Forms.Label();
            this.labelFFinal = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.labelFacturas = new System.Windows.Forms.Label();
            this.labelPeticiones = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFInicio
            // 
            this.labelFInicio.AutoSize = true;
            this.labelFInicio.Location = new System.Drawing.Point(40, 29);
            this.labelFInicio.Name = "labelFInicio";
            this.labelFInicio.Size = new System.Drawing.Size(65, 13);
            this.labelFInicio.TabIndex = 0;
            this.labelFInicio.Text = "Fecha Inicio";
            // 
            // labelFFinal
            // 
            this.labelFFinal.AutoSize = true;
            this.labelFFinal.Location = new System.Drawing.Point(40, 85);
            this.labelFFinal.Name = "labelFFinal";
            this.labelFFinal.Size = new System.Drawing.Size(62, 13);
            this.labelFFinal.TabIndex = 1;
            this.labelFFinal.Text = "Fecha Final";
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(111, 23);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(106, 20);
            this.dateInicio.TabIndex = 2;
            // 
            // dateFinal
            // 
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(111, 78);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(106, 20);
            this.dateFinal.TabIndex = 3;
            // 
            // labelFacturas
            // 
            this.labelFacturas.AutoSize = true;
            this.labelFacturas.Location = new System.Drawing.Point(40, 129);
            this.labelFacturas.Name = "labelFacturas";
            this.labelFacturas.Size = new System.Drawing.Size(106, 13);
            this.labelFacturas.TabIndex = 4;
            this.labelFacturas.Text = "Numero de Facturas:";
            // 
            // labelPeticiones
            // 
            this.labelPeticiones.AutoSize = true;
            this.labelPeticiones.Location = new System.Drawing.Point(40, 151);
            this.labelPeticiones.Name = "labelPeticiones";
            this.labelPeticiones.Size = new System.Drawing.Size(114, 13);
            this.labelPeticiones.TabIndex = 5;
            this.labelPeticiones.Text = "Numero de Peticiones:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(96, 200);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(90, 23);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FormResuelve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.labelPeticiones);
            this.Controls.Add(this.labelFacturas);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.labelFFinal);
            this.Controls.Add(this.labelFInicio);
            this.Name = "FormResuelve";
            this.Text = "Resuelve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFInicio;
        private System.Windows.Forms.Label labelFFinal;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Label labelFacturas;
        private System.Windows.Forms.Label labelPeticiones;
        private System.Windows.Forms.Button btnIniciar;
    }
}

