namespace Gestion_traiteur
{
    partial class F_repas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_repas));
            this.Textbox_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_prix = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DataGrid_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Textbox_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button_sup = new System.Windows.Forms.PictureBox();
            this.Button_modi = new System.Windows.Forms.PictureBox();
            this.Button_add = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_modi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_nom
            // 
            this.Textbox_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Textbox_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_nom.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_nom.HintText = "";
            this.Textbox_nom.isPassword = false;
            this.Textbox_nom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_nom.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Textbox_nom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_nom.LineThickness = 3;
            this.Textbox_nom.Location = new System.Drawing.Point(63, 166);
            this.Textbox_nom.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_nom.Name = "Textbox_nom";
            this.Textbox_nom.Size = new System.Drawing.Size(151, 33);
            this.Textbox_nom.TabIndex = 0;
            this.Textbox_nom.Text = "Nom de repas";
            this.Textbox_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_nom.Enter += new System.EventHandler(this.Textbox_nom_Enter);
            this.Textbox_nom.Leave += new System.EventHandler(this.Textbox_nom_Leave);
            // 
            // Textbox_prix
            // 
            this.Textbox_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Textbox_prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_prix.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_prix.HintText = "";
            this.Textbox_prix.isPassword = false;
            this.Textbox_prix.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_prix.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Textbox_prix.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.Textbox_prix.LineThickness = 3;
            this.Textbox_prix.Location = new System.Drawing.Point(63, 214);
            this.Textbox_prix.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_prix.Name = "Textbox_prix";
            this.Textbox_prix.Size = new System.Drawing.Size(151, 33);
            this.Textbox_prix.TabIndex = 1;
            this.Textbox_prix.Text = "Prix";
            this.Textbox_prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DataGrid_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_list.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_list.DoubleBuffered = true;
            this.DataGrid_list.EnableHeadersVisualStyles = false;
            this.DataGrid_list.GridColor = System.Drawing.Color.White;
            this.DataGrid_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.DataGrid_list.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.DataGrid_list.Location = new System.Drawing.Point(323, 100);
            this.DataGrid_list.Name = "DataGrid_list";
            this.DataGrid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_list.Size = new System.Drawing.Size(320, 202);
            this.DataGrid_list.TabIndex = 41;
            this.DataGrid_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_list_CellClick);
            // 
            // Textbox_id
            // 
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
            this.Textbox_id.Location = new System.Drawing.Point(63, 118);
            this.Textbox_id.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_id.Name = "Textbox_id";
            this.Textbox_id.Size = new System.Drawing.Size(151, 33);
            this.Textbox_id.TabIndex = 42;
            this.Textbox_id.Text = "ID";
            this.Textbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_id.Enter += new System.EventHandler(this.Textbox_id_Enter);
            this.Textbox_id.Leave += new System.EventHandler(this.Textbox_id_Leave);
            // 
            // Button_sup
            // 
            this.Button_sup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_sup.Image = ((System.Drawing.Image)(resources.GetObject("Button_sup.Image")));
            this.Button_sup.Location = new System.Drawing.Point(531, 37);
            this.Button_sup.Name = "Button_sup";
            this.Button_sup.Size = new System.Drawing.Size(32, 32);
            this.Button_sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_sup.TabIndex = 51;
            this.Button_sup.TabStop = false;
            this.Button_sup.Click += new System.EventHandler(this.Button_sup_Click);
            // 
            // Button_modi
            // 
            this.Button_modi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_modi.Image = ((System.Drawing.Image)(resources.GetObject("Button_modi.Image")));
            this.Button_modi.Location = new System.Drawing.Point(449, 37);
            this.Button_modi.Name = "Button_modi";
            this.Button_modi.Size = new System.Drawing.Size(32, 32);
            this.Button_modi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_modi.TabIndex = 50;
            this.Button_modi.TabStop = false;
            this.Button_modi.Click += new System.EventHandler(this.Button_modi_Click);
            // 
            // Button_add
            // 
            this.Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_add.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.Image")));
            this.Button_add.Location = new System.Drawing.Point(367, 37);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(32, 32);
            this.Button_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_add.TabIndex = 49;
            this.Button_add.TabStop = false;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nouveau";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Supprimer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Modifier";
            // 
            // F_repas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(697, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_sup);
            this.Controls.Add(this.Button_modi);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.Textbox_id);
            this.Controls.Add(this.DataGrid_list);
            this.Controls.Add(this.Textbox_prix);
            this.Controls.Add(this.Textbox_nom);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_repas";
            this.Text = "F_repas";
            this.Load += new System.EventHandler(this.F_repas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_modi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_nom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_prix;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_list;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_id;
        private System.Windows.Forms.PictureBox Button_sup;
        private System.Windows.Forms.PictureBox Button_modi;
        private System.Windows.Forms.PictureBox Button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}