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
    public partial class F_objet : Form
    {


        public F_objet()
        {
            InitializeComponent();
        }

        bool table=true, chaise=true;
        int nbrTableUsed, nbrChaiseUsed, nbrTableDispo, nbrChaiseDispo;
        private void save()
        {
            Program.entities.SaveChanges();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (btn_modifier.ButtonText == "Modifier")
            {
                plus_chaise.Visible = true;
                plus_table.Visible = true;
                moin_chaise.Visible = true;
                moin_table.Visible = true;
                UpDownCh.Visible = true;
                UpDownT.Visible = true;
                plus_table.Enabled = false;
                plus_chaise.Enabled = false;
                moin_table.Enabled = false;
                moin_chaise.Enabled = false;
                UpDownCh.Value = 0;
                UpDownT.Value = 0;
                btn_modifier.ButtonText = "Terminer";
            }
            else
            {
               


                plus_chaise.Visible = false;
                plus_table.Visible = false;
                moin_chaise.Visible = false;
                moin_table.Visible = false;
                UpDownCh.Visible = false;
                UpDownT.Visible = false;
                btn_modifier.ButtonText = "Modifier";
                

            }
        }
        private void valeurO()
        {
            string reqTableUsed = @"select sum(Nbr) from objet O join reserver R
                                on r.id_o=o.id_o
                                join commande C
                                on c.Id_cmd=r.id_cmd
                                where etat <>4 and etat <>2  and o.Id_O=1";
            string reqChaiseUsed = @"select sum(Nbr) from objet O join reserver R
                                on r.id_o=o.id_o
                                join commande C
                                on c.Id_cmd=r.id_cmd
                                where etat <>4 and etat <>2   and o.Id_O=2";
            string reqTableDispo = "select Quantite from Objet where Id_O=1";
            string reqChaiseDispo = "select Quantite from Objet where Id_O=2";
            nbrTableUsed = int.Parse(Program.ExecuterScalaire(reqTableUsed));
            nbrChaiseUsed = int.Parse(Program.ExecuterScalaire(reqChaiseUsed));
            nbrTableDispo = int.Parse(Program.ExecuterScalaire(reqTableDispo));
            nbrChaiseDispo = int.Parse(Program.ExecuterScalaire(reqChaiseDispo));
            //Progressbar_chaise.Value = (nbrChaiseDispo /(nbrChaiseDispo+nbrChaiseUsed))*100;

            //Progressbar_table.Value = (nbrTableDispo /(nbrTableDispo+nbrTableUsed))* 100;
            //MessageBox.Show(((nbrChaiseDispo / (nbrChaiseDispo + nbrChaiseUsed)) * 100).ToString());
            if(nbrTableUsed + nbrTableDispo==0)
            {
                Progressbar_table.MaxValue = 100;
            }
            else
            {
                Progressbar_table.MaxValue = nbrTableUsed + nbrTableDispo;

            }

            if (nbrChaiseDispo + nbrChaiseUsed == 0)
            {
                Progressbar_chaise.MaxValue = 100;
            }
            else
            {
                Progressbar_chaise.MaxValue = nbrChaiseDispo + nbrChaiseUsed;
            }
            Progressbar_table.Value = nbrTableDispo;
           
            Progressbar_chaise.Value = nbrChaiseDispo;
            label_nbrCHD.Text = nbrChaiseDispo.ToString();
            label_nbrCHU.Text = nbrChaiseUsed.ToString();
            label_nbrTD.Text = nbrTableDispo.ToString();
            label_nbrTU.Text = nbrTableUsed.ToString();


        }

        private void moin_table_Click(object sender, EventArgs e)
        {
            if (nbrTableDispo > int.Parse(UpDownT.Value.ToString()))
            {
                int newVal = 0;
                newVal = nbrTableDispo - int.Parse(UpDownT.Value.ToString());
                string req = " update Objet set Quantite=" + newVal + " where Id_O=1";
                Program.ExecuterMaj(req);
                MessageBox.Show("Modification réusite");
                valeurO();
            }
            else
            {
                string req = " update Objet set Quantite=0 where Id_O=1";
                Program.ExecuterMaj(req);
                MessageBox.Show("Votre stock est devenu vide!");
                valeurO();
            }
        }

        private void plus_chaise_Click(object sender, EventArgs e)
        {
          
                int newVal = 0;
                newVal = nbrChaiseDispo + int.Parse(UpDownCh.Value.ToString());
                string req = " update Objet set Quantite=" + newVal + " where Id_O=2";
                Program.ExecuterMaj(req);
            MessageBox.Show("Modification réusite");
            valeurO();

        }

        private void moin_chaise_Click(object sender, EventArgs e)
        {
            int newVal = 0;
            newVal = nbrChaiseDispo - int.Parse(UpDownCh.Value.ToString());
            string req = " update Objet set Quantite=" + newVal + " where Id_O=2";
            Program.ExecuterMaj(req);
            MessageBox.Show("Modification réusite");
            valeurO();


        }

        private void plus_table_Click(object sender, EventArgs e)
        {
            int newVal = 0;
            newVal = nbrTableDispo + int.Parse(UpDownT.Value.ToString());
            string req = " update Objet set Quantite=" + newVal + " where Id_O=1";
            Program.ExecuterMaj(req);
            MessageBox.Show("Modification réusite");
            valeurO();
        }

        private void UpDownCh_ValueChanged(object sender, EventArgs e)
        {
            if(UpDownCh.Value!=0)
            {
                plus_chaise.Enabled = true;
                moin_chaise.Enabled = true;
               
            }
            else
            {
                plus_chaise.Enabled = false;
                moin_chaise.Enabled = false;
            }
        }

        private void UpDownT_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownCh.Value != 0)
            {
                plus_table.Enabled = true;
                moin_table.Enabled = true;

            }
            else
            {
                plus_table.Enabled = false;
                moin_table.Enabled = false;
            }
        }

        private void F_objet_Load(object sender, EventArgs e)
        {
            plus_chaise.Visible = false;
            plus_table.Visible = false;
            moin_chaise.Visible = false;
            moin_table.Visible = false;
            UpDownCh.Visible = false;
            UpDownT.Visible = false;
            valeurO();

        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}