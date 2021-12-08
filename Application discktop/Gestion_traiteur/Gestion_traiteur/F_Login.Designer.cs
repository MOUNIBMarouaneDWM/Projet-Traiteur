namespace Gestion_traiteur
{
    partial class F_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tx_admin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tx_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.icon_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // tx_admin
            // 
            this.tx_admin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tx_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.tx_admin.HintForeColor = System.Drawing.Color.Empty;
            this.tx_admin.HintText = "";
            this.tx_admin.isPassword = false;
            this.tx_admin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.tx_admin.LineIdleColor = System.Drawing.Color.White;
            this.tx_admin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.tx_admin.LineThickness = 3;
            this.tx_admin.Location = new System.Drawing.Point(378, 158);
            this.tx_admin.Margin = new System.Windows.Forms.Padding(4);
            this.tx_admin.Name = "tx_admin";
            this.tx_admin.Size = new System.Drawing.Size(379, 33);
            this.tx_admin.TabIndex = 1;
            this.tx_admin.Text = "Admin";
            this.tx_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_admin.Enter += new System.EventHandler(this.Tx_admin_Enter);
            this.tx_admin.Leave += new System.EventHandler(this.Tx_admin_Leave);
            // 
            // tx_pass
            // 
            this.tx_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tx_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.tx_pass.HintForeColor = System.Drawing.Color.Empty;
            this.tx_pass.HintText = "";
            this.tx_pass.isPassword = false;
            this.tx_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.tx_pass.LineIdleColor = System.Drawing.Color.White;
            this.tx_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.tx_pass.LineThickness = 3;
            this.tx_pass.Location = new System.Drawing.Point(378, 214);
            this.tx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.Size = new System.Drawing.Size(379, 33);
            this.tx_pass.TabIndex = 2;
            this.tx_pass.Text = "Mot de passe";
            this.tx_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tx_pass.Enter += new System.EventHandler(this.Tx_pass_Enter);
            this.tx_pass.Leave += new System.EventHandler(this.Tx_pass_Leave);
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.White;
            this.btn_login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btn_login.Location = new System.Drawing.Point(359, 294);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(408, 52);
            this.btn_login.TabIndex = 3;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // icon_close
            // 
            this.icon_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_close.Image = ((System.Drawing.Image)(resources.GetObject("icon_close.Image")));
            this.icon_close.Location = new System.Drawing.Point(755, 12);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(31, 26);
            this.icon_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_close.TabIndex = 5;
            this.icon_close.TabStop = false;
            this.icon_close.Click += new System.EventHandler(this.Icon_close_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icon_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.tx_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tx_admin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tx_pass;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private System.Windows.Forms.PictureBox icon_close;
    }
}

