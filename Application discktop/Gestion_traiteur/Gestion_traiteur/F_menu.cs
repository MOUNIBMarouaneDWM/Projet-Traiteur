using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gestion_traiteur
{
    public partial class F_menu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public F_menu()
        {
            InitializeComponent();
        }

        private void Btn_slid_Click(object sender, EventArgs e)
        {
            if (Menu_1.Width == 208)
            {
                Menu_1.Width = 44;

            }
            else
            {
                Menu_1.Width = 208;

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Icon_max.Visible = false;
            Icon_min.Visible = true;

        }

        private void Icon_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Icon_max.Visible = true;
            Icon_min.Visible = false;

        }

        private void Icon_down_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

     

        //private void menu_2_Paint(object sender, PaintEventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Normal)
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //    }
        //    else
        //        this.WindowState = FormWindowState.Normal;
        //}
        public void Panelaffiche(object form_af)
        {
            
            int panelcont = this.Panel_container.Controls.Count;
            if (panelcont > 0)
            {
                this.Panel_container.Controls.RemoveAt(0);
            }
            Form fh = form_af as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_container.Controls.Add(fh);
            this.Panel_container.Tag = fh;
            fh.Show();
        }

        private void Btn_client_Click(object sender, EventArgs e)
        {
            Panelaffiche(new F_Client());
        }

        private void Btn_cmd_Click(object sender, EventArgs e)
        {
            Panelaffiche(new F_cmd());
        }

        private void Btn_obj_Click(object sender, EventArgs e)
        {
            Panelaffiche(new F_objet());
        }

        private void Btn_reupa_Click(object sender, EventArgs e)
        {
            Panelaffiche(new F_repas());
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            Panelaffiche(new F_traiteur());
        }

        private void F_menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
