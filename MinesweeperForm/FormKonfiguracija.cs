using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperForm
{
    public partial class FormKonfiguracija : Form
    {
        #region Properti

        public int Redovi
        {
            get;
            set;
        }

        public int Kolone
        {
            get;
            set;
        }

        public int BrojMina
        {
            get;
            set;
        }

        #endregion

        #region Konstruktor

        public FormKonfiguracija()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventi

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Redovi = (int)numRed.Minimum;
            Kolone = (int)numKolone.Minimum;
            BrojMina = (int)numBrMina.Minimum;

            this.Close();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            Redovi = (int)numRed.Value;
            Kolone = (int)numKolone.Value;
            BrojMina = (int)numBrMina.Value;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        #endregion
    }
}
