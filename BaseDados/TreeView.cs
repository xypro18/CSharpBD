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

namespace BaseDados
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private void PreencheTreeView(string Xcodlocal, TreeNode parentNode)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = @"Data Source=312-01\SQLEXPRESS; Initial Catalog = XICOXICA;
                                     User id = sa; Password = P@ssw0rd; Connect Timeout = 30; 
                                     Encrypt = False; TrustServerCertificate = False; 
                                     ApplicationIntent = ReadWrite; MultiSubnetFailover = False;";
            SqlDataAdapter adapterChild = new SqlDataAdapter("select nome from clientes where codlocal=" + Xcodlocal + 
                                                   "order by nome", conn2);
            DataTable dtchild = new DataTable();
            adapterChild.Fill(dtchild);
            TreeNode childNode;
            foreach(DataRow dr in dtchild.Rows)
            {
                if (parentNode != null)
                    childNode = parentNode.Nodes.Add(dr["nome"].ToString());
            }
            conn2.Close();
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sair", "Deseja sair?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            DataTable dt = new DataTable();
            conn.ConnectionString = @"Data Source=312-01\SQLEXPRESS; Initial Catalog = XICOXICA;
                                     User id = sa; Password = P@ssw0rd; Connect Timeout = 30; 
                                     Encrypt = False; TrustServerCertificate = False; 
                                     ApplicationIntent = ReadWrite; MultiSubnetFailover = False;";
            conn.Open();
            SqlCommand objCommand = new SqlCommand("select distinct localidade, codlocal from Localidades order by localidade", conn);
            SqlDataAdapter da = new SqlDataAdapter(objCommand);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode parentNode = tView.Nodes.Add(dr["localidade"].ToString());
                PreencheTreeView(dr["codlocal"].ToString(), parentNode);                
            }

            tView.ExpandAll();
            conn.Close();                

        }

        private void tView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tNome.Text = tView.SelectedNode.Text;
        }
    }
}
