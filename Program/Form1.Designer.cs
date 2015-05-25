namespace Wyszukiwanie_mostu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.krawedz1 = new System.Windows.Forms.ComboBox();
            this.krawedz2 = new System.Windows.Forms.ComboBox();
            this.btnRysujKrawedz = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.image);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 631);
            this.panel1.TabIndex = 0;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(776, 631);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.pictureBox1_Click);
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // krawedz1
            // 
            this.krawedz1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krawedz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krawedz1.FormattingEnabled = true;
            this.krawedz1.Location = new System.Drawing.Point(158, 682);
            this.krawedz1.Name = "krawedz1";
            this.krawedz1.Size = new System.Drawing.Size(56, 28);
            this.krawedz1.TabIndex = 1;
            this.krawedz1.SelectedIndexChanged += new System.EventHandler(this.krawedz1_SelectedIndexChanged);
            // 
            // krawedz2
            // 
            this.krawedz2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krawedz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krawedz2.FormattingEnabled = true;
            this.krawedz2.Location = new System.Drawing.Point(268, 682);
            this.krawedz2.Name = "krawedz2";
            this.krawedz2.Size = new System.Drawing.Size(51, 28);
            this.krawedz2.TabIndex = 2;
            this.krawedz2.SelectedIndexChanged += new System.EventHandler(this.krawedz2_SelectedIndexChanged);
            // 
            // btnRysujKrawedz
            // 
            this.btnRysujKrawedz.Enabled = false;
            this.btnRysujKrawedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRysujKrawedz.Location = new System.Drawing.Point(137, 717);
            this.btnRysujKrawedz.Name = "btnRysujKrawedz";
            this.btnRysujKrawedz.Size = new System.Drawing.Size(224, 54);
            this.btnRysujKrawedz.TabIndex = 3;
            this.btnRysujKrawedz.Text = "Rysuj krawędź";
            this.btnRysujKrawedz.UseVisualStyleBackColor = true;
            this.btnRysujKrawedz.Click += new System.EventHandler(this.btnRysujKrawedz_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Enabled = false;
            this.btnWyczysc.Location = new System.Drawing.Point(472, 702);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(139, 34);
            this.btnWyczysc.TabIndex = 4;
            this.btnWyczysc.Text = "Reset";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(824, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wybierz wierzchołki, które";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(824, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "chcesz połączyć krawędzią";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(658, 702);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "ZAKOŃCZ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 783);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnRysujKrawedz);
            this.Controls.Add(this.krawedz2);
            this.Controls.Add(this.krawedz1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.ComboBox krawedz2;
        private System.Windows.Forms.Button btnRysujKrawedz;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox krawedz1;
        private System.Windows.Forms.Button btnExit;
    }
}

