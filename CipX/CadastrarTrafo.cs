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
    public partial class CadastrarTrafo : Form
    {
        public CadastrarTrafo()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarTrafo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.FillByPip(this.eletrocadDataSet.trafo, CadastroProgramacao.programacaoId);


            Cursor.Current = Cursors.Default;
            Application.DoEvents();            

            /* APENAS PARA TESTE, APAGAR QUANDO FOR COMPILADO
             * FUNÇÃO PARA CLICAR NO BOTAO APÓS ALGUNS SEGUNDOS
             * EVITANDO QUE O PROGRAMADOR TENHA QUE CLICAR SEMPRE
             * NO MESMO BOTÃO PARA TESTAR O APLICATIVO
             */
            //System.Threading.Thread.Sleep(1000);
            //enviarDados(sender, e);
        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            if (!GPSForm.StartTraking())
            {
                MessageBox.Show("GPS não está ligado.");
                return;
            }

            try
            {
                trafoBindingSource.CancelEdit();
                trafoBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //cod_bracoComboBox.SelectedIndex = 0;
            //fasesComboBox.SelectedIndex = 0;
            //cod_luminariaComboBox.SelectedIndex = 0;
            //comandoComboBox.SelectedIndex = 0;
            //cod_lampadaComboBox.SelectedIndex = 0;
            //cod_reatorComboBox.SelectedIndex = 0;
            //plaqueta_fkTextBox.Text = Plaqueta.plaqueta;
            //observacaoTextBox.Text = "";
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            chaveTextBox.Focus();
            tabControl1.SelectedIndex = 1;
            usuario_idTextBox.Text = ""+1;
            gps_timeTextBox.Text = GPS.gpsTime.ToString();


            //GPS.gpsOldTime = GPS.gpsTime;
            //System.Threading.Thread.Sleep(1000);

            programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();


            //while (GPS.accuracy > GPS.accuracyIdeal + 75)
            //{
            //    label1.Text = "Precisão está baixa: " + GPS.accuracy + "m";
            //    //MessageBox.Show("Não é possível inserir pois a precisão está baixa");
            //    //System.Threading.Thread.Sleep(1000);
            //    Application.DoEvents();
            //}

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }


        public static int trafoId;

        private void salvar(object sender, EventArgs e)
        {
            //while (GPS.accuracy > GPS.accuracyIdeal + 75)
            //{
            //    label1.Text = "Precisão está baixa: " + GPS.accuracy + "m";
            //    //MessageBox.Show("Não é possível inserir pois a precisão está baixa");
            //    //System.Threading.Thread.Sleep(1000);
            //    Application.DoEvents();
            //}

            if (GPSForm.gpsTrimble.IsTracking())
            {
                gps_timeTextBox.Text = GPS.gpsTime.ToString();
            }

            try
            {
                this.trafoBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["trafo"];
                db.eletrocadDataSet.trafoRow r = (db.eletrocadDataSet.trafoRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = trafoTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    trafoTableAdapter.FillByPip(eletrocadDataSet.trafo, CadastroProgramacao.programacaoId);
                    //trafoBindingSource.MoveLast();
                    MessageBox.Show("Informações salvas com sucesso! ");
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
                MessageBox.Show(ex.Message);
                //citeluz2DataSet.RejectChanges();
            }
            finally
            {
                GPSForm.StopTrimble();
            }
        }

        private void CadastrarTrafo_Closing(object sender, CancelEventArgs e)
        {
            Application.DoEvents();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            trafoId = Convert.ToInt32(lblTtrafoId.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            CadastrarPostes p = new CadastrarPostes();
            p.ShowDialog();
        }

        private void enviarDados(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //CadastrarTrafo t = new CadastrarTrafo();
            EnviarDados p = new EnviarDados();
            p.ShowDialog();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (trafoBindingSource.Count > 0)
            {
                menuItemPostes.Text = "Postes (Chave: " +
                    ((DataRowView)trafoBindingSource.Current).Row["chave"].ToString() + ")";
            }

            if (GPSForm.gpsTrimble != null)
            {
                if (GPS.accuracy > GPS.accuracyIdeal && GPSForm.gpsTrimble.IsTracking())
                {
                    menuItemSalvar.Text = "Salvar (Baixa acurácia)";
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
}