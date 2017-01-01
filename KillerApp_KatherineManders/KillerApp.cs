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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Katherine Manders\documents\visual studio 2015\Projects\KillerApp_KatherineManders\KillerApp_KatherineManders\Database1.mdf';Integrated Security=True");

        public KillerApp()
        {
            InitializeComponent();
        }

        private void KillerApp_Load(object sender, EventArgs e)
        {
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

            sqlCon.Close();
        }

        // Het gedeelte waarmee de query vanuit de geselecterde tags wordt gemaakt. 
        private void btnZoek_Click(object sender, EventArgs e)
        {
            // 
            foreach (var item in clbTags.Items)
            {
                //AANPASSINGEN WOWOOWOWOWOWOWOWOWOWO
            }

            // SELECT * FROM FotoTags FT, Foto F WHERE FT.Foto_ID = F.Foto_ID AND Tag_ID IN (....)
            // SELECT fotobron FROM foto where ......... tags dit dit dit dit 


            SELECT Foto_ID FROM Foto, FotoTags
                            where foto_ID.foto == foto_ID.FotoTags
                            and foto_ID.Fototags = 1 // als het een is bijvoorbeeld
        }
    }
}
