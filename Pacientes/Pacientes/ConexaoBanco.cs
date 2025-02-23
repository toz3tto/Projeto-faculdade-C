using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Pacientes
{
    static class ConexaoBanco
    {

         
        //variaveis contendo as informações do banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "dbPacientes";
        private const string usuario = "root";
        private const string senha = "sua senha";

        //declarando a variavel para fazer a conexão com o banco de dados.
        static public string bancoServidor = $"server={servidor};user id={usuario};database={bancoDados};password={senha}";

    }

          
}
