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
    public partial class F_event : Form
    {
        public F_event()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        private void F_event_Load(object sender, EventArgs e)
        {
            Textbox_id.Enabled = false;
            Textbox_id.DataBindings.Add("text", bs, "Id_Ev",true);
            Textbox_nam.DataBindings.Add("text", bs, "Nom_Ev", true);
            actualiser();

        }
        private void actualiser()
        {
            dataGridView_list.DataSource = (from i in Program.entities.Evenement
                                            select new
                                            {
                                                i.Id_Ev,
                                                i.Nom_Ev
                                            }).ToList();
        }
        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Textbox_nam_Enter(object sender, EventArgs e)
        {
            if (Textbox_nam.Text == "Nom de evenment")
            {
                Textbox_nam.Text = "";
            }
        }

        private void Textbox_nam_Leave(object sender, EventArgs e)
        {
            if (Textbox_nam.Text == "")
            {
                Textbox_nam.Text = "Nom de evenment";
            }
        }

        private void dataGridView_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView_list.Rows[e.RowIndex];
                Textbox_id.Text = row.Cells[0].Value.ToString();
                Textbox_nam.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value == null)
                {
                    Textbox_nam.Text = "";
                }
                else
                    Textbox_nam.Text = row.Cells[2].Value.ToString();
                Button_modi.Enabled = true;
                Button_sup.Enabled = true;
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
                    var event_ = new Evenement
                    {
                        Id_Ev = int.Parse(Textbox_id.Text),
                        Nom_Ev = Textbox_nam.Text,
                   
                    };
                    try
                    {
                        Program.entities.Evenement.Add(event_);
                        Program.entities.SaveChanges();
                        bs.EndEdit();
                        MessageBox.Show("bien ajout");
                        actualiser();
                    }
                    catch { MessageBox.Show("deja exist"); }
                    label1.Text = "Nouveau";
                    Button_modi.Enabled = true;
                    Button_sup.Enabled = true;
                }
                actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
        }

        private void Textbox_id_Enter(object sender, EventArgs e)
        {
            if(Textbox_id.Text== "ID de evenment")
            {
                Textbox_id.Text = "";
            }
        }

        private void Textbox_id_Leave(object sender, EventArgs e)
        {
            if (Textbox_id.Text == "")
            {
                Textbox_id.Text = "ID de evenment";
            }
        }

        private void Button_modi_Click(object sender, EventArgs e)
        {

            int find = int.Parse(Textbox_id.Text);
            var modi = Program.entities.Evenement.Find(find);
            modi.Nom_Ev = Textbox_nam.Text;
            //hassan
            MessageBox.Show("modiffier sucsse");
            Program.entities.SaveChanges();
            actualiser();
        }

        private void Button_sup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var rech = Program.entities.Evenement.Find(int.Parse(Textbox_id.Text));
                if (rech != null)
                {
                    Program.entities.Evenement.Remove(rech);
                    bs.RemoveAt(bs.Position);
                    MessageBox.Show("Bien suprimer");
                }
                else { MessageBox.Show("evenment inexistant"); }

                Program.entities.SaveChanges();
                actualiser();
            }

        }
    }
}
    