
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Pacientes
{
    internal class cadastroPacientes
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id

        {
            get { return id; }
            set { id = value; }
        }

        public string Nome

        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email

        {
            get { return email; }
            set { email = value; }
        }

        public string Cpf

        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco

        {
            get { return endereco; }
            set { endereco = value; }
        }

        // função para cadastrar pacientes no banco de dados.

        public bool cadastrarPaciente()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string cpfSemMascara = Cpf.Replace(".", "").Replace("-", "");

                string insert = $"insert into pacientes (nome,email,cpf,endereco) values ('{Nome}','{Email}','{Cpf}','{Endereco}')";

                MySqlCommand comandoSqL = MysqlConexaoBanco.CreateCommand();
                comandoSqL.CommandText = insert;
                

                comandoSqL.ExecuteNonQuery();
                return true;
            }

                catch (Exception ex) 
            
            {

                MessageBox.Show("Erro no banco de dados - metodo cadastrarPacientes: " + ex.Message);
                return false;

            }

        }

        public MySqlDataReader localizarPacientes()
        {
            try
            {

                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, nome, email, cpf , endereco from pacientes where cpf = '{cpf}';";

                MySqlCommand comandoSqL = MysqlConexaoBanco.CreateCommand();
                comandoSqL.CommandText = select;

                MySqlDataReader reader = comandoSqL.ExecuteReader();
                
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - metodo localizar paciente: " + ex.Message);
                return null;
                
            }

        }

        public bool atualizarFuncionario()
        {

            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update pacientes set email = '{Email}', endereco = '{Endereco}' where id = '{Id}';";

                MySqlCommand comandoSqL = MysqlConexaoBanco.CreateCommand();
                comandoSqL.CommandText = update;


                comandoSqL.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - metodo atualizarPacientes: " + ex.Message);
                return false;
            }
        }


        public bool deletarPacientes()
        {

            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from pacientes where id = '{Id}';";

                MySqlCommand comandoSqL = MysqlConexaoBanco.CreateCommand();
                comandoSqL.CommandText = delete;


                comandoSqL.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - método deletarPacientes" + ex.Message);
                return false;
              
            }
        }
    }
}
