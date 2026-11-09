namespace Sistema_control_personal
{
    partial class Consulta_cod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_cod));
            this.panelbarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtcodcon = new System.Windows.Forms.TextBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelbarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbarra
            // 
            this.panelbarra.Controls.Add(this.label1);
            this.panelbarra.Controls.Add(this.btnsalir);
            this.panelbarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbarra.Location = new System.Drawing.Point(0, 0);
            this.panelbarra.Name = "panelbarra";
            this.panelbarra.Size = new System.Drawing.Size(432, 25);
            this.panelbarra.TabIndex = 0;
            this.panelbarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbarra_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Consulte su código ingresando su DNI";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(401, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(31, 25);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "x";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(74, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI";
            // 
            // txtdni
            // 
            this.txtdni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdni.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.Color.DimGray;
            this.txtdni.Location = new System.Drawing.Point(78, 90);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(271, 26);
            this.txtdni.TabIndex = 8;
            this.txtdni.Text = "Ingrese su DNI";
            this.txtdni.Enter += new System.EventHandler(this.txtdni_Enter);
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            this.txtdni.Leave += new System.EventHandler(this.txtdni_Leave);
            // 
            // txtcodcon
            // 
            this.txtcodcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodcon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcodcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodcon.ForeColor = System.Drawing.Color.DimGray;
            this.txtcodcon.Location = new System.Drawing.Point(78, 173);
            this.txtcodcon.Name = "txtcodcon";
            this.txtcodcon.Size = new System.Drawing.Size(271, 26);
            this.txtcodcon.TabIndex = 9;
            this.txtcodcon.Text = "Su código es...";
            this.txtcodcon.Enter += new System.EventHandler(this.txtcodcon_Enter);
            this.txtcodcon.Leave += new System.EventHandler(this.txtcodcon_Leave);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnconsultar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnconsultar.FlatAppearance.BorderSize = 0;
            this.btnconsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnconsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.Color.White;
            this.btnconsultar.Location = new System.Drawing.Point(78, 127);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(127, 33);
            this.btnconsultar.TabIndex = 10;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(222, 127);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(127, 33);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Consulta_cod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(432, 277);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtcodcon);
            this.Controls.Add(this.panelbarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_cod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_cod";
            this.panelbarra.ResumeLayout(false);
            this.panelbarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbarra;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtcodcon;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btncancelar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}