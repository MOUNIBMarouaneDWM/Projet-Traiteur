namespace Gestion_traiteur
{
    partial class F_cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_cmd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxEtat = new System.Windows.Forms.GroupBox();
            this.comboBoxETAT = new System.Windows.Forms.ComboBox();
            this.comboBoxEven = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxEvenement = new System.Windows.Forms.GroupBox();
            this.textBoxCIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxCin = new System.Windows.Forms.GroupBox();
            this.Nbr_chaise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repas2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repas3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LieuC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evenm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonEven = new System.Windows.Forms.RadioButton();
            this.radioButtonETAT = new System.Windows.Forms.RadioButton();
            this.radioButtonCIN = new System.Windows.Forms.RadioButton();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nbr_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Dgv_com = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEtat.SuspendLayout();
            this.groupBoxEvenement.SuspendLayout();
            this.groupBoxCin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_com)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Etat:";
            // 
            // groupBoxEtat
            // 
            this.groupBoxEtat.Controls.Add(this.comboBoxETAT);
            this.groupBoxEtat.Controls.Add(this.label6);
            this.groupBoxEtat.Location = new System.Drawing.Point(192, 39);
            this.groupBoxEtat.Name = "groupBoxEtat";
            this.groupBoxEtat.Size = new System.Drawing.Size(186, 86);
            this.groupBoxEtat.TabIndex = 33;
            this.groupBoxEtat.TabStop = false;
            // 
            // comboBoxETAT
            // 
            this.comboBoxETAT.FormattingEnabled = true;
            this.comboBoxETAT.Location = new System.Drawing.Point(63, 27);
            this.comboBoxETAT.Name = "comboBoxETAT";
            this.comboBoxETAT.Size = new System.Drawing.Size(117, 21);
            this.comboBoxETAT.TabIndex = 10;
            this.comboBoxETAT.SelectedIndexChanged += new System.EventHandler(this.comboBoxETAT_SelectedIndexChanged);
            // 
            // comboBoxEven
            // 
            this.comboBoxEven.FormattingEnabled = true;
            this.comboBoxEven.Location = new System.Drawing.Point(69, 29);
            this.comboBoxEven.Name = "comboBoxEven";
            this.comboBoxEven.Size = new System.Drawing.Size(117, 21);
            this.comboBoxEven.TabIndex = 9;
            this.comboBoxEven.SelectedIndexChanged += new System.EventHandler(this.comboBoxEven_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enenement:";
            // 
            // groupBoxEvenement
            // 
            this.groupBoxEvenement.Controls.Add(this.comboBoxEven);
            this.groupBoxEvenement.Controls.Add(this.label3);
            this.groupBoxEvenement.Location = new System.Drawing.Point(384, 39);
            this.groupBoxEvenement.Name = "groupBoxEvenement";
            this.groupBoxEvenement.Size = new System.Drawing.Size(186, 86);
            this.groupBoxEvenement.TabIndex = 34;
            this.groupBoxEvenement.TabStop = false;
            // 
            // textBoxCIN
            // 
            this.textBoxCIN.Location = new System.Drawing.Point(59, 32);
            this.textBoxCIN.Name = "textBoxCIN";
            this.textBoxCIN.Size = new System.Drawing.Size(117, 20);
            this.textBoxCIN.TabIndex = 22;
            this.textBoxCIN.TextChanged += new System.EventHandler(this.textBoxCIN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CIN:";
            // 
            // groupBoxCin
            // 
            this.groupBoxCin.Controls.Add(this.textBoxCIN);
            this.groupBoxCin.Controls.Add(this.label4);
            this.groupBoxCin.Location = new System.Drawing.Point(1, 39);
            this.groupBoxCin.Name = "groupBoxCin";
            this.groupBoxCin.Size = new System.Drawing.Size(185, 86);
            this.groupBoxCin.TabIndex = 31;
            this.groupBoxCin.TabStop = false;
            // 
            // Nbr_chaise
            // 
            this.Nbr_chaise.HeaderText = "Nombre chaise";
            this.Nbr_chaise.Name = "Nbr_chaise";
            this.Nbr_chaise.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Recherche par:";
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            // 
            // Id_cmd
            // 
            this.Id_cmd.HeaderText = "Numéro commande";
            this.Id_cmd.Name = "Id_cmd";
            this.Id_cmd.ReadOnly = true;
            // 
            // Cin
            // 
            this.Cin.HeaderText = "Client";
            this.Cin.Name = "Cin";
            this.Cin.ReadOnly = true;
            // 
            // Repas1
            // 
            this.Repas1.HeaderText = "Repas 1";
            this.Repas1.Name = "Repas1";
            this.Repas1.ReadOnly = true;
            // 
            // Repas2
            // 
            this.Repas2.HeaderText = "Repas 2";
            this.Repas2.Name = "Repas2";
            this.Repas2.ReadOnly = true;
            // 
            // Repas3
            // 
            this.Repas3.HeaderText = "Repas 3";
            this.Repas3.Name = "Repas3";
            this.Repas3.ReadOnly = true;
            // 
            // LieuC
            // 
            this.LieuC.HeaderText = "Lieu prévu";
            this.LieuC.Name = "LieuC";
            this.LieuC.ReadOnly = true;
            // 
            // DateP
            // 
            this.DateP.HeaderText = "Date prévue";
            this.DateP.Name = "DateP";
            this.DateP.ReadOnly = true;
            // 
            // PrixC
            // 
            this.PrixC.HeaderText = "Prix Total";
            this.PrixC.Name = "PrixC";
            this.PrixC.ReadOnly = true;
            // 
            // Evenm
            // 
            this.Evenm.HeaderText = "Evenement";
            this.Evenm.Name = "Evenm";
            this.Evenm.ReadOnly = true;
            // 
            // radioButtonEven
            // 
            this.radioButtonEven.AutoSize = true;
            this.radioButtonEven.Location = new System.Drawing.Point(224, 16);
            this.radioButtonEven.Name = "radioButtonEven";
            this.radioButtonEven.Size = new System.Drawing.Size(79, 17);
            this.radioButtonEven.TabIndex = 30;
            this.radioButtonEven.TabStop = true;
            this.radioButtonEven.Text = "Evenement";
            this.radioButtonEven.UseVisualStyleBackColor = true;
            this.radioButtonEven.CheckedChanged += new System.EventHandler(this.radioButtonEven_CheckedChanged);
            // 
            // radioButtonETAT
            // 
            this.radioButtonETAT.AutoSize = true;
            this.radioButtonETAT.Location = new System.Drawing.Point(142, 16);
            this.radioButtonETAT.Name = "radioButtonETAT";
            this.radioButtonETAT.Size = new System.Drawing.Size(44, 17);
            this.radioButtonETAT.TabIndex = 29;
            this.radioButtonETAT.TabStop = true;
            this.radioButtonETAT.Text = "Etat";
            this.radioButtonETAT.UseVisualStyleBackColor = true;
            this.radioButtonETAT.CheckedChanged += new System.EventHandler(this.radioButtonETAT_CheckedChanged);
            // 
            // radioButtonCIN
            // 
            this.radioButtonCIN.AutoSize = true;
            this.radioButtonCIN.Location = new System.Drawing.Point(73, 16);
            this.radioButtonCIN.Name = "radioButtonCIN";
            this.radioButtonCIN.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCIN.TabIndex = 26;
            this.radioButtonCIN.TabStop = true;
            this.radioButtonCIN.Text = "CIN";
            this.radioButtonCIN.UseVisualStyleBackColor = true;
            this.radioButtonCIN.CheckedChanged += new System.EventHandler(this.radioButtonCIN_CheckedChanged);
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // Nbr_table
            // 
            this.Nbr_table.HeaderText = "Nombre Table";
            this.Nbr_table.Name = "Nbr_table";
            this.Nbr_table.ReadOnly = true;
            // 
            // Payer
            // 
            this.Payer.HeaderText = "Payé";
            this.Payer.Name = "Payer";
            this.Payer.ReadOnly = true;
            // 
            // Button_add
            // 
            this.Button_add.BackColor = System.Drawing.Color.Transparent;
            this.Button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_add.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.Image")));
            this.Button_add.ImageActive = null;
            this.Button_add.Location = new System.Drawing.Point(685, 66);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(39, 35);
            this.Button_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_add.TabIndex = 24;
            this.Button_add.TabStop = false;
            this.Button_add.Zoom = 10;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(666, 104);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 9);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Ajouter une command";
            // 
            // Dgv_com
            // 
            this.Dgv_com.AllowUserToAddRows = false;
            this.Dgv_com.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgv_com.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_com.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_com.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Dgv_com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_com.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.cmd,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.Dgv_com.GridColor = System.Drawing.Color.White;
            this.Dgv_com.Location = new System.Drawing.Point(1, 142);
            this.Dgv_com.Name = "Dgv_com";
            this.Dgv_com.ReadOnly = true;
            this.Dgv_com.Size = new System.Drawing.Size(799, 283);
            this.Dgv_com.TabIndex = 35;
            this.Dgv_com.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_com_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            // 
            // cmd
            // 
            this.cmd.HeaderText = "Numéro commande";
            this.cmd.Name = "cmd";
            this.cmd.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Client";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Repas 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Repas 2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Repas 3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Lieu prévu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Date prévue";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Prix Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Evenement";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Etat";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Payé";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre Table";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Nombre chaise";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // F_cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_com);
            this.Controls.Add(this.groupBoxEtat);
            this.Controls.Add(this.groupBoxEvenement);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.groupBoxCin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.radioButtonEven);
            this.Controls.Add(this.radioButtonETAT);
            this.Controls.Add(this.radioButtonCIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_cmd";
            this.Text = "command";
            this.Load += new System.EventHandler(this.F_cmd_Load);
            this.groupBoxEtat.ResumeLayout(false);
            this.groupBoxEtat.PerformLayout();
            this.groupBoxEvenement.ResumeLayout(false);
            this.groupBoxEvenement.PerformLayout();
            this.groupBoxCin.ResumeLayout(false);
            this.groupBoxCin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_com)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxEtat;
        private System.Windows.Forms.ComboBox comboBoxETAT;
        private System.Windows.Forms.ComboBox comboBoxEven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxEvenement;
        private System.Windows.Forms.TextBox textBoxCIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxCin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nbr_chaise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repas3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evenm;
        private System.Windows.Forms.RadioButton radioButtonEven;
        private System.Windows.Forms.RadioButton radioButtonETAT;
        private System.Windows.Forms.RadioButton radioButtonCIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nbr_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payer;
        private Bunifu.Framework.UI.BunifuImageButton Button_add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView Dgv_com;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}