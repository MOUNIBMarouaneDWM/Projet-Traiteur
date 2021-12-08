namespace Gestion_traiteur
{
    partial class F_traiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_traiteur));
            this.text_admin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.text_pass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.text_pass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkBoxaffichermdp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_admin
            // 
            this.text_admin.BackColor = System.Drawing.Color.White;
            this.text_admin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.text_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_admin.HintForeColor = System.Drawing.Color.Empty;
            this.text_admin.HintText = "";
            this.text_admin.isPassword = false;
            this.text_admin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_admin.LineIdleColor = System.Drawing.Color.DarkGray;
            this.text_admin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_admin.LineThickness = 3;
            this.text_admin.Location = new System.Drawing.Point(446, 187);
            this.text_admin.Margin = new System.Windows.Forms.Padding(4);
            this.text_admin.Name = "text_admin";
            this.text_admin.Size = new System.Drawing.Size(179, 33);
            this.text_admin.TabIndex = 0;
            this.text_admin.Text = "Nouveu admin";
            this.text_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_admin.Enter += new System.EventHandler(this.text_admin_Enter);
            this.text_admin.Leave += new System.EventHandler(this.text_admin_Leave);
            // 
            // text_pass1
            // 
            this.text_pass1.BackColor = System.Drawing.Color.White;
            this.text_pass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.text_pass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_pass1.HintForeColor = System.Drawing.Color.Empty;
            this.text_pass1.HintText = "";
            this.text_pass1.isPassword = false;
            this.text_pass1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_pass1.LineIdleColor = System.Drawing.Color.DarkGray;
            this.text_pass1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_pass1.LineThickness = 3;
            this.text_pass1.Location = new System.Drawing.Point(446, 223);
            this.text_pass1.Margin = new System.Windows.Forms.Padding(4);
            this.text_pass1.Name = "text_pass1";
            this.text_pass1.Size = new System.Drawing.Size(179, 33);
            this.text_pass1.TabIndex = 1;
            this.text_pass1.Text = "Nouveu mot de passe";
            this.text_pass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_pass1.Enter += new System.EventHandler(this.text_pass1_Enter);
            this.text_pass1.Leave += new System.EventHandler(this.text_pass1_Leave);
            // 
            // text_pass2
            // 
            this.text_pass2.BackColor = System.Drawing.Color.White;
            this.text_pass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.text_pass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_pass2.HintForeColor = System.Drawing.Color.Empty;
            this.text_pass2.HintText = "";
            this.text_pass2.isPassword = false;
            this.text_pass2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_pass2.LineIdleColor = System.Drawing.Color.DarkGray;
            this.text_pass2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.text_pass2.LineThickness = 3;
            this.text_pass2.Location = new System.Drawing.Point(446, 259);
            this.text_pass2.Margin = new System.Windows.Forms.Padding(4);
            this.text_pass2.Name = "text_pass2";
            this.text_pass2.Size = new System.Drawing.Size(179, 33);
            this.text_pass2.TabIndex = 2;
            this.text_pass2.Text = "Confirmier le mot de passe";
            this.text_pass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_pass2.Load += new System.EventHandler(this.text_pass2_Leave);
            this.text_pass2.Enter += new System.EventHandler(this.text_pass2_Enter);
            this.text_pass2.Leave += new System.EventHandler(this.text_pass2_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // admin_text
            // 
            this.admin_text.BackColor = System.Drawing.Color.White;
            this.admin_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admin_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.admin_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.admin_text.HintForeColor = System.Drawing.Color.Empty;
            this.admin_text.HintText = "";
            this.admin_text.isPassword = false;
            this.admin_text.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.admin_text.LineIdleColor = System.Drawing.Color.DarkGray;
            this.admin_text.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.admin_text.LineThickness = 3;
            this.admin_text.Location = new System.Drawing.Point(446, 151);
            this.admin_text.Margin = new System.Windows.Forms.Padding(4);
            this.admin_text.Name = "admin_text";
            this.admin_text.Size = new System.Drawing.Size(179, 33);
            this.admin_text.TabIndex = 5;
            this.admin_text.Text = "admin";
            this.admin_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.admin_text.Enter += new System.EventHandler(this.admin_text_Enter);
            this.admin_text.Leave += new System.EventHandler(this.admin_text_Leave);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Valider";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(477, 330);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(135, 36);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Valider";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // checkBoxaffichermdp
            // 
            this.checkBoxaffichermdp.AutoSize = true;
            this.checkBoxaffichermdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.checkBoxaffichermdp.Location = new System.Drawing.Point(648, 239);
            this.checkBoxaffichermdp.Name = "checkBoxaffichermdp";
            this.checkBoxaffichermdp.Size = new System.Drawing.Size(128, 17);
            this.checkBoxaffichermdp.TabIndex = 7;
            this.checkBoxaffichermdp.Text = "Afficher mot de passe";
            this.checkBoxaffichermdp.UseVisualStyleBackColor = true;
            this.checkBoxaffichermdp.CheckedChanged += new System.EventHandler(this.checkBoxaffichermdp_CheckedChanged);
            // 
            // F_traiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 474);
            this.Controls.Add(this.checkBoxaffichermdp);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.admin_text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_pass2);
            this.Controls.Add(this.text_pass1);
            this.Controls.Add(this.text_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_traiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_traiteur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox text_admin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text_pass1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text_pass2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox admin_text;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.CheckBox checkBoxaffichermdp;
    }
}