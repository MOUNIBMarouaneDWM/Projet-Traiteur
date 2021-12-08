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
    public partial class F_repas : Form
    {
        public F_repas()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        private void refresh()
        {
            var repa = (from i in Program.entities.Repas
                          select i).ToList();
            bs.DataSource = repa;

        }
        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_modi_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(Textbox_id.Text);
            var rech = Program.entities.Repas.Find(id);
            if (rech != null)
            {
                rech.Nom_R = Textbox_nom.Text;
                rech.Prix_R = decimal.Parse(Textbox_prix.Text);
                actualiser();
                Program.entities.SaveChanges();
                bs.EndEdit();
                MessageBox.Show("Bien Modifier");
            }
            actualiser();
            

        }
        private void actualiser()
        {
           
            DataGrid_list.DataSource = (from repa in Program.entities.Repas
                                        select new
                                        {
                                            repa.Id_R,
                                            repa.Nom_R,
                                            repa.Prix_R
                                        }).ToList();
        }
        private void F_repas_Load(object sender, EventArgs e)
        {
            Textbox_id.Enabled = false;
            Button_modi.Enabled = false;
            Button_sup.Enabled = false;
            refresh();
            actualiser();
            Textbox_id.DataBindings.Add("text", bs, "Id_R", true);
            Textbox_nom.DataBindings.Add("text", bs, "Nom_R", true);
            Textbox_prix.DataBindings.Add("text", bs, "Prix_R", true);

        }

        private void DataGrid_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_id.Enabled = false;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.DataGrid_list.Rows[e.RowIndex];
                Textbox_id.Text = row.Cells[0].Value.ToString();
                Textbox_nom.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value == null)
                {
                    Textbox_prix.Text = "";
                }
                else
                    Textbox_prix.Text = row.Cells[2].Value.ToString();


                Button_modi.Enabled = true;
                Button_sup.Enabled = true;
            }
        }

        private void Button_sup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous supprimer ce repas", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var rech = Program.entities.Repas.Find(int.Parse(Textbox_id.Text));
                if (rech != null)
                {
                    Program.entities.Repas.Remove(rech);
                    bs.RemoveAt(bs.Position);
                    MessageBox.Show("repas suprimé");
                }
                else { MessageBox.Show("repas inexistant"); }
                Program.entities.SaveChanges();
                actualiser();
            }

           
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (label1.Text.Equals("Nouveau"))
                {
                    bs.AddNew();
                    label1.Text = "Ajouter";
                    Button_modi.Enabled = false;
                    Button_sup.Enabled = false;
                    Textbox_id.Enabled = true;
                }
                else if (label1.Text.Equals("Ajouter"))
                {
                    Textbox_id.Enabled = false;
                    var repa = new Repas
                    {
                        Id_R = int.Parse(Textbox_id.Text),
                        Nom_R = Textbox_nom.Text,
                        Prix_R = decimal.Parse(Textbox_prix.Text)
                    };
                    try
                    {
                        Program.entities.Repas.Add(repa);
                        Program.entities.SaveChanges();
                        bs.EndEdit();
                        MessageBox.Show("Repas ajouté");
                        actualiser();
                    }
                    catch { MessageBox.Show("deja exist"); }
                    label1.Text = "Nouveau";
                    Button_modi.Enabled = true;
                    Button_sup.Enabled = true;
                }
                actualiser();
            }
            catch (Exception)
            {

                throw;
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_id_Enter(object sender, EventArgs e)
        {
            if (Textbox_id.Text == "ID")
            {
                Textbox_id.Text = "";
            }
        }

        private void Textbox_id_Leave(object sender, EventArgs e)
        {
            if (Textbox_id.Text == "")
            {
                Textbox_id.Text = "ID";
            }
        }

        private void Textbox_nom_Enter(object sender, EventArgs e)
        {
            if (Textbox_id.Text == "Nom de repas")
            {
                Textbox_id.Text = "";
            }
        }

        private void Textbox_nom_Leave(object sender, EventArgs e)
        {
            if (Textbox_id.Text == "")
            {
                Textbox_id.Text = "Nom de repas";
            }
        }
    }
}
