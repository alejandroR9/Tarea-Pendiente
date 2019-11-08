namespace Libreria
{
    partial class correo
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
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.txtboc = new System.Windows.Forms.Label();
            this.txtbo = new System.Windows.Forms.TextBox();
            this.txtasun = new System.Windows.Forms.TextBox();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(48, 113);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(556, 164);
            this.txtmensaje.TabIndex = 15;
            // 
            // txtboc
            // 
            this.txtboc.AutoSize = true;
            this.txtboc.Location = new System.Drawing.Point(359, 9);
            this.txtboc.Name = "txtboc";
            this.txtboc.Size = new System.Drawing.Size(29, 13);
            this.txtboc.TabIndex = 14;
            this.txtboc.Text = "BOC";
            // 
            // txtbo
            // 
            this.txtbo.Location = new System.Drawing.Point(416, 2);
            this.txtbo.Name = "txtbo";
            this.txtbo.Size = new System.Drawing.Size(188, 20);
            this.txtbo.TabIndex = 13;
            // 
            // txtasun
            // 
            this.txtasun.Location = new System.Drawing.Point(68, 59);
            this.txtasun.Name = "txtasun";
            this.txtasun.Size = new System.Drawing.Size(536, 20);
            this.txtasun.TabIndex = 12;
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(68, 2);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(258, 20);
            this.txtpara.TabIndex = 11;
            this.txtpara.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = " ASUNTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PARA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 319);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.txtboc);
            this.Controls.Add(this.txtbo);
            this.Controls.Add(this.txtasun);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "correo";
            this.Text = "correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label txtboc;
        private System.Windows.Forms.TextBox txtbo;
        private System.Windows.Forms.TextBox txtasun;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}