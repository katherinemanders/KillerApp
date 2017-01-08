using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KillerApp_KatherineManders
{
    public partial class KillerApp : Form
    {
        //SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\Source\Repos\KillerApp\KillerApp_KatherineManders\Database1.mdf;Integrated Security=True");
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katherine Manders\documents\visual studio 2015\Projects\KillerApp_KatherineManders\KillerApp_KatherineManders\Database1.mdf;Integrated Security=True");
        // aanmaken van een nieuwe dictiornary waarin de tags komen te staan
        // Dictionary bestaat uit twee waardes
        Dictionary<int, string> tags = new Dictionary<int, string>();
        // nieuwe list waar de geselecteerde foto_ID's in komen te staan
        List<int> Foto_IDs = new List<int>();

        List<Fotograaf> fotograven = new List<Fotograaf>();

        public KillerApp()
        {
            InitializeComponent();
        }

        private void KillerApp_Load(object sender, EventArgs e)
        {
            // open foto bij het begin van de app
            // nog aanpassen
            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Foto", sqlCon);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader["FotoBron"]);
                    pbPhoto.LoadAsync(sqlReader["FotoBron"].ToString());
                }
            }
            finally
            {
                sqlReader.Close();
            }

            // het vullen van de checkedlistitems box
            sqlCommand = new SqlCommand("SELECT * FROM Tags", sqlCon);
            sqlReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    tags.Add((int)sqlReader["Tag_ID"], (string)sqlReader["Omschrijving"]);
                }
            }
            finally
            {
                sqlReader.Close();
            }

            sqlCon.Close();
            // toevoegen van de omschrijving van tags aan de checkedlistitemsbox. 
            // geselectterde vakje 1 staat gelijk aan tag 1 uit de tags (dictionary)
            clbTags.Items.AddRange(tags.Values.ToArray());
        }


        private void btnZoek_Click(object sender, EventArgs e)
        {
            // Het gedeelte waarmee de query vanuit de geselecterde tags wordt gemaakt. 
            string sqlCom = "SELECT Foto_ID FROM FotoTags";
            bool secondID = false;

            for (int i = 0; i < clbTags.Items.Count; i++)
            {
                if (clbTags.SelectedIndices.Contains(i))
                {
                    if (secondID)
                    {
                        sqlCom += " AND";
                    }
                    sqlCom += " WHERE Tag_ID = " + tags.ElementAt(i).Key;
                    secondID = true;
                }
            }
            // lijst met zoekresultaten leeg maken
            Foto_IDs.Clear();

            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlCom, sqlCon);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader["Foto_ID"]);
                    // foto's toevoegen aan list zodat erna de gegevens ingelezen kunnen worden
                    Foto_IDs.Add((int)sqlReader["Foto_ID"]);
                    // foto die als eerste naar boven komt 
                }
            }
            finally
            {
                sqlReader.Close();
            }
            sqlCon.Close();
        }

        private void btnZoekFotograaf_Click(object sender, EventArgs e)
        {
            string zoek = tbFotograaf.Text.ToString();
            // foreach maken waarbij voor elke fotograaf een item in een listbox met daar in naam fotograaf
            string sqlCom = "SELECT Fotograaf_ID FROM Fotograaf WHERE naam LIKE '%" + zoek + "%'";
            List<int> fotograafIDLIST = new List<int>();

            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlCom, sqlCon);
            // SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            // gevonden fotograafID toevoegen aan een list
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    fotograafIDLIST.Add(reader.GetInt32(0));
                }
            }

            fotograven.Clear();
            // Naam ophalen die bij gevonden fotograaf hoort
            foreach (var fotograaf_ID in fotograafIDLIST)
            {
                fotograven.Add(new Fotograaf());
                sqlCom = "SELECT Naam FROM fotograaf WHERE Fotograaf_ID = " + fotograaf_ID;
                sqlCommand = new SqlCommand(sqlCom, sqlCon);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fotograven.Last().Naam = reader.GetString(0);
                    }
                }
                // eerste foto toevoegen aan picturbox
                //sqlCom = "SELECT Fotobron FROM Foto WHERE Fotograaf_ID = " + fotograaf_ID;
                //sqlCom = "SELECT * FROM Foto WHERE Fotograaf_ID = " + fotograaf_ID;
                sqlCom = "SELECT * FROM Fotograaf, Foto, Film WHERE fotograaf.Fotograaf_ID = foto.Fotograaf_ID and film.Film_ID = foto.Film_ID and foto_ID = 1";
                sqlCommand = new SqlCommand(sqlCom, sqlCon);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["FotoBron"]);
                        pbPhoto.LoadAsync(reader["FotoBron"].ToString());
                        lblFotograaf.Text = (reader["Naam"].ToString());
                        lblDiafragma.Text = (reader["Diafragma"].ToString());
                        lblSluiter.Text = "1/" + (reader["Sluitertijd"].ToString());
                        lblBrand.Text = (reader["Brandpuntafstand"].ToString());
                        lblDatum.Text = (reader["Datum"].ToString());
                        lblLocatie.Text = (reader["Locatie"].ToString());
                        lblFilm.Text = (reader["Soort"].ToString());
                        lblKleur.Text = (reader["Kleur"].ToString());
                        lblASA.Text = (reader["ASA"].ToString());
                        lblFilm.Text = (reader["Soort"].ToString());
                        lblWebsite.Text = (reader["Website"].ToString());
                    }
                }


                sqlCon.Close();
            }
        }
    }
}
