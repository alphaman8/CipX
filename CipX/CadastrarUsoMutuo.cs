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
    public partial class CadastrarUsoMutuo : Form
    {
        public CadastrarUsoMutuo()
        {
            InitializeComponent();
        }

        private void CadastrarUsoMutuo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eletrocadDataSet.poste_has_uso_mutuo' table. You can move, or remove it, as needed.
            this.poste_has_uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.poste_has_uso_mutuo);
            // TODO: This line of code loads data into the 'eletrocadDataSet.uso_mutuo' table. You can move, or remove it, as needed.
            this.uso_mutuoTableAdapter.Fill(this.eletrocadDataSet.uso_mutuo);

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}