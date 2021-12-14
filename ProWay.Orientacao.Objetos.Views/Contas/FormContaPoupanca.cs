using ProWay.OrientacaoObjetos.Models.ContaBancaria;
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

namespace ProWay.Orientacao.Objetos.Views.Contas
{
    public partial class FormContaPoupanca : Form
    {
        public FormContaPoupanca()
        {
            InitializeComponent();
            Listar();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            double saldo = Convert.ToDouble(textBoxSaldo.Text.Trim());

            //Instanciado um objeto llamado contaPoupanca da ContaPoupanca
            var contaPoupança = new ContaPopanca(nome , saldo);

            var caminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\71303\Source\Repos\ProWay.OrientacaoObjetos.SistemaBanco\ProWay.Orientacao.Objetos.Views\BancoDados\Database.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(caminho);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            
            var sql = "INSERT INTO ContasPoupanca (nome, saldo) VALUES  (@NOME, @SALDO)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.AddWithValue("@NOME", contaPoupança.Nome);
            sqlCommand.Parameters.AddWithValue("@SALDO", contaPoupança.Saldo);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Cadastrado com sucesso");
            textBoxNome.Clear();
            textBoxSaldo.Clear();
            
            Listar();

        }
        private void Listar()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\71303\Source\Repos\ProWay.OrientacaoObjetos.SistemaBanco\ProWay.Orientacao.Objetos.Views\BancoDados\Database.mdf;Integrated Security=True";
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = sqlConnection;
            comando.CommandText = "SELECT codigo, nome, saldo FROM ContasPoupanca";

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            dataGridView.Rows.Clear();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                int codigo = Convert.ToInt32(dataRow[0]);
                string nome = dataRow[1].ToString();
                double saldo = Convert.ToDouble(dataRow[2]);
                dataGridView.Rows.Add(codigo, nome, saldo);


            }
        }


    }
}
