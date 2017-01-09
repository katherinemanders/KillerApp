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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Katherine Manders\documents\visual studio 2015\Projects\KillerApp_KatherineManders\KillerApp_KatherineManders\Database1.mdf;Integrated Security=True");
        // aanmaken van een nieuwe dictiornary waarin de tags komen te staan
        // Dictionary bestaat uit twee waardes
        Dictionary<int, string> tags = new Dictionary<int, string>();

        // nieuwe list waar de geselecteerde foto_ID's in komen te staan
        List<int> Foto_IDs = new List<int>();

        // nieuwe list waarin de tags komen te staan die bij een foto horen
        // met die lijst kijken via contains of er een 5 tussen staat -> een 5 is flits
        List<FotoTags> Tags = new List<FotoTags>();

        List<Fotograaf> fotograven = new List<Fotograaf>();
        int fotoNummer = 0;
        bool ZoekOpFotograaf;
        int index;
        int lastID;

        public KillerApp()
        {
            InitializeComponent();
        }

        private void KillerApp_Load(object sender, EventArgs e)
        {
            ZoekOpFotograaf = false;
            // open foto bij het opstarten van de app en labels vullen

            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Foto, Fotograaf, Film Where foto.Fotograaf_ID = Fotograaf.Fotograaf_ID and foto.Film_ID = film.Film_ID and foto.Foto_ID = 1", sqlCon);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader["FotoBron"]);
                    pbPhoto.LoadAsync(sqlReader["FotoBron"].ToString());
                    lblFotograaf.Text = (sqlReader["Naam"].ToString());
                    lblDiafragma.Text = (sqlReader["Diafragma"].ToString());
                    lblSluiter.Text = "1/" + (sqlReader["Sluitertijd"].ToString());
                    lblBrand.Text = (sqlReader["Brandpuntafstand"].ToString()) + "mm";
                    lblDatum.Text = (sqlReader["Datum"].ToString());
                    lblLocatie.Text = (sqlReader["Locatie"].ToString());
                    lblFilm.Text = (sqlReader["Soort"].ToString());
                    lblKleur.Text = (sqlReader["Kleur"].ToString());
                    lblASA.Text = (sqlReader["ASA"].ToString());
                    lblFilm.Text = (sqlReader["Soort"].ToString());
                    lblWebsite.Text = (sqlReader["Website"].ToString());
                    lblFlits.Text = "ja";
                    lblAantalFotos.Text = "2";
                }
            }
            finally
            {
                sqlReader.Close();
            }
            // Het aantal foto's bij het instarten van de app 
            // Momenteel nog onbelangrijk want functie wordt duidelijk in verdere app.

            //sqlCommand = new SqlCommand( "SELECT COUNT(*) FROM Foto WHERE Fotograaf_ID = (SELECT Fotograaf_ID from Fotograaf WHERE naam LIKE '%" + (sqlReader["Naam"].ToString()) + "%')");
            //using (SqlDataReader areader = sqlCommand.ExecuteReader())
            //{
            //    while (areader.Read())
            //    {
            //        lblAantalFotos.Text = areader.GetInt32(0).ToString();
            //    }
            //}

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
            ZoekOpFotograaf = false;
            Foto_IDs.Clear();
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

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader["Foto_ID"]);
                    // foto's toevoegen aan list zodat erna de gegevens ingelezen kunnen worden
                    Foto_IDs.Add((int)reader["Foto_ID"]);
                }
            }

            sqlCom = "Select * FROM Fotograaf, Foto, Film Where foto.Film_ID = Film.Film_ID and foto.Fotograaf_ID = fotograaf.Fotograaf_ID and foto.Foto_ID = " + Foto_IDs.Last();
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
                    lblBrand.Text = (reader["Brandpuntafstand"].ToString()) + "mm";
                    lblDatum.Text = (reader["Datum"].ToString());
                    lblLocatie.Text = (reader["Locatie"].ToString());
                    lblFilm.Text = (reader["Soort"].ToString());
                    lblKleur.Text = (reader["Kleur"].ToString());
                    lblASA.Text = (reader["ASA"].ToString());
                    lblFilm.Text = (reader["Soort"].ToString());
                    lblWebsite.Text = (reader["Website"].ToString());
                }
            }

            // kijken of flits een ja of nee is
            sqlCom = "Select Tag_ID from Fototags WHERE Foto_ID = " + Foto_IDs.Last();

            List<int> Tags = new List<int>();
            Tags.Clear();
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Tags.Add(reader.GetInt32(0));
                }
            }

            if (Tags.Contains(5))
            {
                lblFlits.Text = "ja";
            }
            else
            {
                lblFlits.Text = "nee";
            }

            // weergeven van aantal foto's dat er van de fotograaf in de database staat
            sqlCom = "SELECT COUNT(*) FROM Foto WHERE Fotograaf_ID = (select Fotograaf_ID From Foto Where Foto_ID = " + Foto_IDs.Last() + ")";
            sqlCommand = new SqlCommand(sqlCom, sqlCon);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    lblAantalFotos.Text = reader.GetInt32(0).ToString();
                }
            }

            sqlCon.Close();
        }

        private void btnZoekFotograaf_Click(object sender, EventArgs e)
        {
            ZoekOpFotograaf = true;
            if (tbFotograaf != null)
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

                    // Vullen van labels
                    sqlCom = "SELECT * FROM Fotograaf, Foto, Film WHERE fotograaf.Fotograaf_ID = foto.Fotograaf_ID and film.Film_ID = foto.Film_ID and foto.fotograaf_ID = " + fotograaf_ID;
                    sqlCommand = new SqlCommand(sqlCom, sqlCon);

                    fotograven.Last().Fotos = new List<string>();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["FotoBron"]);
                            fotograven.Last().Fotos.Add(reader["FotoBron"].ToString());
                            pbPhoto.LoadAsync(reader["FotoBron"].ToString());
                            lblFotograaf.Text = (reader["Naam"].ToString());
                            lblDiafragma.Text = (reader["Diafragma"].ToString());
                            lblSluiter.Text = "1/" + (reader["Sluitertijd"].ToString());
                            lblBrand.Text = (reader["Brandpuntafstand"].ToString()) + "mm";
                            lblDatum.Text = (reader["Datum"].ToString());
                            lblLocatie.Text = (reader["Locatie"].ToString());
                            lblFilm.Text = (reader["Soort"].ToString());
                            lblKleur.Text = (reader["Kleur"].ToString());
                            lblASA.Text = (reader["ASA"].ToString());
                            lblFilm.Text = (reader["Soort"].ToString());
                            lblWebsite.Text = (reader["Website"].ToString());
                            // flits nog maken
                        }
                    }
                    sqlCom = "Select Tag_ID from Fototags WHERE Foto_ID = (SELECT foto_ID from Foto WHERE fotobron = '" + (fotograven.Last().Fotos[fotoNummer % fotograven.Last().Fotos.Count()]) + "'";
                    List<int> Tags = new List<int>();
                    Tags.Clear();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tags.Add(reader.GetInt32(0));
                        }
                    }

                    if (Tags.Contains(5))
                    {
                        lblFlits.Text = "ja";
                    }
                    else
                    {
                        lblFlits.Text = "nee";
                    }

                    // weergeven van aantal foto's dat er van de fotograaf in de database staat
                    sqlCom = "SELECT COUNT(*) FROM Foto WHERE Fotograaf_ID = " + fotograaf_ID;
                    sqlCommand = new SqlCommand(sqlCom, sqlCon);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblAantalFotos.Text = reader.GetInt32(0).ToString();
                        }
                    }

                    sqlCon.Close();

                    fotoNummer = fotograven.Last().Fotos.Count - 1;
                }
            }
            else
            {
                MessageBox.Show("Voer een naam in om te zoeken");
            }
            }

        

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            try
            {
                if (ZoekOpFotograaf)
                {
                    fotoNummer++;
                    pbPhoto.LoadAsync(fotograven.Last().Fotos[fotoNummer % fotograven.Last().Fotos.Count()]);

                    // op basis van de gevonden fotobron een query maken die alle labels "ververst"

                    string sqlCom = "SELECT * FROM Fotograaf, Foto, Film WHERE fotograaf.Fotograaf_ID = foto.Fotograaf_ID and film.Film_ID = foto.Film_ID and foto.fotobron = '" + (fotograven.Last().Fotos[fotoNummer % fotograven.Last().Fotos.Count()]) + "'";

                    sqlCon.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlCom, sqlCon);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblFotograaf.Text = (reader["Naam"].ToString());
                            lblDiafragma.Text = (reader["Diafragma"].ToString());
                            lblSluiter.Text = "1/" + (reader["Sluitertijd"].ToString());
                            lblBrand.Text = (reader["Brandpuntafstand"].ToString()) + "mm";
                            lblDatum.Text = (reader["Datum"].ToString());
                            lblLocatie.Text = (reader["Locatie"].ToString());
                            lblFilm.Text = (reader["Soort"].ToString());
                            lblKleur.Text = (reader["Kleur"].ToString());
                            lblASA.Text = (reader["ASA"].ToString());
                            lblFilm.Text = (reader["Soort"].ToString());
                            lblWebsite.Text = (reader["Website"].ToString());
                            // flits onderstaand
                        }
                    }

                    sqlCom = "Select Tag_ID from Fototags WHERE Foto_ID = (SELECT foto_ID from Foto WHERE fotobron = '" + (fotograven.Last().Fotos[fotoNummer % fotograven.Last().Fotos.Count()]) + "'";
                    List<int> Tags = new List<int>();
                    Tags.Clear();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tags.Add(reader.GetInt32(0));
                        }
                    }

                    if (Tags.Contains(5))
                    {
                        lblFlits.Text = "ja";
                    }
                    else
                    {
                        lblFlits.Text = "nee";
                    }

                    sqlCon.Close();
                }
                // Stukje code voor naar volgende of in dit geval volgende item in de lijst gaan van foto_IDs
                // doet het nog niet. -> hoe van foto_ID last naar volgende (met modulo maar hoe...?)


                //else
                //{
                //    string sqlCom = "SELECT * FROM Fotograaf, Foto, Film WHERE fotograaf.Fotograaf_ID = foto.Fotograaf_ID and film.Film_ID = foto.Film_ID and foto.foto_ID =" + Foto_IDs.Last();

                //    sqlCon.Open();
                //    SqlCommand sqlCommand = new SqlCommand(sqlCom, sqlCon);

                //    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            lblFotograaf.Text = (reader["Naam"].ToString());
                //            lblDiafragma.Text = (reader["Diafragma"].ToString());
                //            lblSluiter.Text = "1/" + (reader["Sluitertijd"].ToString());
                //            lblBrand.Text = (reader["Brandpuntafstand"].ToString()) + "mm";
                //            lblDatum.Text = (reader["Datum"].ToString());
                //            lblLocatie.Text = (reader["Locatie"].ToString());
                //            lblFilm.Text = (reader["Soort"].ToString());
                //            lblKleur.Text = (reader["Kleur"].ToString());
                //            lblASA.Text = (reader["ASA"].ToString());
                //            lblFilm.Text = (reader["Soort"].ToString());
                //            lblWebsite.Text = (reader["Website"].ToString());
                //            // flits onderstaand
                //        }
                //    }

                //    sqlCom = "Select Tag_ID from Fototags WHERE Foto_ID = (SELECT foto_ID from Foto WHERE fotobron = '" + (fotograven.Last().Fotos[fotoNummer % fotograven.Last().Fotos.Count()]) + "'";
                //    List<int> Tags = new List<int>();
                //    Tags.Clear();
                //    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            Tags.Add(reader.GetInt32(0));
                //        }
                //    }

                //    if (Tags.Contains(5))
                //    {
                //        lblFlits.Text = "ja";
                //    }
                //    else
                //    {
                //        lblFlits.Text = "nee";
                //    }
                //    sqlCon.Close();
                    

                //    int index = Foto_IDs.IndexOf(LastID);
                //    // regel die maakt dat de er de volgende druk op de knop een andere wordt geladen
                //   // LastID = Foto_IDs.Last()[index == -1 ? 0 : index % Foto_IDs.Count];
                    
            }
 
            catch (Exception)
            {

            }
        }
    }
}

