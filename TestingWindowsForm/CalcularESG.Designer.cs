
namespace TestingWindowsForm
{
    partial class CalcularESG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcularESG));
            this.imgecuacion = new System.Windows.Forms.PictureBox();
            this.btncalculo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.btrnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgecuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // imgecuacion
            // 
            this.imgecuacion.Image = ((System.Drawing.Image)(resources.GetObject("imgecuacion.Image")));
            this.imgecuacion.Location = new System.Drawing.Point(211, 12);
            this.imgecuacion.Name = "imgecuacion";
            this.imgecuacion.Size = new System.Drawing.Size(375, 183);
            this.imgecuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgecuacion.TabIndex = 0;
            this.imgecuacion.TabStop = false;
            this.imgecuacion.Click += new System.EventHandler(this.imgecuacion_Click);
            // 
            // btncalculo
            // 
            this.btncalculo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculo.Location = new System.Drawing.Point(506, 242);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(80, 35);
            this.btncalculo.TabIndex = 1;
            this.btncalculo.Text = "Calcular";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 4;
            // 
            // txta
            // 
            this.txta.AutoSize = true;
            this.txta.Location = new System.Drawing.Point(128, 242);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(54, 13);
            this.txta.TabIndex = 5;
            this.txta.Text = "Ingrese a:";
            this.txta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtb
            // 
            this.txtb.AutoSize = true;
            this.txtb.Location = new System.Drawing.Point(128, 281);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(54, 13);
            this.txtb.TabIndex = 6;
            this.txtb.Text = "Ingrese b:";
            // 
            // txtc
            // 
            this.txtc.AutoSize = true;
            this.txtc.Location = new System.Drawing.Point(128, 325);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(54, 13);
            this.txtc.TabIndex = 7;
            this.txtc.Text = "Ingrese c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado X1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado X2:";
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(353, 383);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(0, 13);
            this.lblx1.TabIndex = 10;
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(353, 414);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(0, 13);
            this.lblx2.TabIndex = 11;
            this.lblx2.Click += new System.EventHandler(this.label3_Click);
            // 
            // btrnlimpiar
            // 
            this.btrnlimpiar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrnlimpiar.Location = new System.Drawing.Point(506, 303);
            this.btrnlimpiar.Name = "btrnlimpiar";
            this.btrnlimpiar.Size = new System.Drawing.Size(80, 35);
            this.btrnlimpiar.TabIndex = 12;
            this.btrnlimpiar.Text = "Limpiar";
            this.btrnlimpiar.UseVisualStyleBackColor = true;
            this.btrnlimpiar.Click += new System.EventHandler(this.btrnlimpiar_Click);
            // 
            // CalcularESG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btrnlimpiar);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.lblx1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.imgecuacion);
            this.Name = "CalcularESG";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgecuacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgecuacion;
        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txta;
        private System.Windows.Forms.Label txtb;
        private System.Windows.Forms.Label txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.Button btrnlimpiar;
    }
}

