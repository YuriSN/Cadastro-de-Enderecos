using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cadastro_Oficial;
using System.Windows.Forms;

namespace Cadastro_Oficial
{
    class gestorBD
    {
        //Métodos e Atributos para pesquisar/inserir/Excluir dados do meu BD
        //Connection string
        string strConnection = "";
        string basedados = "";
        public String mensagem = "";

        //Objetos SQL Server
        SqlConnection ligacao = null;
        SqlCommand comando = null;
        SqlDataAdapter adaptador = null;
        DataTable dadosTemp = null;

        //Criando uma classe GET and SET para trazer mais segurança quando for fazer a pesquisa usando caixa de texto
        public class SQLparametro
        {
            public string parametro { get; set; }
            public object valor { get; set; }

            //Criando construtor dessa classe
            public SQLparametro(string parametro, object valor)
            {
                this.parametro = parametro;
                this.valor = valor;

            }

        }

        //==========================================================================================================================
        //Construtor
        public gestorBD(string bd = "")
        {
            if (bd != "")
                basedados = bd;
            else
                basedados = main.basedados;

            //Conexão
            strConnection = "Server = " + main.servidor + "; Database = " + basedados + "; Trusted_Connection = true";
        }

        //========================= Esse Método retorna uma valor, faz um Get na minha tabela =======================================
        public DataTable EXE_READER(string strComando)
        {
            adaptador = new SqlDataAdapter(strComando, strConnection);
            DataTable dados = new DataTable();

            try
            {
                adaptador.Fill(dados);

            }
            catch (Exception ex)
            {
                //Erro de sintaxe
                MessageBox.Show("ERRO" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adaptador.Dispose();
            }
            //Retorna os dados
            adaptador.Dispose();
            return dados;
        }

        //============================== Faz um OverLoad para segurança da aplicação ================================================
        public DataTable EXE_READER(string strComando, List<SQLparametro> parametros)
        {
            //Retorna uma valor de pesquisa
            adaptador = new SqlDataAdapter(strComando, strConnection);
            DataTable dados = new DataTable();
            adaptador.SelectCommand.Parameters.Clear();

            //---------------------------------------------------
            try
            {
                //Inserindo parametros de segurança no comando
                foreach (SQLparametro parametro in parametros)
                {
                    adaptador.SelectCommand.Parameters.Add
                        (new SqlParameter(parametro.parametro, parametro.valor));
                }

                adaptador.Fill(dados);
            }
            catch (Exception ex)
            {

                //Erro de sintaxe
                MessageBox.Show("ERRO" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //------------
            adaptador.Dispose();
            return dados;
        }

        //================================ Faz INSERIR/APAGAR/ALTERAR dados da BD ===================================================
        public void EXE_NON_READER(string strComando)
        {
            //executa uma query ou CONSULTA do tipo INSERT, UPDATE ou DELETE
            ligacao = new SqlConnection(strConnection);
            comando = new SqlCommand();

            using (ligacao)
            {
                ligacao.Open();
                comando.Connection = ligacao;
                comando.CommandText = strComando;

                //-----------------------------------
                //Executa a Query

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    //Erro de sintaxe
                    MessageBox.Show("ERRO:" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //--------------------------------------
            ligacao.Dispose();
            comando.Dispose();
        }

        //=========================== Faz INSERIR/APAGAR/ALTERAR dados da BD usando GET & SET =======================================
        public void EXE_NON_READER(string strComando, List<SQLparametro> parametros)

        {
            //executa uma query ou CONSULTA do tipo INSERT, UPDATE ou DELETE
            ligacao = new SqlConnection(strConnection);
            comando = new SqlCommand();

            using (ligacao)
            {
                ligacao.Open();

                comando.Connection = ligacao;
                comando.CommandText = strComando;

                //-----------------------------------
                //Executa a Query

                try
                {
                    //Adiciona os Parametros
                    comando.Parameters.Clear();
                    foreach (SQLparametro parametro in parametros)
                        comando.Parameters.Add(new SqlParameter(parametro.parametro, parametro.valor));
                    this.mensagem = "Cadastrado com Sucesso!";


                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    //Erro de sintaxe
                    MessageBox.Show("ERRO: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //--------------------------------------
            ligacao.Dispose();
            comando.Dispose();
        }

        //===========================================================================================================================
        public void LIGACAO_TEMP()
        {
            //Abrir uma ligacao temporária 
            ligacao = new SqlConnection(strConnection);
            ligacao.Open();

            comando = new SqlCommand();
            comando.Connection = ligacao;

        }

        //===========================================================================================================================
        public void EXE_COMANDO_TEMP(string strComando)
        {
            //Executa comando relacionado com a ligacao temporária
            comando.CommandText = strComando;

            if (ligacao.State == ConnectionState.Open)
            {
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ligacao.Close();
                    ligacao.Dispose();

                }
            }


        }

        //===========================================================================================================================
        public void FECHAR_LIGACAO_TEMP()
        {
            if (ligacao.State == ConnectionState.Open)
            {
                ligacao.Close();
                ligacao.Dispose();
            }

        }

        //===========================================================================================================================
        public DataTable PREPARAR_DATATABLE(string strComando)
        {

            //Prepara a tabela para atualização
            adaptador = new SqlDataAdapter(strComando, strConnection);
            dadosTemp = new DataTable();

            //--------------------------------Gerenciamento de erros
            try
            {
                adaptador.Fill(dadosTemp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dadosTemp;
        }

        //===========================================================================================================================
        public void ATUALIZAR_DADOS(DataTable dados)
        {
            //Atualizar os Dados
            dadosTemp = dados;

            SqlCommandBuilder cmd = new SqlCommandBuilder(adaptador);

            try
            {
                adaptador.Update(dadosTemp);

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            adaptador.Dispose();
            dadosTemp.Dispose();
        }
    }
}
