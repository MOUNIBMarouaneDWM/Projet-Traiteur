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
    public partial class F_ajout_Cmd : Form
    {
        public F_ajout_Cmd()
        {
            InitializeComponent();
        }
        string idR1, idR2, idR3;
        string reqR = "select * from Repas";
        DataTable dtTbale, dtChaise;
        string tableM, chaiseM;
        string r1 = "", r2 = "", r3 = "";
        string idCmd = null, repas1 = null, repas2 = null, repas3 = null, dateD, lieu_cmd, prix_cmd, etat, client, even;
        char payer;
        int qtr1=0, qtr2=0, qtr3=0;
        string tableC, chaiseC;
        decimal pR1 = 0, pR2 = 0, pR3 = 0, pt = 0, pc = 0, PTl = 0 ;
        decimal qr1 = 0, qr2 = 0, qr3 = 0, qt = 0, gt = 0, qc = 0;
        string reqRpIdCmd = "select Max(Id_cmd )from Commande ";

        private void updateObjet(string IdCommand)
        {
            

            DataTable dtVT, dtVCh;
            string reqTV = "select * from reserver where id_cmd="+IdCommand + " and id_O=1";
            string reqChV = "select * from reserver where id_cmd=" + IdCommand + " and id_O=2";
            dtVT = Program.ExecuterSelection(reqTV);
            dtVCh = Program.ExecuterSelection(reqChV);

            if (checkBoxT.Checked)
            {
               
                   
                    if (dtVT.Rows.Count != 0)
                    {
                        string reqUPT = "update Reserver set Nbr = " + tableC + " where id_O = 1 and id_cmd = " + IdCommand;
                        Program.ExecuterMaj(reqUPT);
                    }
                    else
                    {
                        string reqTableR = "insert into Reserver values (" + IdCommand + ",1," + tableC + ")";
                        Program.ExecuterMaj(reqTableR);

                    }
            }
            else
            {
                if(dtVT.Rows.Count!=0)
                {
                    string reqDelT = "delete reserver where id_cmd=" + IdCommand + " and id_o=1";
                    Program.ExecuterMaj(reqDelT);
                }
                else
                {

                }
            }
            

            if (checkBoxCh.Checked)
            {
               
                if (dtVCh.Rows.Count != 0)
                {
                    string reqUPCh = "update Reserver set Nbr = " + chaiseC + " where id_O = 2 and id_cmd = " + Program.ID_cmd;
                    Program.ExecuterMaj(reqUPCh);
                }
                else
                {
                    string reqChaiseR = "insert into Reserver values (" + IdCommand + ",2," + chaiseC + ")";
                    Program.ExecuterMaj(reqChaiseR);
                }

            }
            else
            {
                if (dtVCh.Rows.Count != 0)
                {
                    string reqDelCh = "delete reserver where id_cmd=" + IdCommand + " and id_o=2";
                    Program.ExecuterMaj(reqDelCh);
                }
                else
                {

                }
            }
        }







        private void remplir()
        {
            
            string reqT = "select * from reserver where id_cmd=" + Program.ID_cmd + "and id_O=1";
            DataTable dtT = Program.ExecuterSelection(reqT);
            if (dtT.Rows.Count != 0)
            {
                checkBoxT.Checked = true;
                updown_nbrT.Enabled = true;
                updown_nbrT.Value = int.Parse(dtT.Rows[0]["Nbr"].ToString());

            }
            else
            {
                checkBoxT.Checked = false;
                updown_nbrT.Enabled = false;
                updown_nbrT.Value = 0;
            }
            string reqCh = "select * from reserver where id_cmd=" + Program.ID_cmd + "and id_O=2";
            DataTable dtCh = Program.ExecuterSelection(reqCh);
            if (dtCh.Rows.Count != 0)
            {
                checkBoxCh.Checked = true;
                updown_nbrCh.Enabled = true;
                updown_nbrCh.Value = int.Parse(dtCh.Rows[0]["Nbr"].ToString());

            }
            else
            {
                checkBoxCh.Checked = false;
                updown_nbrCh.Enabled = false;
                updown_nbrCh.Value = 0;
            }
        }
        private void updown_nbrCh_ValueChanged(object sender, EventArgs e)
        {
            textBox_total.Text = calculPrix().ToString();
        }

        private void updown_QR1_ValueChanged(object sender, EventArgs e)
        {
            textBox_total.Text = calculPrix().ToString();
        }

        private void updown_QR2_ValueChanged(object sender, EventArgs e)
        {
            textBox_total.Text = calculPrix().ToString();
        }

        private void updown_QR3_ValueChanged(object sender, EventArgs e)
        {
            textBox_total.Text = calculPrix().ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_ajout_Cmd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ajt_cmd = false;
            Program.ajt_cmd_C = false;
          
        }

        private void F_ajout_Cmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ajt_cmd = false;
            Program.ajt_cmd_C = false;
        }

        private void Textbox_adrs_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void remplirobjet(string idCommende)
        {

                if (checkBoxT.Checked && checkBoxCh.Checked)
                {
                    string reqTableR = "insert into Reserver values (" + idCommende + ",1," + tableC + ")";
                    Program.ExecuterMaj(reqTableR);
                    string reqChaiseR = "insert into Reserver values (" + idCommende + ",2," + chaiseC + ")";
                    Program.ExecuterMaj(reqChaiseR);


                }
                else if (checkBoxT.Checked)
                {
                    string reqTableR = "insert into Reserver values (" + idCommende + ",1," + tableC + ")";
                    Program.ExecuterMaj(reqTableR);


                }
                else if (checkBoxCh.Checked)
                {

                    string reqChaiseR = "insert into Reserver values (" + idCommende + ",2," + chaiseC + ")";
                    Program.ExecuterMaj(reqChaiseR);
                    pc = Convert.ToDecimal(Program.ExecuterScalaire("select Prix_O from Objet where Id_O=2"));

                }
            textBox_total.Text = calculPrix().ToString();
        }
        private void reqqload()
        {

            string reqPart = "select * from Repas except select * from Repas where Id_R=";
            string reqGen = "select * from Repas";
            int index = 0;



            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                r1 = comboBox1.SelectedValue.ToString();
                //MessageBox.Show(r1);
                r2 = comboBox2.SelectedValue.ToString();
                r3 = comboBox3.SelectedValue.ToString();
                //MessageBox.Show(r2);
                //MessageBox.Show(r3);
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                r1 = comboBox1.SelectedValue.ToString();
                r2 = comboBox2.SelectedValue.ToString();
            }
            else
            {
                r1 = comboBox1.SelectedValue.ToString();
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                if (idR1 != r1)
                {


                    string reqR2 = reqPart + comboBox1.SelectedValue;
                    comboBox2.ValueMember = "Id_R";
                    comboBox2.DisplayMember = "Nom_R";
                    comboBox2.DataSource = Program.ExecuterSelection(reqR2);
                    string reqR3 = reqPart + comboBox1.SelectedValue + " or Id_R=" + comboBox2.SelectedValue;
                    comboBox3.ValueMember = "Id_R";
                    comboBox3.DisplayMember = "Nom_R";
                    comboBox3.DataSource = Program.ExecuterSelection(reqR3);

                    //string reqR1 = "select Nom_R from Repas where Id_R= " + r1;
                    //comboBox1.ValueMember = "Id_R";
                    //comboBox1.DisplayMember = "Nom_R";
                    //comboBox1.DataSource = Program.ExecuterSelection(reqGen);
                    idR1 = r1;
                    idR2 = comboBox2.SelectedValue.ToString();
                    idR3 = comboBox3.SelectedValue.ToString();
                    //comboBox1.Text = Program.ExecuterScalaire("select Nom_R from repas where Id_R=" + r1);




                }
                else if (idR2 != r2)
                {
                    //string reqR2 = reqPart + comboBox1.SelectedValue;
                    //comboBox2.ValueMember = "Id_R";
                    //comboBox2.DisplayMember = "Nom_R";
                    //comboBox2.DataSource = Program.ExecuterSelection(reqR2);
                    string reqR3 = reqPart + comboBox1.SelectedValue + " or Id_R=" + comboBox2.SelectedValue;
                    comboBox3.ValueMember = "Id_R";
                    comboBox3.DisplayMember = "Nom_R";
                    comboBox3.DataSource = Program.ExecuterSelection(reqR3);

                    //string reqR1 = "select Nom_R from Repas where Id_R= " + r1;
                    //comboBox1.ValueMember = "Id_R";
                    //comboBox1.DisplayMember = "Nom_R";
                    //comboBox1.DataSource = Program.ExecuterSelection(reqGen);

                    idR2 = r2;
                    idR3 = comboBox3.SelectedValue.ToString();
                    //comboBox1.Text = Program.ExecuterScalaire("select Nom_R from repas where Id_R=" + r1);

                }

            }



        }
        private decimal calculPrix()
        {
            if (checkBox3.Checked)
            {

                pR3 = Convert.ToDecimal(Program.ExecuterScalaire("select Prix_R from Repas where Id_R=" + comboBox3.SelectedValue));


                qr3 = updown_QR3.Value;

            }
            else
                qr3 = 0;

            if (checkBox2.Checked)
            {
                pR2 = Convert.ToDecimal(Program.ExecuterScalaire("select Prix_R from Repas where Id_R=" + comboBox2.SelectedValue));

                qr2 = updown_QR2.Value;

            }
            else
                qr2 = 0;
            if (checkBox1.Checked)
            {
                pR1 = Convert.ToDecimal(Program.ExecuterScalaire("select Prix_R from Repas where Id_R=" + comboBox1.SelectedValue));

                qr1 = updown_QR1.Value;

            }
            else
                qr1 = 0;


            if (checkBoxT.Checked)
            {
                pt = Convert.ToDecimal(Program.ExecuterScalaire("select Prix_O from Objet where Id_O=1"));
                qt = updown_nbrT.Value;


            }
            else
                qt = 0;
            if (checkBoxCh.Checked)
            {
                pc = Convert.ToDecimal(Program.ExecuterScalaire("select Prix_O from Objet where Id_O=2"));
                qc = updown_nbrCh.Value;

            }
            else
                qc = 0;

            PTl = (pR1 * qr1) + (pR2 * qr2) + (pR3 * qr3) + pt * qt + pc * qc;
            return PTl;

        }

        private void F_ajout_Cmd_Load(object sender, EventArgs e)
        {
            string reqEv = "select * from Evenement";
            comboBox_event.DisplayMember = "Nom_Ev";
            comboBox_event.ValueMember = "Id_Ev";
            comboBox_event.DataSource = Program.ExecuterSelection(reqEv);
            string reEt = "select * from etat";
            comboBoxEtat.DisplayMember = "Etat";
            comboBoxEtat.ValueMember = "Id_Etat";
            comboBoxEtat.DataSource = Program.ExecuterSelection(reEt);

            if (Program.ajt_cmd)
            {

                Button_add.Visible = true;
                Button_modi.Visible = false;
           
                groupBoxTR.Visible = false;
                radioButton_eqauls_nom.Checked = true;

               

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;

                updown_nbrT.Enabled = false;
                updown_nbrCh.Enabled = false;

                updown_QR1.Enabled = false;
                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;
                dtTbale = Program.ExecuterSelection("select * from Objet where Id_O=1");
                tableM = dtTbale.Rows[0]["Quantite"].ToString();
                updown_nbrT.Maximum = int.Parse(tableM);
                updown_nbrT.Minimum = 0;
                dtChaise = Program.ExecuterSelection("select * from Objet where Id_O=2");
                chaiseM = dtChaise.Rows[0]["Quantite"].ToString();
                updown_nbrCh.Maximum = int.Parse(chaiseM);
                updown_nbrCh.Minimum = 0;

            }
            else
            {
                Button_add.Visible = false;
                Button_modi.Visible = true;
                string reqCmd = "select * from commande where id_cmd =" + Program.ID_cmd;
                DataTable dt = Program.ExecuterSelection(reqCmd);
                Textbox_adrs.Text = dt.Rows[0]["Lieu_cmd"].ToString();
                Textbox_CIN.Text = dt.Rows[0]["client"].ToString();
                //MessageBox.Show(dt.Rows[0]["Repas2"].ToString());
                if(dt.Rows[0]["Repas1"].ToString()!=""&& dt.Rows[0]["Repas2"].ToString() != ""&&dt.Rows[0]["Repas3"].ToString() != "")
                {
                    string reqR1 = "select Nom_R from Repas where Id_R=" + dt.Rows[0]["repas1"].ToString();
                    comboBox1.Text = Program.ExecuterScalaire(reqR1);
                    string reqR2 = "select Nom_R from Repas where Id_R=" + dt.Rows[0]["repas1"].ToString();
                    comboBox2.Text = Program.ExecuterScalaire(reqR2);
                    string reqR3 = "select Nom_R from Repas where Id_R=" + dt.Rows[0]["repas1"].ToString();
                    comboBox3.Text = Program.ExecuterScalaire(reqR3);
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    updown_QR1.Minimum = 0;
                    updown_QR2.Minimum = 0;
                    updown_QR3.Minimum = 0;
                    updown_QR1.Value=int.Parse(dt.Rows[0]["qtR1"].ToString());
                    updown_QR2.Value = int.Parse(dt.Rows[0]["qtR2"].ToString());
                    updown_QR3.Value = int.Parse(dt.Rows[0]["qtR3"].ToString());
                    remplir();
                    if(updown_QR1.Value==updown_QR2.Value&&updown_QR2.Value==updown_QR3.Value&&updown_QR3.Value==updown_nbrT.Value)
                    {
                        radioButton_eqauls_oui.Checked = true;
                    }
                    else
                    {
                        radioButton_eqauls_nom.Checked = true;
                    }


                }
                else if(dt.Rows[0]["Repas1"].ToString() != "" && dt.Rows[0]["Repas2"].ToString() !="")
                {
                    string reqR1 = "select Nom_R from Repas where Id_R=" + dt.Rows[0]["repas1"].ToString();
                    comboBox1.Text = Program.ExecuterScalaire(reqR1);
                    string reqR2 = "select Nom_R from Repas where Id_R=" + dt.Rows[0]["repas1"].ToString();
                    comboBox2.Text = Program.ExecuterScalaire(reqR2); 
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = false;
                    updown_QR1.Value = int.Parse(dt.Rows[0]["qtR1"].ToString());
                    updown_QR2.Value = int.Parse(dt.Rows[0]["qtR2"].ToString());
                    updown_QR3.Value = 0;
                    
                    comboBox3.Enabled = false;
                   
                    remplir();
                    if (updown_QR1.Value == updown_QR2.Value && updown_QR2.Value == updown_nbrT.Value)
                    {
                        radioButton_eqauls_oui.Checked = true;
                    }
                    else
                    {
                        radioButton_eqauls_nom.Checked = true;
                    }
                }
                else if(dt.Rows[0]["Repas1"].ToString()!= "")
                {
                    string reqR1 = "select Nom_R from Repas where Id_R=" + dt.Rows[0]["repas1"].ToString();
                    comboBox1.Text = Program.ExecuterScalaire(reqR1);
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    updown_QR1.Value = int.Parse(dt.Rows[0]["qtR1"].ToString());
                    updown_QR2.Value = 0;
                    updown_QR3.Value = 0;
                    updown_QR3.Value = 0;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    checkBox3.Enabled = false;
                    remplir();
                    if (updown_QR1.Value == updown_nbrT.Value)
                    {
                        radioButton_eqauls_oui.Checked = true;
                    }
                    else
                    {
                        radioButton_eqauls_nom.Checked = true;
                    }
                    
                }
                string reqEtat = "select Etat from Etat where Id_Etat=" + dt.Rows[0]["Etat"].ToString();
                comboBoxEtat.Text = Program.ExecuterScalaire(reqEtat);
                string reqEvn = "select Nom_Ev from Evenement where Id_Ev=" + dt.Rows[0]["evenement"].ToString();
                comboBox_event.Text = Program.ExecuterScalaire(reqEvn);
                
                DateTime dtm = Convert.ToDateTime(dt.Rows[0]["DateD"].ToString());
                var date1 = dtm.Date;
                TextBox_date.Text =  date1.ToString();
                if(dt.Rows[0]["payer"].ToString()=="1")
                {
                    checkBox_.Checked = true;
                }
                else
                {
                    checkBox_.Checked = false;
                }
            }
            if (Program.ajt_cmd_C)
            {
                Textbox_CIN.Enabled = false;
                Textbox_CIN.Text = Program.ID_Clien;
                Button_add.Visible = true;
                Button_modi.Visible = false;
                groupBoxTR.Visible = false;
                radioButton_eqauls_nom.Checked = true;



                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;

                updown_nbrT.Enabled = false;
                updown_nbrCh.Enabled = false;

                updown_QR1.Enabled = false;
                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;
                dtTbale = Program.ExecuterSelection("select * from Objet where Id_O=1");
                tableM = dtTbale.Rows[0]["Quantite"].ToString();
                updown_nbrT.Maximum = int.Parse(tableM);
                updown_nbrT.Minimum = 0;
                dtChaise = Program.ExecuterSelection("select * from Objet where Id_O=2");
                chaiseM = dtChaise.Rows[0]["Quantite"].ToString();
                updown_nbrCh.Maximum = int.Parse(chaiseM);
                updown_nbrCh.Minimum = 0;
            }

           

        }




        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Program.ajt_cmd = false;
            Program.ajt_cmd_C = false;
            this.Close();
      

        }

        private void Button_mod_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
      
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                comboBox1.DisplayMember = "Nom_R";
                comboBox1.ValueMember = "Id_R";
                comboBox1.DataSource = Program.ExecuterSelection(reqR);
                checkBox2.Enabled = true;
                idR1 = comboBox1.SelectedValue.ToString();
                if(radioButton_eqauls_oui.Checked)
                {
                    updown_QR1.Enabled = false;
                    updown_QR1.Value = updown_nbrT.Value;
                }
                else
                {
                    updown_QR1.Enabled = true;
                    updown_QR1.Minimum = 1;
                }
            }
            else
            {

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                updown_QR1.Enabled = false;
                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;
                idR1 = null;
                idR2 = null;
                idR3 = null;
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                updown_QR1.Minimum = 0;
                updown_QR2.Minimum = 0;
                updown_QR3.Minimum = 0;
                updown_QR1.Value = 0;
                updown_QR2.Value = 0;
                updown_QR3.Value = 0;





            }
            calculPrix();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                string reqR2 = "select * from Repas except select * from Repas where Id_R=" + comboBox1.SelectedValue;
                comboBox2.Enabled = true;
                comboBox2.DisplayMember = "Nom_R";
                comboBox2.ValueMember = "Id_R";
                comboBox2.DataSource = Program.ExecuterSelection(reqR2);
                checkBox3.Enabled = true;
                idR2 = comboBox2.SelectedValue.ToString();
                if (radioButton_eqauls_oui.Checked)
                {
                    updown_QR2.Enabled = false;
                    updown_QR2.Value = updown_nbrT.Value;
                }
                else
                {
                    updown_QR2.Enabled = true;
                    updown_QR2.Minimum = 1;
                }
            }
            else
            {



                comboBox2.Enabled = false;
                comboBox3.Enabled = false;

                checkBox2.Checked = false;
                checkBox3.Checked = false;

                checkBox3.Enabled = false;

                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;
                idR2 = null;
                idR3 = null;
                comboBox2.Text = "";
                comboBox3.Text = "";
                updown_QR1.Minimum = 0;
                updown_QR2.Minimum = 0;
                updown_QR2.Value = 0;
                updown_QR3.Value = 0;


            }
            calculPrix();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                string reqR3 = "select * from Repas except select * from Repas where Id_R=" + comboBox1.SelectedValue + " or Id_R=" + comboBox2.SelectedValue;
                comboBox3.Enabled = true;
                comboBox3.DisplayMember = "Nom_R";
                comboBox3.ValueMember = "Id_R";
                comboBox3.DataSource = Program.ExecuterSelection(reqR3);
                idR3 = comboBox3.SelectedValue.ToString();
                if (radioButton_eqauls_oui.Checked)
                {
                    updown_QR3.Enabled = false;
                    updown_QR3.Value = updown_nbrT.Value;
                }
                else
                {
                    updown_QR3.Enabled = true;

                    updown_QR3.Minimum = 1;
                }
            }
            else
            {
                comboBox3.Enabled = false;
                updown_QR3.Enabled = false;
                idR3 = null;
                comboBox3.Text = "";
                updown_QR3.Minimum = 0;
                updown_QR3.Value = 0;


            }
            calculPrix();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            reqqload();
            textBox_total.Text = calculPrix().ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            reqqload();
            textBox_total.Text = calculPrix().ToString();
        }




        private void Button_add_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBoxT.Checked || checkBoxCh.Checked)
            {
                DialogResult r = MessageBox.Show("Voulez-vous ajouter cette commande?", "Ajoue", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    
                    
                   


                    lieu_cmd = Textbox_adrs.Text;
                    prix_cmd = calculPrix().ToString();
                    etat = comboBoxEtat.SelectedValue.ToString();
                    dateD = TextBox_date.Text;
                    client = Textbox_CIN.Text;
                    even = comboBox_event.SelectedValue.ToString();

                     qtr1 =int.Parse( updown_QR1.Value.ToString());
                     qtr2 = int.Parse(updown_QR2.Value.ToString());
                     qtr3 = int.Parse(updown_QR3.Value.ToString());

                    if (checkBox1.Checked)
                    {
                        repas1 = comboBox1.SelectedValue.ToString();

                    }

                    if (checkBox2.Checked)
                    {
                       
                        repas2 = comboBox2.SelectedValue.ToString();
                    }
                    if (checkBox3.Checked)
                    {
                        
                        repas3 = comboBox3.SelectedValue.ToString();

                    }
                    if (checkBoxT.Checked)
                    {
                        tableC = updown_nbrT.Value.ToString();
                    }
                    if (checkBoxCh.Checked)
                    {
                        chaiseC = updown_nbrCh.Value.ToString();
                    }
                    payer = '1';
                    if (checkBox_.Checked)
                    {
                        payer = '1';
                    }
                    else
                    {
                        payer = '0';

                    }

                    //MessageBox.Show(dateD);
                    //MessageBox.Show(lieu_cmd);
                    //MessageBox.Show(prix_cmd);
                    //MessageBox.Show(client);
                    //MessageBox.Show(even);
                    //MessageBox.Show(payer.ToString());
                    //MessageBox.Show(repas1);
                    //MessageBox.Show(repas2);
                    //MessageBox.Show(repas3);
                    //MessageBox.Show(qtr1.ToString());
                    //MessageBox.Show(qtr2.ToString());
                    //MessageBox.Show(qtr3.ToString());
                    //MessageBox.Show(tableC);
                    //MessageBox.Show(chaiseC);





                    


                    if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                    {
                        string reqAdd = string.Format(@"insert into Commande(Date_cmd, DateD, Lieu_cmd, Prix_cmd, client, evenement, payer, Repas1, Repas2, Repas3, qtR1, qtR2, qtR3,Etat)
                                values(getdate(),'{0}','{1}',{2},'{3}',{4},'{5}',{6},{7},{8},{9},{10},{11},{12})", dateD, lieu_cmd, prix_cmd.Replace(',', '.'), client, even, payer,
                                repas1, repas2, repas3, qr1, qr2, qr3, etat);
                        Program.ExecuterMaj(reqAdd);
                        idCmd = Program.ExecuterScalaire(reqRpIdCmd);

                        remplirobjet(idCmd);
                    }
                    else if (checkBox2.Checked && checkBox1.Checked)
                    {
                        string reqAdd = string.Format(@"insert into Commande(Date_cmd, DateD, Lieu_cmd, Prix_cmd, client, evenement, payer, Repas1, Repas2, qtR1, qtR2,Etat)
                                values(getdate(),'{0}','{1}',{2},'{3}',{4},'{5}',{6},{7},{8},{9},{10})", dateD, lieu_cmd, prix_cmd.Replace(',', '.'), client, even, payer,
                                repas1, repas2, qr1, qr2, etat);
                        Program.ExecuterMaj(reqAdd);
                        idCmd = Program.ExecuterScalaire(reqRpIdCmd);

                        remplirobjet(idCmd);



                    }
                    else if (checkBox1.Checked)
                    {
                        string reqAdd = string.Format(@"insert into Commande(Date_cmd, DateD, Lieu_cmd, Prix_cmd, client, evenement, payer, Repas1,  qtR1,Etat)
                                values(getdate(),'{0}','{1}',{2},'{3}',{4},'{5}',{6},{7},{8})", dateD, lieu_cmd, prix_cmd.Replace(',','.'), client, even, payer,
                                repas1,  qr1,  etat);
                        Program.ExecuterMaj(reqAdd);
                        //values(getdate(), '12/12/1111 11:11', 'Lieux de command', 1300, 0000, 'B623015', 1, '0', 1, 1, 1)
                        idCmd = Program.ExecuterScalaire(reqRpIdCmd);

                        remplirobjet(idCmd);
                    }
                    else
                    {

                        string reqAdd = string.Format(@"insert into Commande(Date_cmd, DateD, Lieu_cmd, Prix_cmd, client, evenement, payer,Etat)
                                values(getdate(),'{0}','{1}',{2},'{3}',{4},'{5}',{6})", dateD, lieu_cmd, prix_cmd.Replace(',', '.'), client, even, payer,
                            etat);
                        Program.ExecuterMaj(reqAdd);
                        idCmd = Program.ExecuterScalaire(reqRpIdCmd);

                        remplirobjet(idCmd);
                    }


                    string requpdateC = "update Commande set prix_cmd=" + PTl.ToString("#") + " where id_cmd =" + idCmd;
                    Program.ExecuterMaj(requpdateC);

                    MessageBox.Show("Commande ajouté");
                }
            }
            else
            {
                MessageBox.Show("Il faut au moins choisir un repas ou un materiel");
            }




        }

        private void Radio_T_Ch_oui_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Height = 157;
        }

        private void Textbox_dateL_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_CIN_Enter(object sender, EventArgs e)
        {
            if (Textbox_CIN.Text == "CIN Client")
            {
                Textbox_CIN.Text = "";
            }
        }

        private void Textbox_CIN_Leave(object sender, EventArgs e)
        {
            if (Textbox_CIN.Text == "")
            {
                Textbox_CIN.Text = "CIN Client";
            }
        }

        private void Textbox_adrs_Enter(object sender, EventArgs e)
        {
            if (Textbox_CIN.Text == "Lieux de command")
            {
                Textbox_CIN.Text = "";
            }
        }

        private void Textbox_adrs_Leave(object sender, EventArgs e)
        {
            if (Textbox_CIN.Text == "")
            {
                Textbox_CIN.Text = "Lieux de command";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_total.Text = calculPrix().ToString();
        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxT.Checked)
            { 
                updown_nbrT.Enabled = true;
                groupBoxTR.Visible = true;
                updown_nbrT.Minimum = 1;

            }
            
            else
            { 
                updown_nbrT.Enabled = false;
                radioButton_eqauls_nom.Checked = true;
                groupBoxTR.Visible = false;
                updown_nbrT.Minimum = 0;
                updown_nbrT.Value = 0;
            }
            calculPrix();

        }

        private void checkBoxCh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCh.Checked)
            {
                updown_nbrCh.Enabled = true;
                updown_nbrCh.Minimum = 1;


            }
            else
            {
                updown_nbrCh.Enabled = false;
                updown_nbrCh.Minimum = 0;
                updown_nbrCh.Value = 0;

            }
            calculPrix();

        }

        private void radioButton_eqauls_nom_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                updown_QR1.Enabled = true;
                updown_QR2.Enabled = true;
                updown_QR3.Enabled = true;
              


            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                updown_QR1.Enabled = true;
                updown_QR2.Enabled = true;
               
                updown_QR3.Value = 0;

            }
            else if (checkBox1.Checked)
            {
                updown_QR1.Enabled = true;
                
                updown_QR2.Value =0;
                updown_QR3.Value = 0;

            }
            else
            {

            }
            calculPrix();

        }

        private void Textbox_dateL_Enter(object sender, EventArgs e)
        {
            if (Textbox_CIN.Text == "Date Livraison")
            {
                Textbox_CIN.Text = "";
            }
        }

        private void Textbox_dateL_Leave(object sender, EventArgs e)
        {
            if (Textbox_CIN.Text == "")
            {
                Textbox_CIN.Text = "Date Livraison";
            }
        }

        private void updown_nbrT_ValueChanged(object sender, EventArgs e)
        {
            
            if (radioButton_eqauls_oui.Checked)
            {
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    updown_QR1.Value = updown_nbrT.Value;
                    updown_QR2.Value = updown_nbrT.Value;
                    updown_QR3.Value = updown_nbrT.Value;
                    updown_QR1.Enabled = false;
                    updown_QR2.Enabled = false;
                    updown_QR3.Enabled = false;
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    updown_QR1.Value = updown_nbrT.Value;
                    updown_QR2.Value = updown_nbrT.Value;

                    updown_QR1.Enabled = false;
                    updown_QR2.Enabled = false;
                    updown_QR3.Enabled = false;
                }
                else if (checkBox1.Checked)
                {
                    updown_QR1.Value = updown_nbrT.Value;
                    updown_QR1.Enabled = false;
                    updown_QR2.Enabled = false;
                    updown_QR3.Enabled = false;
                }
         
            }

            textBox_total.Text = calculPrix().ToString();

        }

        private void radioButton_eqauls_oui_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                updown_QR1.Value = updown_nbrT.Value;
                updown_QR2.Value = updown_nbrT.Value;
                updown_QR3.Value = updown_nbrT.Value;
                updown_QR1.Enabled = false;
                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;

            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                updown_QR1.Value = updown_nbrT.Value;
                updown_QR2.Value = updown_nbrT.Value;
                
                updown_QR1.Enabled = false;
                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;
            }
            else if (checkBox1.Checked)
            {
                updown_QR1.Value = updown_nbrT.Value;
                updown_QR1.Enabled = false;
                updown_QR2.Enabled = false;
                updown_QR3.Enabled = false;
            }
            else
            {

            }


            calculPrix();


        }

        private void Radio_T_Ch_nom_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Height = 76;
        }

        private void Button_modi_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBoxT.Checked || checkBoxCh.Checked)
            {
                DialogResult r = MessageBox.Show("Voulez-vous modifier cette commande?", "Modification", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {





                    lieu_cmd = Textbox_adrs.Text;
                    prix_cmd = calculPrix().ToString();
                    etat = comboBoxEtat.SelectedValue.ToString();
                    dateD = TextBox_date.Text;
                    client = Textbox_CIN.Text;
                    even = comboBox_event.SelectedValue.ToString();

                    qtr1 = int.Parse(updown_QR1.Value.ToString());
                    qtr2 = int.Parse(updown_QR2.Value.ToString());
                    qtr3 = int.Parse(updown_QR3.Value.ToString());

                    if (checkBox1.Checked)
                    {
                        repas1 = comboBox1.SelectedValue.ToString();

                    }

                    if (checkBox2.Checked)
                    {

                        repas2 = comboBox2.SelectedValue.ToString();
                    }
                    if (checkBox3.Checked)
                    {

                        repas3 = comboBox3.SelectedValue.ToString();

                    }
                    if (checkBoxT.Checked)
                    {
                        tableC = updown_nbrT.Value.ToString();
                    }
                    if (checkBoxCh.Checked)
                    {
                        chaiseC = updown_nbrCh.Value.ToString();
                    }
                    payer = '1';
                    if (checkBox_.Checked)
                    {
                        payer = '1';
                    }
                    else
                    {
                        payer = '0';

                    }

                    //MessageBox.Show(dateD);
                    //MessageBox.Show(lieu_cmd);
                    //MessageBox.Show(prix_cmd);
                    //MessageBox.Show(client);
                    //MessageBox.Show(even);
                    //MessageBox.Show(payer.ToString());
                    //MessageBox.Show(repas1);
                    //MessageBox.Show(repas2);
                    //MessageBox.Show(repas3);
                    //MessageBox.Show(qtr1.ToString());
                    //MessageBox.Show(qtr2.ToString());
                    //MessageBox.Show(qtr3.ToString());
                    //MessageBox.Show(tableC);
                    //MessageBox.Show(chaiseC);


                





                    if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                    {
                        string reqUpdate = String.Format(@"update commande set repas1 = {0}, qtR1 = {1}, repas2 ={2}, qtR2 ={3}, repas3 = {4},
                            qtR3 = {5}, dateD = '{6}',
                            Lieu_cmd = '{7}', prix_cmd = {8}, Etat = {9}, evenement = {10}, payer = {11} where id_cmd = {12}",repas1,qtr1,repas2,qtr2,repas3,qtr3,
                            dateD,lieu_cmd, prix_cmd.Replace(',', '.'), etat,even,payer,Program.ID_cmd);


                        Program.ExecuterMaj(reqUpdate);
                        idCmd = Program.ID_cmd;

                        updateObjet(idCmd);
                    }
                    else if (checkBox2.Checked && checkBox1.Checked)
                    {
                        string reqUpdate = String.Format(@"update commande set repas1 = {0}, qtR1 = {1}, repas2 ={2}, qtR2 ={3}, repas3 = {4},
                            qtR3 = {5}, dateD = '{6}',
                            Lieu_cmd = '{7}', prix_cmd = {8}, Etat = {9}, evenement = {10}, payer = {11} where id_cmd = {12}", repas1, qtr1, repas2, qtr2, "null",0,
                           dateD, lieu_cmd, prix_cmd.Replace(',', '.'), etat, even, payer, Program.ID_cmd);


                        Program.ExecuterMaj(reqUpdate);

                        idCmd = Program.ID_cmd;

                        updateObjet(idCmd);



                    }
                    else if (checkBox1.Checked)
                    {
                        string reqUpdate = String.Format(@"update commande set repas1 = {0}, qtR1 = {1}, repas2 ={2}, qtR2 ={3}, repas3 = {4},
                            qtR3 = {5}, dateD = '{6}',
                            Lieu_cmd = '{7}', prix_cmd = {8}, Etat = {9}, evenement = {10}, payer = {11} where id_cmd = {12}", repas1, qtr1, "null", 0, "null", 0,
                           dateD, lieu_cmd, prix_cmd.Replace(',', '.'), etat, even, payer, Program.ID_cmd);


                        Program.ExecuterMaj(reqUpdate);


                        idCmd = Program.ID_cmd;

                        updateObjet(idCmd);
                    }
                    else
                    {

                        idCmd = Program.ID_cmd;

                        updateObjet(idCmd);
                    }


                    string requpdateC = "update Commande set prix_cmd=" + PTl.ToString("#") + " where id_cmd =" + idCmd;
                    Program.ExecuterMaj(requpdateC);

                    MessageBox.Show("Commande modifié");
                }
            }
            else
            {
                MessageBox.Show("Il faut au moins choisir un repas ou un materiel");
            }
            //var cmd = Program.entities.Commende.Find(Program.ID_cmd);

            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
               
            }
        }


    }
}









