namespace Calculo
{
    partial class Suma3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suma3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.retroceder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maximizar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cinco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.opcion1 = new System.Windows.Forms.Button();
            this.opcion2 = new System.Windows.Forms.Button();
            this.incorrecto1 = new System.Windows.Forms.Label();
            this.correcto = new System.Windows.Forms.Label();
            this.opcion3 = new System.Windows.Forms.Button();
            this.incorrecto2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.retroceder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 51);
            this.panel1.TabIndex = 5;
            // 
            // retroceder
            // 
            this.retroceder.FlatAppearance.BorderSize = 0;
            this.retroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder.Image = ((System.Drawing.Image)(resources.GetObject("retroceder.Image")));
            this.retroceder.Location = new System.Drawing.Point(3, 10);
            this.retroceder.Name = "retroceder";
            this.retroceder.Size = new System.Drawing.Size(32, 23);
            this.retroceder.TabIndex = 16;
            this.retroceder.UseVisualStyleBackColor = true;
            this.retroceder.Click += new System.EventHandler(this.retroceder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Moon Flower Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "DISCAP";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moon Flower Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(264, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "CÁLCULO - APRENDE A SUMAR";
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(712, 8);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(25, 24);
            this.maximizar.TabIndex = 3;
            this.maximizar.UseVisualStyleBackColor = true;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(743, 8);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(27, 26);
            this.cerrar.TabIndex = 1;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Moon Flower Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "EL RESULTADO DE LA SUMA ES:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cinco, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.opcion1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.opcion2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.incorrecto1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.correcto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.opcion3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.incorrecto2, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(127, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 619);
            this.tableLayoutPanel1.TabIndex = 25;
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseMove);
            // 
            // cinco
            // 
            this.cinco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cinco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.cinco.FlatAppearance.BorderSize = 2;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.Image = ((System.Drawing.Image)(resources.GetObject("cinco.Image")));
            this.cinco.Location = new System.Drawing.Point(173, 157);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(164, 148);
            this.cinco.TabIndex = 9;
            this.cinco.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 148);
            this.label4.TabIndex = 15;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(343, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 148);
            this.label6.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(173, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 148);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // opcion1
            // 
            this.opcion1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opcion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcion1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.opcion1.FlatAppearance.BorderSize = 2;
            this.opcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcion1.Image = ((System.Drawing.Image)(resources.GetObject("opcion1.Image")));
            this.opcion1.Location = new System.Drawing.Point(3, 311);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(164, 148);
            this.opcion1.TabIndex = 22;
            this.opcion1.UseVisualStyleBackColor = true;
            this.opcion1.Click += new System.EventHandler(this.opcion1_Click);
            // 
            // opcion2
            // 
            this.opcion2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opcion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcion2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.opcion2.FlatAppearance.BorderSize = 2;
            this.opcion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcion2.Image = ((System.Drawing.Image)(resources.GetObject("opcion2.Image")));
            this.opcion2.Location = new System.Drawing.Point(173, 311);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(164, 148);
            this.opcion2.TabIndex = 23;
            this.opcion2.UseVisualStyleBackColor = true;
            this.opcion2.Click += new System.EventHandler(this.opcion2_Click);
            // 
            // incorrecto1
            // 
            this.incorrecto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrecto1.AutoSize = true;
            this.incorrecto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incorrecto1.Image = ((System.Drawing.Image)(resources.GetObject("incorrecto1.Image")));
            this.incorrecto1.Location = new System.Drawing.Point(3, 465);
            this.incorrecto1.Margin = new System.Windows.Forms.Padding(3);
            this.incorrecto1.Name = "incorrecto1";
            this.incorrecto1.Size = new System.Drawing.Size(164, 151);
            this.incorrecto1.TabIndex = 25;
            this.incorrecto1.Visible = false;
            // 
            // correcto
            // 
            this.correcto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.correcto.AutoSize = true;
            this.correcto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.correcto.Image = ((System.Drawing.Image)(resources.GetObject("correcto.Image")));
            this.correcto.Location = new System.Drawing.Point(173, 465);
            this.correcto.Margin = new System.Windows.Forms.Padding(3);
            this.correcto.Name = "correcto";
            this.correcto.Size = new System.Drawing.Size(164, 151);
            this.correcto.TabIndex = 26;
            this.correcto.Visible = false;
            // 
            // opcion3
            // 
            this.opcion3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opcion3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcion3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.opcion3.FlatAppearance.BorderSize = 2;
            this.opcion3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcion3.Image = ((System.Drawing.Image)(resources.GetObject("opcion3.Image")));
            this.opcion3.Location = new System.Drawing.Point(343, 311);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(165, 148);
            this.opcion3.TabIndex = 24;
            this.opcion3.UseVisualStyleBackColor = true;
            this.opcion3.Click += new System.EventHandler(this.opcion3_Click);
            // 
            // incorrecto2
            // 
            this.incorrecto2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrecto2.AutoSize = true;
            this.incorrecto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incorrecto2.Image = ((System.Drawing.Image)(resources.GetObject("incorrecto2.Image")));
            this.incorrecto2.Location = new System.Drawing.Point(343, 465);
            this.incorrecto2.Margin = new System.Windows.Forms.Padding(3);
            this.incorrecto2.Name = "incorrecto2";
            this.incorrecto2.Size = new System.Drawing.Size(165, 151);
            this.incorrecto2.TabIndex = 27;
            this.incorrecto2.Visible = false;
            // 
            // Suma3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 731);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suma3";
            this.Text = "Suma3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button retroceder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button opcion1;
        private System.Windows.Forms.Button opcion2;
        private System.Windows.Forms.Label incorrecto1;
        private System.Windows.Forms.Label correcto;
        private System.Windows.Forms.Button opcion3;
        private System.Windows.Forms.Label incorrecto2;
    }
}