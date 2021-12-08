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
    public partial class F_traiteur : Form
    {
        public F_traiteur()
        {
            InitializeComponent();
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void admin_text_Enter(object sender, EventArgs e)
        {
            if (admin_text.Text == "admin")
            {
                admin_text.Text = "";

            }
        }

        private void admin_text_Leave(object sender, EventArgs e)
        {
            if (admin_text.Text == "")
            {
                admin_text.Text = "admin";

            }
            //else
            //{
            //    if (!Program.valid_Admin(text_admin.Text))
            //    {
            //        DialogResult dialogResult = MessageBox.Show("al admin maxi shih al marjou min i3adat kitabatih ", "Some Title", MessageBoxButtons.OK);
            //        if (dialogResult == DialogResult.OK)
            //        {
            //            text_admin.Text = "";
            //        }
            //    }
            //}
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
                string admin = text_admin.Text;
                string admin1 = admin_text.Text;
                string pass = text_pass1.Text;
                if (text_pass2.Text == text_pass1.Text)
                {
                    foreach (var log in Program.entities.Traiteur)
                    {
                        if (Program.admin == admin1)
                        {
                            log.admin_ = admin;
                            log.Mdp_T = pass;
                            MessageBox.Show("Modifier avec succès");
                            Application.Restart();
                        }
                    }

                }
                else if (text_pass2.Text == "Confirmier le mot de passe")
                    MessageBox.Show("confirmer le mots de passe");
                else
                    MessageBox.Show("verifier le mots de passe");
                Program.entities.SaveChanges();
            
        }

        private void text_admin_Enter(object sender, EventArgs e)
        {
            if(text_admin.Text== "Nouveu admin")
            {
                text_admin.Text = "";
            }
        }

        private void text_admin_Leave(object sender, EventArgs e)
        {
            if (text_admin.Text == "")
            {
                text_admin.Text = "Nouveu admin";
            }
        }

        private void text_pass1_Leave(object sender, EventArgs e)
        {
            if (text_pass1.Text == "")
            {
                text_pass1.Text = "Nouveu mot de passe";
            }
        }
        private void text_pass2_Leave(object sender, EventArgs e)
        {
            if (text_pass2.Text == "")
            {
                text_pass2.Text = "Confirmier le mot de passe";
            }
        }

        private void text_pass1_Enter(object sender, EventArgs e)
        {
            if (text_pass1.Text == "Nouveu mot de passe")
            {
                text_pass1.Text = "";
            }
            if(checkBoxaffichermdp.Checked)
            {
                text_pass1.isPassword = false;
            }
            else
            {
                text_pass1.isPassword = true;

            }
        }
        private void text_pass2_Enter(object sender, EventArgs e)
        {
            if (text_pass2.Text == "Confirmier le mot de passe")
            {
                text_pass2.Text = "";
            }
            if (checkBoxaffichermdp.Checked)
            {
                text_pass2.isPassword = false;
            }
            else
            {
                text_pass2.isPassword = true;

            }
        }

        private void checkBoxaffichermdp_CheckedChanged(object sender, EventArgs e)
        {
        
            if (checkBoxaffichermdp.Checked)
            {
                text_pass1.isPassword = false;
                text_pass2.isPassword = false;
            }
            else
            {
                text_pass1.isPassword = true;
                text_pass2.isPassword = true;

            }
        }
    }
}
