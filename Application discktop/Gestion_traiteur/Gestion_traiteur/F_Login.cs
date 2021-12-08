using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_traiteur
{
    public partial class F_Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public F_Login()
        {
            InitializeComponent();
        }

        private void Tx_admin_Enter(object sender, EventArgs e)
        {
            if (tx_admin.Text == "Admin")
            {
                tx_admin.Text = "";
            }
        }

        private void Tx_admin_Leave(object sender, EventArgs e)
        {
            if (tx_admin.Text == "")
            {
                tx_admin.Text = "Admin";
            }
        }

        private void Tx_pass_Enter(object sender, EventArgs e)
        {
            if (tx_pass.Text == "Mot de passe")
            {
                tx_pass.Text = "";
                tx_pass.isPassword = true;
            }
        }

        private void Tx_pass_Leave(object sender, EventArgs e)
        {
            if (tx_pass.Text == "")
            {
                tx_pass.Text = "Mot de passe";
                tx_pass.isPassword = false;
            }

        }
        
        private void Btn_login_Click(object sender, EventArgs e)
        {
            // kan3amer admin o pass min form login hit ghadi nhtaji fi form traiteur
            Program.admin = tx_admin.Text;
            Program.pass = tx_pass.Text;

            // 3la hssabb wax l9ina xi admin ola la dak chi 3la ssab ax l9ina fi BDD 

            foreach (var log in Program.entities.Traiteur)
            {
                if (log.Mdp_T == Program.pass && log.admin_ == Program.admin)
                {
                    this.Hide();
                    F_menu f = new F_menu();
                    f.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("admin ou mot de passe et incorrect");
                    break;
                }

            }




        }

        private void Icon_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void F_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

         
        }

    }
}
