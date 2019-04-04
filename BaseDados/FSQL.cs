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
                Con.Close();
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
            tCliente.Text = "";
            tNome.Text = "";
            tMorada.Text = "";
            cLocalidade.Text = "";
            rMasculino.Checked = false;
            rFeminino.Checked = false;
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
            
            if (dtCliReg.Rows[0]["sexo"].ToString() == "True")
                rMasculino.Select();
            else
                rFeminino.Select();

            cLocalidade.SelectedValue = Convert.ToInt16(dtCliReg.Rows[0]["codlocal"].ToString());
            gB1.Enabled = true;
            dtCliReg.Dispose();
        }   

        private void cCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bProcurar_Click(object sender, EventArgs e)
        {
            bInserir.Enabled = false;
            bProcurar.Enabled = false;
            lCliente.Visible = true;
            cCliente.Visible = true;
            cCliente.Focus();
        }

        private void bInserir_Click(object sender, EventArgs e)
        {
            XBotao = 1; //Inserir
            gB1.Enabled = true;
            bInserir.Enabled = false;
            bProcurar.Enabled = false;
            bGravar.Enabled = true;
            LimpaGB1();
            tNome.Focus();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            XBotao = 0;
            bInserir.Enabled = true;
            bProcurar.Enabled = true;
            lCliente.Visible = false;
            cCliente.Visible = false;
            bGravar.Enabled = false;
            LimpaGB1();
            gB1.Enabled = false;
        }

        private void bGravar_Click(object sender, EventArgs e)
        {
            string XValues = "";
            bInserir.Enabled = true;
            bProcurar.Enabled = true;
            lCliente.Visible = false;
            cCliente.Visible = false;
            if(XBotao == 1) // Inserir
            {
                XValues = "'" + tNome.Text + "','" + tMorada.Text +
                    (rMasculino.Checked ? "',1,'" : "',0,'") + dNascimento.Text + "'," +
                    Convert.ToString(cLocalidade.SelectedValue);
                string XInsert = "INSERT INTO Clientes (Nome, Morada, Sexo, Data_nascimento, codlocal) VALUES("
                    + XValues + ");";
                SqlCommand cmd = new SqlCommand(XInsert, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente " + tNome.Text + " inserido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gB1.Enabled = false;
                ReadDB();
                LimpaGB1();
            } else //Procurar --> atualizar
            {

            }
            
        }
    }
}
