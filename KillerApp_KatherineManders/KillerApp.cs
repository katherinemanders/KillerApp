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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\Source\Repos\KillerApp\KillerApp_KatherineManders\Database1.mdf;Integrated Security=True");
        // aanmaken van een nieuwe dictiornary waarin de tags komen te staan
        Dictionary<int, string> tags = new Dictionary<int, string>();

        public KillerApp()
        {
            InitializeComponent();
        }

        private void KillerApp_Load(object sender, EventArgs e)
        {
            // open foto bij het begin van de app
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

        // Het gedeelte waarmee de query vanuit de geselecterde tags wordt gemaakt. 
        private void btnZoek_Click(object sender, EventArgs e)
        {
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

            sqlCon.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlCom, sqlCon);
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader["Foto_ID"]);
                }
            }
            finally
            {
                sqlReader.Close();
            }
            sqlCon.Close();
        }
    }
}
