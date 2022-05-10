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
    public partial class CadastroEnd : MetroFramework.Forms.MetroForm
    {
        public CadastroEnd()
        {
            InitializeComponent();
            this.cadastroTableAdapter.Fill(this.endereçosDataSet.Cadastro);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'endereçosDataSet.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroTableAdapter.Fill(this.endereçosDataSet.Cadastro);

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tltnovoCadastro_Click(object sender, EventArgs e)
        {
            //Abre nova janela para cadastro de Endereço
            novoCadastro f = new novoCadastro();
            f.ShowDialog();

            this.cadastroTableAdapter.Fill(this.endereçosDataSet.Cadastro);
        }

        private void tltdeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir CEP " + metroGrid.CurrentRow.Cells[1].Value.ToString() + " e Endereço " + metroGrid.CurrentRow.Cells[2].Value.ToString() + "?", "Remover Linha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                gestorBD gestor = new gestorBD();

                //Ligacao Temporária
                gestor.LIGACAO_TEMP();
                gestor.EXE_COMANDO_TEMP("DELETE FROM dbo.Cadastro WHERE ID = " + metroGrid.CurrentRow.Cells[0].Value.ToString());
                //gestor.EXE_COMANDO_TEMP("DELETE FROM dbo.Cadastro WHERE CEP  = " + txtdeletar.Text);
                gestor.FECHAR_LIGACAO_TEMP();

                MessageBox.Show("Dados apagados com sucesso", "Aviso!");

                this.cadastroTableAdapter.Fill(this.endereçosDataSet.Cadastro);

            }
        }


        private void tltpesquisar_Click(object sender, EventArgs e)
        {
            gestorBD gestor = new gestorBD();

            //Ligacao Temporária
            gestor.LIGACAO_TEMP();
            metroGrid.DataSource = gestor.EXE_READER("SELECT * FROM dbo.Cadastro WHERE CEP  LIKE '" + txtpesquisar.Text + "%'" +
                " OR Endereço  LIKE '" + txtpesquisar.Text + "%'");
            gestor.FECHAR_LIGACAO_TEMP();
            metroGrid.Refresh();
        }

        private void metroGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            novoCadastro f2 = new novoCadastro();
            f2.txtid.Text = this.metroGrid.CurrentRow.Cells[0].Value.ToString();
            f2.txtcep.Text = this.metroGrid.CurrentRow.Cells[1].Value.ToString();
            f2.txtendereco.Text = this.metroGrid.CurrentRow.Cells[2].Value.ToString();
            f2.txtnumero.Text = this.metroGrid.CurrentRow.Cells[3].Value.ToString();
            f2.txtcomplemento.Text = this.metroGrid.CurrentRow.Cells[4].Value.ToString();
            f2.txtbairro.Text = this.metroGrid.CurrentRow.Cells[5].Value.ToString();
            f2.txtcidade.Text = this.metroGrid.CurrentRow.Cells[6].Value.ToString();
            f2.txtestado.Text = this.metroGrid.CurrentRow.Cells[7].Value.ToString();
            f2.Text = "Alterando Endereço";
            f2.ShowDialog();
        }

        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Código delete em tltdeletar_Click acima
        }

    }
}
