using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace Cadastro_Oficial
{
    public partial class novoCadastro : MetroFramework.Forms.MetroForm
    {
        public novoCadastro()
        {
            InitializeComponent();
            ActiveControl = txtcep;

        }

        private void novoCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'endereçosDataSet2.estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.endereçosDataSet2.estado);
            // TODO: esta linha de código carrega dados na tabela 'endereçosDataSet1.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.endereçosDataSet1.cidade);

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdsalvar_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
                
            {

                gestorBD gestor = new gestorBD();

                List<gestorBD.SQLparametro> parametros = new List<gestorBD.SQLparametro>()
            {
                new gestorBD.SQLparametro ("@CEP ", txtcep.Text),
                new gestorBD.SQLparametro ("@Endereço ", txtendereco.Text),
                new gestorBD.SQLparametro ("@Número ", txtnumero.Text),
                new gestorBD.SQLparametro ("@Complemento ", txtcomplemento.Text),
                new gestorBD.SQLparametro ("@Bairro ", txtbairro.Text),
                new gestorBD.SQLparametro ("@Cidade ", txtcidade.Text),
                new gestorBD.SQLparametro ("@Estado ", txtestado.Text)

            };

                gestor.EXE_NON_READER("insert into dbo.Cadastro VALUES (" + "@CEP, @Endereço, @Número, @Complemento, @Bairro, @Cidade, @Estado)", parametros);


                MessageBox.Show("Dados gravados com sucesso", "Aviso!");

                //Limpar o quadro e preparar para novo registro
                txtcep.Text = "";
                txtendereco.Text = "";
                txtnumero.Text = "";
                txtcomplemento.Text = "";
                txtbairro.Text = "";
                txtcidade.Text = "";
                txtestado.Text = "";
                ActiveControl = txtcep;


            }
            else if (txtid.Text != "")
            {
                gestorBD gestor = new gestorBD();

                List<gestorBD.SQLparametro> parametros = new List<gestorBD.SQLparametro>()
            {
                new gestorBD.SQLparametro ("@ID", txtid.Text),
                new gestorBD.SQLparametro ("@CEP ", txtcep.Text),
                new gestorBD.SQLparametro ("@Endereço ", txtendereco.Text),
                new gestorBD.SQLparametro ("@Número ", txtnumero.Text),
                new gestorBD.SQLparametro ("@Complemento ", txtcomplemento.Text),
                new gestorBD.SQLparametro ("@Bairro ", txtbairro.Text),
                new gestorBD.SQLparametro ("@Cidade ", txtcidade.Text),
                new gestorBD.SQLparametro ("@Estado ", txtestado.Text)
            };

                gestor.EXE_NON_READER("UPDATE dbo.Cadastro SET " +
                                      "CEP = @CEP, " +
                                      "Endereço = @Endereço, " +
                                      "Número = @Número, " +
                                      "Complemento = @Complemento," +
                                      "Bairro = @Bairro, " +
                                      "Cidade = @Cidade, " +
                                      "Estado = @Estado " +
                                      "WHERE ID = @ID ", parametros);


                MessageBox.Show("Dados atualizados com sucesso", "Aviso!");

            }
            
        }

        private void cmdlimpar_Click(object sender, EventArgs e)
        {
            //Limpar o quadro
            txtcep.Text = "";
            txtendereco.Text = "";
            txtnumero.Text = "";
            txtcomplemento.Text = "";
            txtbairro.Text = "";
            txtcidade.Text = "";
            txtestado.Text = "";
            ActiveControl = txtcep;
        }

        private void txtcep_Click(object sender, EventArgs e)
        {

        }

        private void txtendereco_Click(object sender, EventArgs e)
        {

        }

        private void txtnumero_Click(object sender, EventArgs e)
        {

        }

        private void txtcomplemento_Click(object sender, EventArgs e)
        {

        }

        private void txtbairro_Click(object sender, EventArgs e)
        {

        }

        private void txtid_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
        }

        private void lblcep_Click(object sender, EventArgs e)
        {

        }

        private void boxcidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcidade_Click(object sender, EventArgs e)
        {

        }

        private void txtestado_Click(object sender, EventArgs e)
        {

        }
    }
}
