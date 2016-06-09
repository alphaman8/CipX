using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CipX
{
    public partial class CadastrarPostes : Form
    {
        public CadastrarPostes()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //SAIR
            if (verificaPendencia())
            {
                if (MessageBox.Show("O sistema detectou pendências no cadastro. Deseja sair assim mesmo?", "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    tabControl1.SelectedIndex = 3;
                    return;
                }
            }

            this.Close();        

        }

        private void CadastrarPostes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_tipo_luminaria' table. You can move, or remove it, as needed.
            //this.poste_has_tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.poste_has_tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_uso_mutuo' table. You can move, or remove it, as needed.
            //this.poste_has_uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.poste_has_uso_mutuo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste' table. You can move, or remove it, as needed.
            this.posteTableAdapter.FillByTrafo(this.eletrocadDataSet.poste, CadastrarTrafo.trafoId);
            // TODO: This line of code loads data into the 'eletrocadDataSet.condicao_risco' table. You can move, or remove it, as needed.
            this.condicao_riscoTableAdapter.Fill(this.eletrocadDataSet.condicao_risco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.ativacao' table. You can move, or remove it, as needed.

            medidorTextBox.Enabled = checkBox1.Checked;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
            //timer1.Enabled = true;
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            menuItemSalvar.Enabled = false;

            string bairro = "", logradouro = "";
            int seq = 1;

            if (posteBindingSource.Count > 0)
            {
                posteBindingSource.MoveLast();
                bairro = ((DataRowView)posteBindingSource.Current).Row["bairro"].ToString();
                logradouro = ((DataRowView)posteBindingSource.Current).Row["logradouro"].ToString();
                seq = (int)(((DataRowView)posteBindingSource.Current).Row["sequencia"]);
                seq++;
            }

            try
            {
                posteBindingSource.CancelEdit();
                posteBindingSource.AddNew();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            bairroTextBox.Focus();
            tabControl1.SelectedIndex = 1;
            gps_timeTextBox.Text = GPS.gpsTime.ToString();
            latTextBox.Text = GPS.lat.ToString();
            lonTextBox.Text = GPS.lon.ToString();

            ruaTextBox.Text = logradouro;
            bairroTextBox.Text = bairro;
            sequenciaTextBox.Text = "" + seq;

            //usuario_idTextBox.Text = "" + 1;
            //programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();
            trafo_idTextBox.Text = CadastrarTrafo.trafoId.ToString();

            GPSForm.StopTrimble();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();


            GPSForm.StartTraking();
        }

        private void salvar(object sender, EventArgs e)
        {
            if (!verifica())
            {
                MessageBox.Show("Barramento deve ter entre "
                    + Usuario.nMinBarramento + " a " + Usuario.nMaxBarramento + " dígitos");
                return;
            }

            if (GPSForm.gpsTrimble.IsTracking())
            {
                latTextBox.Text = GPS.lat.ToString();
                lonTextBox.Text = GPS.lon.ToString();
                gps_timeTextBox.Text = GPS.gpsTime.ToString();
            }

            try
            {
                this.posteBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste"];
                
                db.eletrocadDataSet.posteRow r = (db.eletrocadDataSet.posteRow)dt.Rows[0];

                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = posteTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    posteTableAdapter.FillByTrafo(eletrocadDataSet.poste, CadastrarTrafo.trafoId);
                    posteBindingSource.MoveLast();

                    int id = (int)((DataRowView)this.posteBindingSource.Current).Row["id"];
                    int seq = (int)((DataRowView)this.posteBindingSource.Current).Row["sequencia"];

                    if (MessageBox.Show("Informações salvas com sucesso. Inserir Uso Mútuo na Seq. "+seq+"?",
                        "",MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.OK && GPSForm.gpsTrimble.IsTracking())
                    {
                        posteId = Convert.ToInt32(id);
                        GPSForm.StopTrimble();
                        cadastrarUsoMutuo(sender, e);
                    }
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    string errorMsg = null;
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg += row.GetColumnError(col) + "\n";
                        }
                    }
                    MessageBox.Show("Erros nos dados: " + errorMsg, "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("trafo_id_sequencia"))
                {
                    MessageBox.Show("Não foi possível salvar: Sequência já existe.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                //citeluz2DataSet.RejectChanges();
            }
            finally
            {
                GPSForm.StopTrimble();
            }
        }

        private bool verifica()
        {
            int len = barramentoTextBox.Text.Length;
            if (Usuario.nMaxBarramento <= len && Usuario.nMinBarramento >= len)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cadastrarUsoMutuo(object sender, EventArgs e)
        {
            posteId = Convert.ToInt32(labelPosteID.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarUsoMutuo p = new CadastrarUsoMutuo();
            p.ShowDialog();
        }

        public static int posteId;



        private void menuItem5_Click(object sender, EventArgs e)
        {
            posteId = Convert.ToInt32(labelPosteID.Text);

            Poste.lat = Convert.ToDouble(latTextBox.Text);
            Poste.lon = Convert.ToDouble(lonTextBox.Text);
            Poste.gps_time = Convert.ToDateTime(gps_timeTextBox.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarLuminaria p = new CadastrarLuminaria();
            p.ShowDialog();
        }

        private void croqui(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            Croqui p = new Croqui();
            p.ShowDialog();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            medidorTextBox.Enabled = checkBox1.Checked;
        }

        private bool verificaPendencia()
        {
            bool p = false;

            //verificar se existe poste sem componente
            listPendencias.Text = "";

            int c = 0;

            foreach (db.eletrocadDataSet.posteRow row in eletrocadDataSet.poste.Rows)
            {
                int i =
                    poste_has_tipo_luminariaTableAdapter.FillByPoste(eletrocadDataSet.poste_has_tipo_luminaria,
                    row.id);
                int j = poste_has_uso_mutuoTableAdapter.FillByPoste(eletrocadDataSet.poste_has_uso_mutuo,
                    row.id);

                if (i <= 0)
                {
                    c += 1;
                    listPendencias.Text += c+". Seq. " + row.sequencia + " sem luminária.";
                    listPendencias.Text += Environment.NewLine;
                    //p = true;
                }
                if (j <= 0)
                {
                    c += 1;
                    listPendencias.Text += c+". Seq. " + row.sequencia + " sem uso mútuo.";
                    listPendencias.Text += Environment.NewLine;
                    p = true;
                }
            }

            return p;
        }

        private void verificarPendenciaButton(object sender, EventArgs e)
        {
            verificaPendencia();
        }

        private void sequenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (posteBindingSource.Count > 0)
            {
                menuItemComponente.Text = "Componentes (Seq.: " +
                    ((DataRowView)posteBindingSource.Current).Row["sequencia"].ToString() + ")";
            }

            if (GPS.accuracy > GPS.accuracyIdeal - 5 && GPSForm.gpsTrimble.IsTracking())
            {
                menuItemSalvar.Text = "Salvar (Acurácia: "+GPS.accuracy+
                    " / Ideal: "+(GPS.accuracyIdeal - 5)+")";
                menuItemSalvar.Enabled = false;
            }
            else
            {
                menuItemSalvar.Text = "Salvar";
                menuItemSalvar.Enabled = true;                
            }
        }
    }
}