using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pacientes;

namespace Pacientes
{
    public partial class TelaCadastros : Form
    {
        public TelaCadastros()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroPacientes cadPacientes = new cadastroPacientes();
                    cadPacientes.Nome = txtNome.Text;
                    cadPacientes.Email = txtEmail.Text;
                    cadPacientes.Cpf = txtCpf.Text;
                    cadPacientes.Endereco = txtEndereco.Text;

                    if (cadPacientes.cadastrarPaciente())
                    {

                        MessageBox.Show($"O Paciente {cadPacientes.Nome} foi cadastrado com sucesso");
                    }

                    else
                    {

                        MessageBox.Show("Não foi possivel cadastrar o Paciente");

                    }
                }
                else
                {

                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionario: " + ex.Message);

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    cadastroPacientes cadPacientes = new cadastroPacientes();
                    cadPacientes.Cpf = txtCpf.Text;
                    MySqlDataReader reader = cadPacientes.localizarPacientes();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionario não encontrado");
                            txtCpf.Clear();
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtCpf.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Paciente não encontrado ");

                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Preencher o campo do CPF para realizar a pesquisa.");
                    txtCpf.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar funcionario: " + ex.Message);

                throw;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtCpf.Focus();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    cadastroPacientes cadPacientes = new cadastroPacientes();
                    cadPacientes.Id = int.Parse(lblId.Text);
                    cadPacientes.Email = txtEmail.Text;
                    cadPacientes.Endereco = txtEndereco.Text;

                    if (cadPacientes.atualizarFuncionario())
                    {

                        MessageBox.Show("Os dados do paciente foram atualizados com sucesso");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                        txtCpf.Focus();
                    }

                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar as informações do paciente");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                        txtCpf.Focus();

                    }
                }
                else
                {

                    MessageBox.Show("Favor localizar o paciente que deseja atualizar as informações");
                    txtCpf.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                    txtCpf.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados do paciente" + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    cadastroPacientes cadPacientes = new cadastroPacientes();
                    cadPacientes.Id = int.Parse(lblId.Text);

                    if (cadPacientes.deletarPacientes())
                    {
                        MessageBox.Show("O Paciente foi excluido com sucesso");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel excluir o Paciente.");

                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblId.Text = "";
                      
                    }
                }
                else
                {
                    MessageBox.Show("Pesquisar o funcionario que você deseja excluir.");

                    txtCpf.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblId.Text = "";
                    txtCpf.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao excluir funcionario");
            }
        }   
    }
}
