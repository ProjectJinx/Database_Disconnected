using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Datenbanken_Disconnected
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=./Nordwind.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataView deutsche = new DataView();
        public Form1()
        {
            InitializeComponent();
            cmd.Connection = conn;
        }

        #region Buttons
        private void DATEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listFirmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Kunden";
                conn.Open();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Kunden");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Tabelle nicht vorhanden");
            }
            catch (InvalidCastException)
            {
                //
            }
            finally
            {
                conn.Close();
            }
        }

        private void btGetFile_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Kunden.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
        }

        private void btCustomerFiles_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Kunden"] != null)
            {
                data.DataSource = ds.Tables["Kunden"];
            }
            else
                MessageBox.Show("Keine Daten vorhanden");
        }

        private void btCompanynames_Click(object sender, EventArgs e)
        {
            int rows = ds.Tables["Kunden"].Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                listFirmen.Items.Add(ds.Tables["Kunden"].Rows[i][1]);
            }
        }

        private void btGermanCustomers_Click(object sender, EventArgs e)
        {
            deutsche = new DataView(ds.Tables["Kunden"]);
            deutsche.Sort = "Land ASC";
            deutsche.RowFilter = "Land = 'Deutschland'";
            data.DataSource = deutsche;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ds.WriteXml("./Kunden.xml");
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
