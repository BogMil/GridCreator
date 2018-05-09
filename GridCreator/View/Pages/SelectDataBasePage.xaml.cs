using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridCreator.View.Pages
{
    /// <summary>
    /// Interaction logic for SelectDataBasePage.xaml
    /// </summary>
    public partial class SelectDataBasePage : IBasePage
    {
        public SelectDataBasePage()
        {
            InitializeComponent();
        }

        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();

            // Open connection to the database
            string conString = "server=xeon;uid=sa;pwd=manager; database=northwind";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;

        }

        public void GoToNextPage(GridCreatorWindow baseWindow)
        {
            throw new NotImplementedException();
        }

        public void GoToPreviousPage(GridCreatorWindow baseWindow)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> test = new List<string>();
            DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
            var servers = table.Rows;
                       
            foreach (DataRow server in servers)
            {
                foreach (var ia in server.ItemArray)
                {
                    test.Add(ia.ToString());
                }
                //string servername = server[table.Columns["ServerName"]].ToString();

                // you can get that using the instanceName property 
                //string instancename = server["InstanceName"].ToString();

                //and version property tells you the version of sql server i.e 2000, 2005, 2008 r2 etc
                //string sqlversion = server[table.Columns["Version"].ToString()];

                //to form the servername you can combine the server and instancenames as
                //string sqlserverfullname = String.Format("{0}\{1}", servername, instancename);

                //test.Add(servername);
            }
            var x= String.Join(" : ", test);
            MessageBox.Show(x);
        }
    }
}
