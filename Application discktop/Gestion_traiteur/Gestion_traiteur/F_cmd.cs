using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_traiteur
{
    public partial class F_cmd : Form
    {
        public F_cmd()
        {
            InitializeComponent();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            Program.ajt_cmd = true;
            F_ajout_Cmd f = new F_ajout_Cmd();
            f.Show();
        }
        Point p = new Point(2, 39);
        Point o = new Point(385, 39);

        


        string reqload = @"select c.id_cmd as 'id',
		cl.Nom_C+' '+cl.Prenom_C+' ('+cl.CIN_C+')' as Client,
		r1.Nom_R+' ('+CONVERT(varchar(20),c.qtR1)+')' as 'R1',
		r2.Nom_R+' ('+CONVERT(varchar(20),c.qtR2)+')' as 'R2',
		r3.Nom_R+' ('+CONVERT(varchar(20),c.qtR3)+')' as 'R3',
		c.lieu_cmd as 'LieuC',
		c.dateD as 'dateP',
		c.prix_cmd as 'PrixCmd',
		ev.Nom_Ev as 'Ev',
		et.Etat as 'Etat',
		c.payer as 'payer'

		from commande c
		LEFT join repas r1	
		on r1.Id_R=c.repas1
		LEFT join repas r2
		on r2.Id_R=c.repas2
		LEFT join Repas r3
		on r3.Id_R=c.repas3
		LEFT join Etat et
		on et.Id_Etat=c.etat
		LEFT join Evenement ev
		on ev.Id_Ev=c.evenement
		LEFT join Client cl
		on cl.CIN_C=c.client";
        string reqR = @"select R.id_cmd 'Cmd',R.id_O 'idO',R.Nbr 'Nbr' from Reserver R
                        join Commande C
                        on R.id_cmd=C.Id_cmd
                        ";
        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Actu(string req)
        {
            Dgv_com.Rows.Clear();

            string id, cin, R1, R2, R3, DateP, LieuC, PrixCmd, Ev, Etat, payer, Table = "0", Chaise = "0";


            DataTable dt = Program.ExecuterSelection(req);
            DataTable DTR = new DataTable();


            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    ///Commande
                    id = dt.Rows[i]["id"].ToString();
                    cin = dt.Rows[i]["Client"].ToString();
                    R1 = dt.Rows[i]["R1"].ToString();
                    R2 = dt.Rows[i]["R2"].ToString();
                    R3 = dt.Rows[i]["R3"].ToString();
                    DateP = dt.Rows[i]["DateP"].ToString();
                    LieuC = dt.Rows[i]["LieuC"].ToString();
                    PrixCmd = dt.Rows[i]["PrixCmd"].ToString();
                    Ev = dt.Rows[i]["Ev"].ToString();
                    Etat = dt.Rows[i]["Etat"].ToString();
                    if (dt.Rows[i]["payer"].ToString() == "1")
                    {
                        payer = "Oui";
                    }
                    else
                    {
                        payer = "Nom";
                    }

                    //Resarver
                    DTR = Program.ExecuterSelection(reqR);
                    if (DTR.Rows.Count != 0)
                    {
                        string reqTable = reqR + " where R.id_O=1 and R.id_cmd=" + id;
                        DataTable dtTable = Program.ExecuterSelection(reqTable);
                        if (dtTable.Rows.Count != 0)
                        {
                            Table = dtTable.Rows[0]["Nbr"].ToString();
                        }
                        else
                        {
                            Table = "0";
                        }
                        string reqChaise = reqR + " where R.id_O=2 and R.id_cmd=" + id;
                        DataTable dtChaise = Program.ExecuterSelection(reqChaise);
                        if (dtChaise.Rows.Count != 0)
                        {
                            Chaise = dtChaise.Rows[0]["Nbr"].ToString();
                        }
                        else
                        {
                            Chaise = "0";
                        }


                    }
                    Dgv_com.Rows.Add("Modifier", "Supprimer", id, cin, R1, R2, R3, LieuC, DateP, PrixCmd, Ev, Etat, payer, Table, Chaise);




                }

            }
        }
        private void visibl()
        {


            if (radioButtonCIN.Checked)
            {
                groupBoxCin.Location = p;
            
                groupBoxEtat.Location = o;
                groupBoxEvenement.Location = o;
                groupBoxCin.Visible = true;
             
                groupBoxEtat.Visible = false;
                groupBoxEvenement.Visible = false;
            }
         
            else if (radioButtonETAT.Checked)
            {
                groupBoxCin.Location = o;
              
                groupBoxEtat.Location = p;
                groupBoxEvenement.Location = o;
                groupBoxCin.Visible = false;
               
                groupBoxEtat.Visible = true;
                groupBoxEvenement.Visible = false;
            }
            else
            {
                groupBoxCin.Location = o;
               
                groupBoxEtat.Location = o;
                groupBoxEvenement.Location = p;
                groupBoxCin.Visible = false;
               
                groupBoxEtat.Visible = false;
                groupBoxEvenement.Visible = true;
            }
        }

        private void F_cmd_Load(object sender, EventArgs e)
        {
            //etat

            string reqEtat = "select * from Etat";
            comboBoxETAT.DisplayMember = "Etat";
            comboBoxETAT.ValueMember = "Id_Etat";
            comboBoxETAT.DataSource = Program.ExecuterSelection(reqEtat);


            //even
            string reqEv = "select * from Evenement";
            comboBoxEven.DisplayMember = "Nom_Ev";
            comboBoxEven.ValueMember = "Id_Ev";
            comboBoxEven.DataSource = Program.ExecuterSelection(reqEv);

            radioButtonCIN.Checked = true;
            groupBoxCin.Visible = true;
          
            groupBoxEtat.Visible = false;
            groupBoxEvenement.Visible = false;
            groupBoxCin.Location = p;
           
            groupBoxEtat.Location = o;
            groupBoxEvenement.Location = o;
            Actu(reqload);

        }

        private void dataGridView_liste_cmd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Program.ajt_cmd = false;
            ////if (e.RowIndex >= 0)
            ////{
            ////    DataGridViewRow row = this.dataGridView_liste_cmd.Rows[e.RowIndex];
            ////    Program.ID_cmd = int.Parse(row.Cells[0].Value.ToString());



            ////}
            F_ajout_Cmd f = new F_ajout_Cmd();
            f.Show();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_com_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (e.ColumnIndex == 0)
            {

                Program.ajt_cmd = false;
                //client = Dgv_com.Rows[i].Cells["cin"].Value.ToString();
                Program.ID_cmd =Dgv_com.Rows[i].Cells["cmd"].Value.ToString();
                F_ajout_Cmd f = new F_ajout_Cmd();
                f.Show();
                

                ////foreach (DataGridViewColumn column in Dgv_com.Columns)
                ////{
                ////    dtform.Columns.Add(column.Name, column.CellType);

                ////}
                ////dtform.Rows.Add();
                ////for (int j = 0; j < Dgv_com.Columns.Count; j++)
                ////    {
                ////        dtform.Rows[i][j] = Dgv_com.SelectedRows[i].Cells[j].Value;

                ////    }
                //Form4 F = new Form4();
                //F.Show();





            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult result = MessageBox.Show("Etes-vous sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = e.RowIndex;
                    string commande = Dgv_com.Rows[index].Cells[2].Value.ToString();
                    string reqDelRes = "delete reserver where id_cmd=" + commande;
                    string reqSupC = "delete commande where id_cmd=" + commande;
                    Program.ExecuterMaj(reqDelRes);
                    Program.ExecuterMaj(reqSupC);
                    MessageBox.Show("Kayn WP");
                    Actu(reqload);
                }
                else
                {

                }
            }
        }

        private void radioButtonCIN_CheckedChanged(object sender, EventArgs e)
        {
            visibl();
        }

        private void radioButtonDATE_CheckedChanged(object sender, EventArgs e)
        {
            visibl();
        }

        private void radioButtonETAT_CheckedChanged(object sender, EventArgs e)
        {
            visibl();
        }

        private void radioButtonEven_CheckedChanged(object sender, EventArgs e)
        {
            visibl();
        }

        private void textBoxCIN_TextChanged(object sender, EventArgs e)
        {
            string req = reqload + " where client like'" + textBoxCIN.Text + "%'";
            Actu(req);
        }

        private void comboBoxETAT_SelectedIndexChanged(object sender, EventArgs e)
        {

            string req = reqload + " where c.Etat= " + comboBoxETAT.SelectedValue;
            Actu(req);
        }

        private void comboBoxEven_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = reqload + " where Evenement= " + comboBoxEven.SelectedValue;
            Actu(req);
        }

        private void Button_add_Click_1(object sender, EventArgs e)
        {
            Program.ajt_cmd = true;
            F_ajout_Cmd f = new F_ajout_Cmd();
            f.Show();
        }
    }
}
