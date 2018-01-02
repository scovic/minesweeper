using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;
using MinesweeperForm.Properties;
using Ekstenzije;
using System.Collections;


namespace MinesweeperForm
{
    

    [Serializable]
    public partial class FormGlavna : Form
    {
        #region Atributi

        private const int btnWidth = 30;  //sirina jednog dugmeta
        private const int btnHeight = 30;  // visina jednog dugmeta
        private Tabla _tablaForma;
        private Button[,] _polja; // da bi mogli da pristupamo dugmicima
        private short _sek;
        private short _min;
        private bool _pocetakIgre = false;

        #endregion

        #region Metode

        private void Inicijalizacija(int dimenzijaX, int dimenzijaY, int brMina)
        {
            _tablaForma = new Tabla(dimenzijaX, dimenzijaY, brMina);
            
            IscrtajDugmice();            
        }

        private void PrikaziMinu(Button b)
        {
            b.Image = Resources.bomb_icon;
        }

        private void OtvoriPolje(Button button)  // za jedno polje samo
        {
            if (button != null)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.Enabled = false;
                button.BackColor = Color.LightGray;

                int i = ((int)button.Tag) / 100;
                int j = ((int)button.Tag) % 100;

                _tablaForma.PoljeValue[i, j].Otkriveno = true;

            }
        }

        private void OtvoriOkolnaPolja(int x, int y)
        {
            Queue<Button> red = new Queue<Button>();
            OtvoriPolje(_polja[x, y]);
            red.Enqueue(_polja[x, y]);

            while (red.Count != 0)
            {
                var dugme = red.Dequeue();
                int xi = ((int)dugme.Tag) / 100;
                int yj = ((int)dugme.Tag) % 100;
                for (int i = xi - 1; i < xi + 2; i++)
                {
                    for (int j = yj - 1; j < yj + 2; j++)
                    {
                        if (i >= 0 && i < _tablaForma.DimenzijaX && j >= 0 && j < _tablaForma.DimenzijaY)
                        {
                            if (_tablaForma.PoljeValue[i, j].Otkriveno)
                            {
                                continue;
                            }
                            else if (_tablaForma.PoljeValue[i, j].brojMinaOkolo() != 0)
                            {
                                OtvoriPolje(_polja[i, j]);
                                _tablaForma.PoljeValue[i, j].Otkriveno = true;
                                _polja[i, j].Text = _tablaForma.PoljeValue[i, j].brojMinaOkolo().ToString();
                            }
                            else
                            {
                                OtvoriPolje(_polja[i, j]);
                                _tablaForma.PoljeValue[i, j].Otkriveno = true;
                                red.Enqueue(_polja[i, j]);
                            }
                        }
                    }
                }
            }
        }

        private void Klik(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int i = ((int)button.Tag) / 100;
            int j = ((int)button.Tag) % 100;

            if (e.Button == MouseButtons.Left && !_tablaForma.PoljeValue[i, j].ImaZastavicu)  // levi klik
            {
                if(_pocetakIgre == false)
                {
                    Tajmer.Start();
                    _pocetakIgre = true;
                }
               
                OtvoriPolje(button);
                

                if (_tablaForma.PoljeValue[i, j].ImaMinu)
                {
                    PrikaziMinu(button);
                    button.BackColor = Color.Red;
                    KrajIgre();  //kraj igre
                }
                else if (_tablaForma.PoljeValue[i, j].brojMinaOkolo() != 0 )
                {
                    button.Text = _tablaForma.PoljeValue[i, j].brojMinaOkolo().ToString();
                }
                else
                {
                    OtvoriOkolnaPolja(i, j);
                    
                }

            }
            else if ( e.Button == MouseButtons.Right)  // desni klik
            {
                

                if (_tablaForma.PoljeValue[i, j].ImaZastavicu == false)
                {
                    _polja[i, j].Image = Resources.Actions_flag;
                    _tablaForma.PoljeValue[i, j].ImaZastavicu = true;
                    
                    lblBrojMinaValue.Text = (int.Parse(lblBrojMinaValue.Text) -1).ToString();
                }
                else
                {
                    _polja[i, j].Image = null;
                    _tablaForma.PoljeValue[i, j].ImaZastavicu = false;
                    
                    lblBrojMinaValue.Text = (int.Parse(lblBrojMinaValue.Text) + 1).ToString();
                }

                
            }

            if (Pobeda())
                KrajIgre();

        }

        private void IscrtajDugmice()
        {

            lblBrojMinaValue.Text = _tablaForma.BrojMina.ToString();

            this.Width = btnWidth * (_tablaForma.DimenzijaY + 1);  // sirina == br kolona
            this.Height = btnHeight * (_tablaForma.DimenzijaX + 3); // visina == br redova

            _polja = new Button[_tablaForma.DimenzijaX, _tablaForma.DimenzijaY]; 
            int x = 5;
            int y = 50;

            for (int i = 0; i < _tablaForma.DimenzijaX; i++)  
            {
                for (int j = 0; j < _tablaForma.DimenzijaY; j++)
                {
                    var dugme = new Button();
                    dugme.Size = new Size(btnWidth, btnHeight);
                    dugme.Location = new Point(x, y);
                    dugme.FlatStyle = FlatStyle.Flat;
                    dugme.BackColor = Color.Gray;

                    dugme.MouseDown += new MouseEventHandler(Klik);
                  
                    dugme.Tag = i * 100 + j;

                    _polja[i, j] = dugme;
                    x += btnWidth - 1;
                    this.Controls.Add(dugme);

                }

                y += btnHeight - 1;
                x = 5;
            }
        }

        private void ObrisiDugmice()
        {
            for(int i = 0; i< _tablaForma.DimenzijaX; i++)
            {
                for (int j = 0; j < _tablaForma.DimenzijaY; j++)
                    this.Controls.Remove(_polja[i, j]);
            }
        }

        private void KrajIgre()
        {
            Tajmer.Stop();
            OtvoriSvaPolja();
            _pocetakIgre = false;

            DialogResult di = MessageBox.Show("Kraj igre. Nova igra?", "Kraj igre",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (di == System.Windows.Forms.DialogResult.Yes)
                Restart();
        }

        private void NovaIgra(int dimX, int dimY, int brMina)
        {
            if (_tablaForma != null)
            {
                ObrisiDugmice();
            }
            
            Inicijalizacija(dimX, dimY, brMina);
           
            _min = 0;
            _sek = 0;
            lblSec.Text = _sek.ToString();
            lblMin.Text = _min.ToString();
        }

        private void Restart()
        {
            if(_tablaForma != null)
            {
                NovaIgra(_tablaForma.DimenzijaX, _tablaForma.DimenzijaY, _tablaForma.BrojMina);
            }
        }

        private void OtvoriSvaPolja()
        {
            for(int i = 0; i < _tablaForma.DimenzijaX; i++)
            {
                for(int j = 0; j < _tablaForma.DimenzijaY; j++)
                {
                    if (_tablaForma.PoljeValue[i, j].ImaMinu && !_tablaForma.PoljeValue[i,j].ImaZastavicu)
                        PrikaziMinu(_polja[i, j]);
                    _polja[i, j].Enabled = false;
                }
            }
        }

        private void UcitajXML()
        {
            

            for(int i = 0; i < _tablaForma.DimenzijaX; i++)
            {
                for(int j = 0; j < _tablaForma.DimenzijaY; j++)
                {
                    if (_tablaForma.PoljeValue[i, j].Otkriveno == true)
                    {
                        OtvoriPolje(_polja[i, j]);
                        if (_tablaForma.PoljeValue[i, j].brojMinaOkolo() != 0)
                            _polja[i, j].Text = _tablaForma.PoljeValue[i, j].brojMinaOkolo().ToString();
                        
                    }
                        
                }
            }
        }

        private bool Pobeda()
        {
            for(int i =0; i < _tablaForma.DimenzijaX; i++)
            {
                for(int j =0; j < _tablaForma.DimenzijaY; j++)
                {
                    if (_tablaForma.PoljeValue[i, j].ImaMinu && !_tablaForma.PoljeValue[i, j].ImaZastavicu ||
                       !_tablaForma.PoljeValue[i, j].ImaMinu && _tablaForma.PoljeValue[i, j].ImaZastavicu)
                        return false;
                }
            }
            return true;
        }

        #endregion

        #region Konstruktor

        public FormGlavna()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventi

        private void Form1_Load(object sender, EventArgs e)
        {
            NovaIgra(9, 9, 10); 
            
               
        }

        private void Tajmer_Tick(object sender, EventArgs e)
        {
            _sek += 1;
            if(_sek == 60)
            {
                _min += 1;
                _sek = 0;
            }
            lblSec.Text = _sek.ToString();
            lblMin.Text = _min.ToString();
            
            
        }

        private void tsm9x9_Click_1(object sender, EventArgs e)
        {
            Tajmer.Stop();
           NovaIgra(9,9,10);
        }

        private void tsm10x10_Click(object sender, EventArgs e)
        {
            Tajmer.Stop();
            NovaIgra(10, 10, 15);
        }

        private void tsm15x15_Click(object sender, EventArgs e)
        {
            Tajmer.Stop();  // jer ukoliko si vec igrao, i promenis dimenzije igre, tajmer se odmah startuje, ne ceka klik
            NovaIgra(15, 15, 30);
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult di = MessageBox.Show("Da li zelite da izadjete?", "Izlazite?",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (di == DialogResult.No)
                e.Cancel = true;
        }

        private void tsmSnimi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files (*.xml)|*.xml";
            
            if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _tablaForma.PrebaciUNiz();
                _tablaForma.Serialize(sfd.FileName);
            }
        }

        private void tsmUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                _tablaForma = _tablaForma.Deserialize(ofd.FileName);
                _tablaForma.PrebaciUTablu();

                UcitajXML();
               
            }
        }

        private void tsmOdrediDim_Click(object sender, EventArgs e)
        {
            var frm = new FormKonfiguracija();

            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Tajmer.Stop();
                NovaIgra(frm.Redovi, frm.Kolone, frm.BrojMina);
            }
        }

        private void krajIgreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrajIgre();
        }

        #endregion

    }
}
