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
    public partial class FSQL : Form
    {
        SqlConnection Con = new SqlConnection();
        int XBotao;

        public FSQL()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sair", "Deseja sair?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void FSQL_Load(object sender, EventArgs e)
        {
            Con.ConnectionString = @"Data Source=312-01\SQLEXPRESS; Initial Catalog = XICOXICA;
                                     User id = sa; Password = P@ssw0rd; Connect Timeout = 30; 
                                     Encrypt = False; TrustServerCertificate = False; 
                                     ApplicationIntent = ReadWrite; MultiSubnetFailover = False;";
            Con.Open();
            ReadDB();
            LimpaGB1();
        }

        private void ReadDB()
        {
            DataTable dtCliente = new DataTable();
            DataTable dtLocalidade = new DataTable();
            string XQuery = "SELECT Cliente_ID, Nome FROM clientes order by Nome";
            string XQuery2 = "SELECT * FROM Localidades order by Localidade";
            SqlDataAdapter daCliente = new SqlDataAdapter(XQuery, Con);
            daCliente.Fill(dtCliente);
            SqlDataAdapter daLocalidade = new SqlDataAdapter(XQuery2, Con);
            daLocalidade.Fill(dtLocalidade);

            cCliente.DataSource = null;
            cCliente.Text = "";
            cCliente.DataSource = dtCliente;
            cCliente.ValueMember = "Cliente_ID";
            cCliente.DisplayMember = "Nome";

            cLocalidade.DataSource = null;
            cLocalidade.Text = "";
            cLocalidade.DataSource = dtLocalidade;
            cLocalidade.ValueMember = "codlocal";
            cLocalidade.DisplayMember = "Localidade";


        }

        private void LimpaGB1()
        {

        }

        private void cCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dtCliReg = new DataTable();

            cCliente.Visible = false;
            lCliente.Visible = false;
            bGravar.Enabled = true;
            LimpaGB1();
            string XCli = "SELECT * FROM clientes where cliente_id=" + Convert.ToString(cCliente.SelectedValue);
            SqlDataAdapter daCliReg = new SqlDataAdapter(XCli, Con);
            daCliReg.Fill(dtCliReg);
            tCliente.Text = dtCliReg.Rows[0]["cliente_id"].ToString();
            tNome.Text = dtCliReg.Rows[0]["nome"].ToString();
            tMorada.Text = dtCliReg.Rows[0]["morada"].ToString();
            dNascimento.Text = dtCliReg.Rows[0]["Data_nascimento"].ToString();
            cLocalidade.SelectedValue = Convert.ToInt16(dtCliReg.Rows[0]["codlocal"].ToString());
            gB1.Enabled = true;
            dtCliReg.Dispose();
        }   

        private void cCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
