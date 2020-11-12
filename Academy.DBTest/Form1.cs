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

namespace Academy.DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clienti_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = WINAPMGUDJIV7BS\SQLEXPRESS; Initial Catalog = AcademyDB; Integrated Security = True";
            //USING PER DISPOSE:
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String sqlCmdText = "SELECT [ID],[firstName],[lastName],[fiscalCode] FROM[AcademyDB].[dbo].[Clients]";
                SqlCommand cmd = new SqlCommand(sqlCmdText, conn);
                //Devo aprire la connessione
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(); //COME STREAM DI BYTE

                while (dr.Read())
                {
                    //ATTENTA: QUESTO è COME ESEMPIO
                    //ORA SI USA ALTRA TECNOLOGIA
                    string id = dr[0].ToString();
                    string FirstName = dr[1].ToString();
                    string LastName = dr[2].ToString();

                    string item = id+ " " + FirstName + " " + LastName;
                    this.lst_clienti.Items.Add(item);

                }
                conn.Close(); 
            }
        }

        private void lst_clienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = this.lst_clienti.SelectedItem.ToString();
            string[] splittedString = item.Split(' ');
            int ID = Int32.Parse(splittedString[0]);
        }
    }
}
