using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gestion_traiteur
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Login());
        }
        //    kibda bi[A - Z]{2}
        //oba3dha ar9am \d{4,6}
        public static string ID_cmd ;
        public static string ID_Clien ;
        public static bool ajt_cmd = false;
        public static bool ajt_cmd_C = false;
        //public static bool valid_CIN(string text)
        //{
        //    Regex CIN = new Regex(@"^[A-Z]{1,2}[1-9]{3,6}$");
        //    return CIN.IsMatch(text);
        //}
        //public static bool valid_Admin(string text)
        //{
        //    Regex Admin = new Regex(@"\w*$");
        //    return Admin.IsMatch(text);
        //}



        //// fih gha horouf o ar9am 
        //// nsff chkel m3a admin 
        //public static Regex Pss_validation = new Regex(@"^\w*$");
        ////kibda bi 1 htal 9 o kikmel bi 0  1 2 3 4 5 ....56........
        //public static Regex Id_validation = new Regex(@"^[1-9]\d*$");
        //// fih gha l 7orooooof 
        //public static Regex Nams_validation = new Regex(@"[a-zA-Z]*$");

        //public static Regex Date_validation = new Regex(@"^$");
        //public static Regex Tel_validation = new Regex(@"^$");
        //public static Regex Mail_validation = new Regex(@"^$");
        //public static Regex Nbr_validation = new Regex(@"^$");
        //public static Regex NomO_validation = new Regex(@"^$");
        //public static Regex Prix_validation = new Regex(@"");



        public static Gestion_TraiteurEntities entities = new Gestion_TraiteurEntities();
        public static string admin;
        public static string pass;

        //
        ////peparer la connection
        public static SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=GestionTraiteur;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", cnx);
        public static SqlDataReader dr;

        // connection 
        public static void cnnx()
        {
            if (cnx.State.ToString() != "Open")
                cnx.Open();
        }

        // deconnection
        public static void deconnection()
        {
            if (cnx.State != ConnectionState.Closed)
                cnx.Close();
        }

        //Executer MAJ

        public static void ExecuterMaj(string req)
        {
            cnnx();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
            deconnection();
        }


        //Executer Selection 


        public static DataTable ExecuterSelection(string req)
        {
            cnnx();
            cmd.CommandText = req;
            DataTable dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            deconnection();
            return dt;

        }

        //Executer scalaire

        public static string ExecuterScalaire(string req)
        {
            cnnx();
            cmd.CommandText = req;
            string affiFinal = cmd.ExecuteScalar().ToString();
            deconnection();
            return affiFinal;
        }


    }

}

