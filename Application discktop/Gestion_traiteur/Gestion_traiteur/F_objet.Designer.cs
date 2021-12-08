namespace Gestion_traiteur
{
    partial class F_objet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_objet));
            this.Progressbar_chaise = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.moin_chaise = new Bunifu.Framework.UI.BunifuThinButton2();
            this.plus_chaise = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.Progressbar_table = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btn_modifier = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpDownCh = new System.Windows.Forms.NumericUpDown();
            this.UpDownT = new System.Windows.Forms.NumericUpDown();
            this.plus_table = new Bunifu.Framework.UI.BunifuThinButton2();
            this.moin_table = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_nbrTD = new System.Windows.Forms.Label();
            this.label_nbrCHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_nbrCHU = new System.Windows.Forms.Label();
            this.label_nbrTU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownT)).BeginInit();
            this.SuspendLayout();
            // 
            // Progressbar_chaise
            // 
            this.Progressbar_chaise.animated = false;
            this.Progressbar_chaise.animationIterval = 5;
            this.Progressbar_chaise.animationSpeed = 300;
            this.Progressbar_chaise.BackColor = System.Drawing.Color.White;
            this.Progressbar_chaise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Progressbar_chaise.BackgroundImage")));
            this.Progressbar_chaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Progressbar_chaise.ForeColor = System.Drawing.Color.SeaGreen;
            this.Progressbar_chaise.LabelVisible = true;
            this.Progressbar_chaise.LineProgressThickness = 8;
            this.Progressbar_chaise.LineThickness = 5;
            this.Progressbar_chaise.Location = new System.Drawing.Point(196, 231);
            this.Progressbar_chaise.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Progressbar_chaise.MaxValue = 100;
            this.Progressbar_chaise.Name = "Progressbar_chaise";
            this.Progressbar_chaise.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Progressbar_chaise.ProgressColor = System.Drawing.Color.SeaGreen;
            this.Progressbar_chaise.Size = new System.Drawing.Size(165, 165);
            this.Progressbar_chaise.TabIndex = 0;
            this.Progressbar_chaise.Value = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(507, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // moin_chaise
            // 
            this.moin_chaise.ActiveBorderThickness = 1;
            this.moin_chaise.ActiveCornerRadius = 20;
            this.moin_chaise.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_chaise.ActiveForecolor = System.Drawing.Color.White;
            this.moin_chaise.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_chaise.BackColor = System.Drawing.Color.White;
            this.moin_chaise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moin_chaise.BackgroundImage")));
            this.moin_chaise.ButtonText = "-";
            this.moin_chaise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moin_chaise.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moin_chaise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_chaise.IdleBorderThickness = 1;
            this.moin_chaise.IdleCornerRadius = 20;
            this.moin_chaise.IdleFillColor = System.Drawing.Color.White;
            this.moin_chaise.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_chaise.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_chaise.Location = new System.Drawing.Point(120, 321);
            this.moin_chaise.Margin = new System.Windows.Forms.Padding(5);
            this.moin_chaise.Name = "moin_chaise";
            this.moin_chaise.Size = new System.Drawing.Size(42, 41);
            this.moin_chaise.TabIndex = 8;
            this.moin_chaise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moin_chaise.Click += new System.EventHandler(this.moin_chaise_Click);
            // 
            // plus_chaise
            // 
            this.plus_chaise.ActiveBorderThickness = 1;
            this.plus_chaise.ActiveCornerRadius = 20;
            this.plus_chaise.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.plus_chaise.ActiveForecolor = System.Drawing.Color.White;
            this.plus_chaise.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.plus_chaise.BackColor = System.Drawing.Color.White;
            this.plus_chaise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus_chaise.BackgroundImage")));
            this.plus_chaise.ButtonText = "+";
            this.plus_chaise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_chaise.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_chaise.ForeColor = System.Drawing.Color.SeaGreen;
            this.plus_chaise.IdleBorderThickness = 1;
            this.plus_chaise.IdleCornerRadius = 20;
            this.plus_chaise.IdleFillColor = System.Drawing.Color.White;
            this.plus_chaise.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.plus_chaise.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.plus_chaise.Location = new System.Drawing.Point(120, 275);
            this.plus_chaise.Margin = new System.Windows.Forms.Padding(5);
            this.plus_chaise.Name = "plus_chaise";
            this.plus_chaise.Size = new System.Drawing.Size(42, 41);
            this.plus_chaise.TabIndex = 9;
            this.plus_chaise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plus_chaise.Click += new System.EventHandler(this.plus_chaise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stokage";
            // 
            // Progressbar_table
            // 
            this.Progressbar_table.animated = false;
            this.Progressbar_table.animationIterval = 5;
            this.Progressbar_table.animationSpeed = 300;
            this.Progressbar_table.BackColor = System.Drawing.Color.White;
            this.Progressbar_table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Progressbar_table.BackgroundImage")));
            this.Progressbar_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Progressbar_table.ForeColor = System.Drawing.Color.SeaGreen;
            this.Progressbar_table.LabelVisible = true;
            this.Progressbar_table.LineProgressThickness = 8;
            this.Progressbar_table.LineThickness = 5;
            this.Progressbar_table.Location = new System.Drawing.Point(560, 231);
            this.Progressbar_table.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Progressbar_table.MaxValue = 100;
            this.Progressbar_table.Name = "Progressbar_table";
            this.Progressbar_table.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Progressbar_table.ProgressColor = System.Drawing.Color.SeaGreen;
            this.Progressbar_table.Size = new System.Drawing.Size(165, 165);
            this.Progressbar_table.TabIndex = 1;
            this.Progressbar_table.Value = 0;
            // 
            // btn_modifier
            // 
            this.btn_modifier.ActiveBorderThickness = 1;
            this.btn_modifier.ActiveCornerRadius = 20;
            this.btn_modifier.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_modifier.ActiveForecolor = System.Drawing.Color.White;
            this.btn_modifier.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_modifier.BackColor = System.Drawing.Color.White;
            this.btn_modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modifier.BackgroundImage")));
            this.btn_modifier.ButtonText = "Modifier";
            this.btn_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_modifier.IdleBorderThickness = 1;
            this.btn_modifier.IdleCornerRadius = 20;
            this.btn_modifier.IdleFillColor = System.Drawing.Color.White;
            this.btn_modifier.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_modifier.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_modifier.Location = new System.Drawing.Point(401, 321);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(5);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(120, 41);
            this.btn_modifier.TabIndex = 13;
            this.btn_modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // UpDownCh
            // 
            this.UpDownCh.Location = new System.Drawing.Point(217, 408);
            this.UpDownCh.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.UpDownCh.Name = "UpDownCh";
            this.UpDownCh.Size = new System.Drawing.Size(120, 20);
            this.UpDownCh.TabIndex = 14;
            this.UpDownCh.ValueChanged += new System.EventHandler(this.UpDownCh_ValueChanged);
            // 
            // UpDownT
            // 
            this.UpDownT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpDownT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UpDownT.Location = new System.Drawing.Point(588, 408);
            this.UpDownT.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.UpDownT.Name = "UpDownT";
            this.UpDownT.Size = new System.Drawing.Size(120, 20);
            this.UpDownT.TabIndex = 15;
            this.UpDownT.ValueChanged += new System.EventHandler(this.UpDownT_ValueChanged);
            // 
            // plus_table
            // 
            this.plus_table.ActiveBorderThickness = 1;
            this.plus_table.ActiveCornerRadius = 20;
            this.plus_table.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.plus_table.ActiveForecolor = System.Drawing.Color.White;
            this.plus_table.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.plus_table.BackColor = System.Drawing.Color.White;
            this.plus_table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus_table.BackgroundImage")));
            this.plus_table.ButtonText = "+";
            this.plus_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_table.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_table.ForeColor = System.Drawing.Color.SeaGreen;
            this.plus_table.IdleBorderThickness = 1;
            this.plus_table.IdleCornerRadius = 20;
            this.plus_table.IdleFillColor = System.Drawing.Color.White;
            this.plus_table.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.plus_table.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.plus_table.Location = new System.Drawing.Point(740, 275);
            this.plus_table.Margin = new System.Windows.Forms.Padding(5);
            this.plus_table.Name = "plus_table";
            this.plus_table.Size = new System.Drawing.Size(42, 41);
            this.plus_table.TabIndex = 17;
            this.plus_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plus_table.Click += new System.EventHandler(this.plus_table_Click);
            // 
            // moin_table
            // 
            this.moin_table.ActiveBorderThickness = 1;
            this.moin_table.ActiveCornerRadius = 20;
            this.moin_table.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_table.ActiveForecolor = System.Drawing.Color.White;
            this.moin_table.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_table.BackColor = System.Drawing.Color.White;
            this.moin_table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moin_table.BackgroundImage")));
            this.moin_table.ButtonText = "-";
            this.moin_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moin_table.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moin_table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_table.IdleBorderThickness = 1;
            this.moin_table.IdleCornerRadius = 20;
            this.moin_table.IdleFillColor = System.Drawing.Color.White;
            this.moin_table.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_table.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moin_table.Location = new System.Drawing.Point(740, 321);
            this.moin_table.Margin = new System.Windows.Forms.Padding(5);
            this.moin_table.Name = "moin_table";
            this.moin_table.Size = new System.Drawing.Size(42, 41);
            this.moin_table.TabIndex = 16;
            this.moin_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moin_table.Click += new System.EventHandler(this.moin_table_Click);
            // 
            // label_nbrTD
            // 
            this.label_nbrTD.AutoSize = true;
            this.label_nbrTD.Location = new System.Drawing.Point(532, 231);
            this.label_nbrTD.Name = "label_nbrTD";
            this.label_nbrTD.Size = new System.Drawing.Size(35, 13);
            this.label_nbrTD.TabIndex = 18;
            this.label_nbrTD.Text = "label2";
            // 
            // label_nbrCHD
            // 
            this.label_nbrCHD.AutoSize = true;
            this.label_nbrCHD.Location = new System.Drawing.Point(167, 231);
            this.label_nbrCHD.Name = "label_nbrCHD";
            this.label_nbrCHD.Size = new System.Drawing.Size(35, 13);
            this.label_nbrCHD.TabIndex = 19;
            this.label_nbrCHD.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Disponible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Utiliser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Disponible:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Utiliser";
            // 
            // label_nbrCHU
            // 
            this.label_nbrCHU.AutoSize = true;
            this.label_nbrCHU.Location = new System.Drawing.Point(167, 252);
            this.label_nbrCHU.Name = "label_nbrCHU";
            this.label_nbrCHU.Size = new System.Drawing.Size(35, 13);
            this.label_nbrCHU.TabIndex = 24;
            this.label_nbrCHU.Text = "label3";
            // 
            // label_nbrTU
            // 
            this.label_nbrTU.AutoSize = true;
            this.label_nbrTU.Location = new System.Drawing.Point(532, 252);
            this.label_nbrTU.Name = "label_nbrTU";
            this.label_nbrTU.Size = new System.Drawing.Size(35, 13);
            this.label_nbrTU.TabIndex = 25;
            this.label_nbrTU.Text = "label2";
            // 
            // F_objet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(959, 484);
            this.Controls.Add(this.label_nbrTU);
            this.Controls.Add(this.label_nbrCHU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nbrCHD);
            this.Controls.Add(this.label_nbrTD);
            this.Controls.Add(this.plus_table);
            this.Controls.Add(this.moin_table);
            this.Controls.Add(this.UpDownT);
            this.Controls.Add(this.UpDownCh);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plus_chaise);
            this.Controls.Add(this.moin_chaise);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Progressbar_table);
            this.Controls.Add(this.Progressbar_chaise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_objet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_objet";
            this.Load += new System.EventHandler(this.F_objet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar Progressbar_chaise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 moin_chaise;
        private Bunifu.Framework.UI.BunifuThinButton2 plus_chaise;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Progressbar_table;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_modifier;
        private System.Windows.Forms.NumericUpDown UpDownCh;
        private System.Windows.Forms.NumericUpDown UpDownT;
        private Bunifu.Framework.UI.BunifuThinButton2 plus_table;
        private Bunifu.Framework.UI.BunifuThinButton2 moin_table;
        private System.Windows.Forms.Label label_nbrTD;
        private System.Windows.Forms.Label label_nbrCHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_nbrCHU;
        private System.Windows.Forms.Label label_nbrTU;
    }
}