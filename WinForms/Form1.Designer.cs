namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgDatos = new DataGridView();
            btnMostrar = new Button();
            btnExportar = new Button();
            btnImportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(12, 12);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(776, 261);
            dgDatos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(195, 323);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(533, 323);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(360, 323);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(101, 23);
            btnImportar.TabIndex = 3;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImportar);
            Controls.Add(btnExportar);
            Controls.Add(btnMostrar);
            Controls.Add(dgDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgDatos;
        private Button btnMostrar;
        private Button btnExportar;
        private Button btnImportar;
    }
}
