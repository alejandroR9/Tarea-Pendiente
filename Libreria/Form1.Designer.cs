namespace Libreria
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNivel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = " Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = " Registrar y Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ord,
            this.Principal,
            this.SubNivel,
            this.SubNivel2,
            this.Titulo,
            this.Autor,
            this.Isbn,
            this.Idioma,
            this.Edicion,
            this.Editorial,
            this.Año,
            this.Ejemplar,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // Ord
            // 
            this.Ord.HeaderText = "Ord";
            this.Ord.Name = "Ord";
            // 
            // Principal
            // 
            this.Principal.HeaderText = "Principal";
            this.Principal.Name = "Principal";
            // 
            // SubNivel
            // 
            this.SubNivel.HeaderText = "SubNivel";
            this.SubNivel.Name = "SubNivel";
            // 
            // SubNivel2
            // 
            this.SubNivel2.HeaderText = "SubNivel2";
            this.SubNivel2.Name = "SubNivel2";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // Isbn
            // 
            this.Isbn.HeaderText = "Isbn";
            this.Isbn.Name = "Isbn";
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            // 
            // Edicion
            // 
            this.Edicion.HeaderText = "Edicion";
            this.Edicion.Name = "Edicion";
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // Ejemplar
            // 
            this.Ejemplar.HeaderText = "Ejemplar";
            this.Ejemplar.Name = "Ejemplar";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNivel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

