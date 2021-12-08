namespace Gestion_traiteur
{
    partial class F_event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_event));
            this.Textbox_nam = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.Textbox_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_sup = new System.Windows.Forms.PictureBox();
            this.Button_modi = new System.Windows.Forms.PictureBox();
            this.Button_add = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_modi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_nam
            // 
            this.Textbox_nam.BackColor = System.Drawing.Color.White;
            this.Textbox_nam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Textbox_nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_nam.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_nam.HintText = "";
            this.Textbox_nam.isPassword = false;
            this.Textbox_nam.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_nam.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Textbox_nam.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_nam.LineThickness = 3;
            this.Textbox_nam.Location = new System.Drawing.Point(83, 200);
            this.Textbox_nam.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_nam.Name = "Textbox_nam";
            this.Textbox_nam.Size = new System.Drawing.Size(225, 33);
            this.Textbox_nam.TabIndex = 1;
            this.Textbox_nam.Text = "Nom de evenment";
            this.Textbox_nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_nam.Enter += new System.EventHandler(this.Textbox_nam_Enter);
            this.Textbox_nam.Leave += new System.EventHandler(this.Textbox_nam_Leave);
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Location = new System.Drawing.Point(366, 134);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.Size = new System.Drawing.Size(319, 303);
            this.dataGridView_list.TabIndex = 2;
            this.dataGridView_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_CellClick);
            // 
            // Textbox_id
            // 
            this.Textbox_id.BackColor = System.Drawing.Color.White;
            this.Textbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Textbox_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_id.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_id.HintText = "";
            this.Textbox_id.isPassword = false;
            this.Textbox_id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_id.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Textbox_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_id.LineThickness = 3;
            this.Textbox_id.Location = new System.Drawing.Point(83, 159);
            this.Textbox_id.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_id.Name = "Textbox_id";
            this.Textbox_id.Size = new System.Drawing.Size(225, 33);
            this.Textbox_id.TabIndex = 52;
            this.Textbox_id.Text = "ID de evenment";
            this.Textbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_id.Enter += new System.EventHandler(this.Textbox_id_Enter);
            this.Textbox_id.Leave += new System.EventHandler(this.Textbox_id_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nouveau";
            // 
            // Button_sup
            // 
            this.Button_sup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_sup.Image = ((System.Drawing.Image)(resources.GetObject("Button_sup.Image")));
            this.Button_sup.Location = new System.Drawing.Point(580, 66);
            this.Button_sup.Name = "Button_sup";
            this.Button_sup.Size = new System.Drawing.Size(32, 32);
            this.Button_sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_sup.TabIndex = 55;
            this.Button_sup.TabStop = false;
            this.Button_sup.Click += new System.EventHandler(this.Button_sup_Click);
            // 
            // Button_modi
            // 
            this.Button_modi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_modi.Image = ((System.Drawing.Image)(resources.GetObject("Button_modi.Image")));
            this.Button_modi.Location = new System.Drawing.Point(498, 66);
            this.Button_modi.Name = "Button_modi";
            this.Button_modi.Size = new System.Drawing.Size(32, 32);
            this.Button_modi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_modi.TabIndex = 54;
            this.Button_modi.TabStop = false;
            this.Button_modi.Click += new System.EventHandler(this.Button_modi_Click);
            // 
            // Button_add
            // 
            this.Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_add.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.Image")));
            this.Button_add.Location = new System.Drawing.Point(416, 66);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(32, 32);
            this.Button_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_add.TabIndex = 53;
            this.Button_add.TabStop = false;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Modifier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Supprimer";
            // 
            // F_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(959, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_sup);
            this.Controls.Add(this.Button_modi);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.Textbox_id);
            this.Controls.Add(this.dataGridView_list);
            this.Controls.Add(this.Textbox_nam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_event";
            this.Text = "F_event";
            this.Load += new System.EventHandler(this.F_event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_modi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_nam;
        private System.Windows.Forms.DataGridView dataGridView_list;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Button_sup;
        private System.Windows.Forms.PictureBox Button_modi;
        private System.Windows.Forms.PictureBox Button_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}