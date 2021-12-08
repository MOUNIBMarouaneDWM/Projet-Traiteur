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
    public partial class F_Client : Form
    {
        public F_Client()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        private void actualiser_BS()
        {
            var client = (from cl in Program.entities.Client
                          select cl).ToList();
            bs.DataSource = client;
        }
        
        private void F_Client_Load(object sender, EventArgs e)
        {
            Textbox_cin.Enabled = false;
            actualiser();
            actualiser_BS();
            Textbox_cin.DataBindings.Add("text", bs, "CIN_C", true);
            Textbox_nom.DataBindings.Add("text", bs, "Nom_C", true);
            Textbox_pren.DataBindings.Add("text", bs, "Prenom_C", true);
            Textbox_date.DataBindings.Add("text", bs, "DateN", true);
            Textbox_tel.DataBindings.Add("text", bs, "Telephone_C", true);
            Textbox_email.DataBindings.Add("text", bs, "mail", true);
            Textbox_adrs.DataBindings.Add("text", bs, "Adresse_C", true);

        }

        private void actualiser()
        {
            DataGrid_list.DataSource = (from i in Program.entities.Client
                                        select new
                                        {
                                            i.CIN_C,
                                            i.Nom_C,
                                            i.Prenom_C,
                                            i.DateN,
                                            i.Telephone_C,
                                            i.mail,
                                            i.Adresse_C,
                                        }).ToList();
        }

        private void icon_close_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGrid_list.Rows[e.RowIndex];
                Textbox_cin.Text = row.Cells[0].Value.ToString();
                Textbox_nom.Text = row.Cells[1].Value.ToString();
                Textbox_pren.Text = row.Cells[2].Value.ToString();
                Textbox_date.Text= row.Cells[3].Value.ToString();
                Textbox_tel.Text = row.Cells[4].Value.ToString();
                Textbox_email.Text = row.Cells[5].Value.ToString();
                Textbox_adrs.Text = row.Cells[6].Value.ToString();
                Button_modi.Enabled = true;
                Button_sup.Enabled = true;

            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (label1.Text == "Nouveau")
                {
                    bs.AddNew();
                    //Textbox_cin.Text = "CIN";
                    //Textbox_adrs.Text = "Adresse";
                    //Textbox_nom.Text = "Nom";
                    //Textbox_pren.Text = "Prenom";
                    //Textbox_date.Text = "Date naissance";
                    //Textbox_tel.Text = "Tel";
                    //Textbox_email.Text = "Email";
                    label1.Text = "Ajouter";
                    Button_modi.Enabled = false;
                    Button_sup.Enabled = false;
                    Textbox_cin.Enabled = true;
                    DataGrid_list.Enabled = false;

                }
                else if (label1.Text == "Ajouter")
                {

                    var cl = new Client
                    {
                        CIN_C = Textbox_cin.Text,
                        Nom_C = Textbox_nom.Text,
                        Prenom_C = Textbox_pren.Text,
                        DateN = Convert.ToDateTime(Textbox_date.Text),
                        Adresse_C = Textbox_adrs.Text,
                        Telephone_C = Textbox_tel.Text,
                        mail = Textbox_email.Text


                    };
                    Program.entities.Client.Add(cl);
                    Program.entities.SaveChanges();
                    bs.EndEdit();
                    MessageBox.Show("Client ajouté");
                    label1.Text = "Nouveau";
                    Button_modi.Enabled = true;
                    Button_sup.Enabled = true;
                    Textbox_cin.Enabled = false;
                }
                actualiser();
                DataGrid_list.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_modi_Click(object sender, EventArgs e)
        {

            string cin = Textbox_cin.Text;
            var rech = Program.entities.Client.Find(cin);
            rech.Nom_C = Textbox_nom.Text;
            rech.Prenom_C = Textbox_pren.Text;
            rech.Telephone_C = Textbox_tel.Text;
            rech.mail = Textbox_adrs.Text;
            rech.DateN = Convert.ToDateTime(Textbox_date.Text);
            Program.entities.SaveChanges();
            MessageBox.Show("Données modifié");
            actualiser();

        }

        private void Button_sup_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("êtes vous sur de vouloir supprimer ce client", "Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var rech = Program.entities.Client.Find(Textbox_cin.Text);
                    if (rech != null)
                    {
                        Program.entities.Client.Remove(rech);
                        bs.RemoveAt(bs.Position);
                        
                    }
                    Program.entities.SaveChanges();
                    MessageBox.Show("Client suprimé");
                    actualiser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("se client a des commendes tu ne peux pa supprimer le");
     
            }
        }


    



        private void Button_add_cmd_Click(object sender, EventArgs e)
        {
            Program.ID_Clien = Textbox_cin.Text;
            Program.ajt_cmd = true;
            Program.ajt_cmd_C = true;
            F_ajout_Cmd f = new F_ajout_Cmd();
            f.Show();
        }

        private void Textbox_date_OnValueChanged(object sender, EventArgs e)
        {
            //if (Textbox_date.Text.Length==2)
            //{
            //    string r = Textbox_date.Text;
            //    Textbox_date.Text = r + "/";
            //    Textbox_date.Text.c
            //}
        }
    }
}
