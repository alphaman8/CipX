using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;

namespace CipX
{
    public partial class CadastrarLuminaria : Form
    {
        public CadastrarLuminaria()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarLuminaria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.chave_comando' table. You can move, or remove it, as needed.
            this.chave_comandoTableAdapter.Fill(this.eletrocadDataSet.chave_comando);
            // TODO: This line of code loads data into the 'eletrocadDataSet.fase' table. You can move, or remove it, as needed.
            this.faseTableAdapter.Fill(this.eletrocadDataSet.fase);
            // TODO: This line of code loads data into the 'eletrocadDataSet.ativacao' table. You can move, or remove it, as needed.
            this.ativacaoTableAdapter.Fill(this.eletrocadDataSet.ativacao);
            // TODO: This line of code loads data into the 'eletrocadDataSet.braco' table. You can move, or remove it, as needed.
            this.bracoTableAdapter.Fill(this.eletrocadDataSet.braco);
            // TODO: This line of code loads data into the 'eletrocadDataSet.reator' table. You can move, or remove it, as needed.
            this.reatorTableAdapter.Fill(this.eletrocadDataSet.reator);
            // TODO: This line of code loads data into the 'eletrocadDataSet.lampada' table. You can move, or remove it, as needed.
            this.lampadaTableAdapter.Fill(this.eletrocadDataSet.lampada);
            // TODO: This line of code loads data into the 'eletrocadDataSet.tipo_luminaria' table. You can move, or remove it, as needed.
            this.tipo_luminariaTableAdapter.Fill(this.eletrocadDataSet.tipo_luminaria);
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_tipo_luminaria' table. You can move, or remove it, as needed.
            this.poste_has_tipo_luminariaTableAdapter.FillByPoste(this.eletrocadDataSet.poste_has_tipo_luminaria, CadastrarPostes.posteId);
            //this.poste_has_tipo_luminariaTableAdapter.FillWithNames(this.eletrocadDataSet.poste_has_tipo_luminaria, CadastrarPostes.posteId);
            this.luminariasTableAdapter.Fill(this.eletrocadDataSet.luminarias, CadastrarPostes.posteId);

            #region CRIA PASTA PARA FOTOS
            pathName =
                    Library.appDir + @"\imagens\cadastro\";

            bool exists = System.IO.Directory.Exists(pathName);
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(pathName);
            } 
            #endregion

            Cursor.Current = Cursors.Default;
            Application.DoEvents();

        }

        private void novo(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            GPSForm.StartTraking();

            while (GPS.accuracy > GPS.accuracyIdeal)
            {
                label1.Text = "Precisão está baixa: " + GPS.accuracy + "m";
                //MessageBox.Show("Não é possível inserir pois a precisão está baixa");
                //System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
            }

            label1.Text = "lat: " + GPS.lat + " lon: " + GPS.lon + " acc: " + GPS.accuracy + "m";

            try
            {
                postehastipoluminariaBindingSource.CancelEdit();
                postehastipoluminariaBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //chaveTextBox.Text = "";
            //ciaTextBox.Text = "";
            //alimentadorTextBox.Text = "";
            //chaveTextBox.Focus();
            comboBox1.Focus();
            poste_idTextBox.Text = CadastrarPostes.posteId.ToString();

            gps_timeTextBox.Text = GPS.gpsTime.ToString();

            latTextBox.Text = GPS.lat.ToString();
            lonTextBox.Text = GPS.lon.ToString();

            tabControl1.SelectedIndex = 1;
            comboBox1.Focus();
            pictureBox1.Image = null;
            //usuario_idTextBox.Text = "" + 1;
            //programacao_ip_idTextBox.Text = CadastroProgramacao.programacaoId.ToString();
            //trafo_idTextBox.Text = CadastrarTrafo.trafoId.ToString();

            GPSForm.StopTrimble();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void salvar(object sender, EventArgs e)
        {

            try
            {
                this.postehastipoluminariaBindingSource.EndEdit();
                db.eletrocadDataSet changes = (db.eletrocadDataSet)this.eletrocadDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["poste_has_tipo_luminaria"];
                db.eletrocadDataSet.poste_has_tipo_luminariaRow r = (db.eletrocadDataSet.poste_has_tipo_luminariaRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = poste_has_tipo_luminariaTableAdapter.Update(changes);
                    this.eletrocadDataSet.AcceptChanges();
                    poste_has_tipo_luminariaTableAdapter.FillByPoste(eletrocadDataSet.poste_has_tipo_luminaria, CadastrarPostes.posteId);
                    pictureBox1.Image = null;
                    luminariasBindingSource.Position = 0;
                    MessageBox.Show("Informações salvas com sucesso! ");

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
        }

        private void limpaTabelas()
        {
            try
            {
                while (eletrocadDataSet.tipo_luminaria.Count > 0)
                {
                    eletrocadDataSet.tipo_luminaria.Rows[0].Delete();
                    tipo_luminariaTableAdapter.Update(eletrocadDataSet.tipo_luminaria);
                    eletrocadDataSet.tipo_luminaria.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void importar()
        {
            label1.Text = "Iniciando Importação. Aguarde";
            label1.Visible = true;

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            limpaTabelas();
            label1.Text = "Dados locais apagados";
            Application.DoEvents();

            //abre conexao
            try
            {
                myconn = new MySql.Data.MySqlClient.MySqlConnection(strconn);
                myconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao servidor, verifique a sua conexão com a internet.");
                return;
            }

            if (myconn.State == ConnectionState.Open)
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                //inicia a transacao
                MySql.Data.MySqlClient.MySqlCommand mycommand = myconn.CreateCommand();
                mycommand.Connection = myconn;
                mycommand.CommandText =
                    "SELECT `tipo_luminaria`.`id`, "+
                    "`tipo_luminaria`.`descricao` "+
                    "FROM `eletrocad`.`tipo_luminaria`";
                //mycommand.Parameters.Clear();
                //mycommand.Parameters.AddWithValue("estado", cbEstado.Text);
                //mycommand.Parameters.AddWithValue("ano", txtAno.Value);

                try
                {
                    MySql.Data.MySqlClient.MySqlDataReader reader = mycommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //
                        //insere nova programação
                        db.eletrocadDataSet.tipo_luminariaRow pipRow;
                        pipRow = eletrocadDataSet.tipo_luminaria.Newtipo_luminariaRow();
                        pipRow.id = reader.GetInt32("id");
                        pipRow.descricao = reader.GetString("descricao");

                        eletrocadDataSet.tipo_luminaria.Rows.Add(pipRow);

                    }
                    tipo_luminariaTableAdapter.Update(eletrocadDataSet.tipo_luminaria);
                    eletrocadDataSet.tipo_luminaria.AcceptChanges();
                    tipo_luminariaTableAdapter.Fill(eletrocadDataSet.tipo_luminaria);

                    reader.Close();

                    Cursor.Current = Cursors.Default;
                    Application.DoEvents();
                    MessageBox.Show("Informações recuperadas com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível importar: " + ex.Message);
                }
                finally
                {
                    //myconn.Close();
                }
            }
            myconn.Close();
            label1.Visible = false;
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=eletrocad;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        private void menuItem6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Atualizar as Luminárias", "atualizar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)) == DialogResult.OK)
            {
                importar();
            }
        }

        private string pathName = "";
        string fileName = "";

        public static string RandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToLower();
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CameraCaptureDialog camCapture = new CameraCaptureDialog();
            camCapture.Owner = null;

            camCapture.InitialDirectory = pathName;
            camCapture.Resolution = new Size(200, 200);
            camCapture.Mode = CameraCaptureMode.Still;

            //gerar nome aleatorio para a foto
            fileName = RandomString(5)+".jpg";

            while (System.IO.File.Exists(pathName + fileName))
            {
                fileName = RandomString(5) + ".jpg";
            }

            camCapture.DefaultFileName = fileName;

            if (DialogResult.OK == camCapture.ShowDialog())
            {
                Bitmap img = new Bitmap(pathName + fileName);
                pictureBox1.Image = img;

                //label do caminho do arquivo
                foto_pathTextBox.Text = pathName + fileName;
            }
            this.BringToFront();
        }

        private void tabPage3_GotFocus(object sender, EventArgs e)
        {
        }

        private void excluir(object sender, EventArgs e)
        {
            DataRowView row =
                (DataRowView)postehastipoluminariaBindingSource.Current;

            int id = (int)row["id"];

            if ((MessageBox.Show("Certeza ao excluir luminária: " + id + "?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                try
                {
                    poste_has_tipo_luminariaTableAdapter.Delete(id);
                    //projetoTableAdapter.Update(lptDataSet.projeto);
                    eletrocadDataSet.AcceptChanges();
                    poste_has_tipo_luminariaTableAdapter.FillByPoste(eletrocadDataSet.poste_has_tipo_luminaria, CadastrarPostes.posteId);
                    pictureBox1.Image = null;
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(foto_pathTextBox.Text))
            {

                Bitmap img = new Bitmap(foto_pathTextBox.Text);
                pictureBox1.Image = img;
                Application.DoEvents();
            }
            else
            {
                MessageBox.Show("Foto não existe");
            }
        }

        private void quantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceitar apenas numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void luminariasDataGrid_Click(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)luminariasBindingSource.Current;
            int pos = postehastipoluminariaBindingSource.Find("id",rowView["id"]);
            postehastipoluminariaBindingSource.Position = pos;
        }
    }
}