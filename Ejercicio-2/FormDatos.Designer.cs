namespace Ejercicio_2
{
    partial class FormDatos
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
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(41, 28);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(29, 13);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "Dni: ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(41, 61);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(111, 28);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(101, 20);
            this.tbDni.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 61);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(101, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(44, 105);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(137, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "button2";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 148);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.Name = "FormDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombre;
        public System.Windows.Forms.TextBox tbDni;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
    }
}