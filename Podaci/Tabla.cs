using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Podaci
{   
    [Serializable]
    public class Tabla
    {

        #region Atributi

        private Polje[,] _tabla;
        private int _dimenzijaX;    // broj redova
        private int _dimenzijaY;    // broj kolona  
        private int _brojMina;
        private Polje[] _niz;

        #endregion

        #region Properti

        [XmlElementAttribute("DimenzijaX")]
        public int DimenzijaX
        {
            get { return _dimenzijaX; }
            set { _dimenzijaX = value; }
        }

        [XmlElementAttribute("DimenzijaY")]
        public int DimenzijaY
        {
            get { return _dimenzijaY; }
            set { _dimenzijaY = value; }
        }

        [XmlArrayItem("Niz", typeof(Polje))]
        public Polje[] Niz
        {
            get
            {        
                return _niz;
            }

            set { _niz = value; }
        }

        [XmlElementAttribute("BrojMina")]
        public int BrojMina
        {
            get { return _brojMina; }
            set { _brojMina = value; }
        }

        [XmlIgnore]
        public Polje[,] PoljeValue
        {
            get { return _tabla; }
            set { _tabla = value; }
        }

        #endregion
      
        #region Metode

        private void PopuniTablu()  // dajemo vrednosti poljima
        { 
            
            for (int i = 0; i < _dimenzijaX; i++)
            {
                for (int j = 0; j < _dimenzijaY; j++)
                {
                    
                    _tabla[i, j] = new Polje(false, false, false, i, j, this);
                }
            }

            PostaviMine();
        }  

        private void PostaviMine()
        {
            if (_tabla != null)
            {
                Random rand = new Random();
                int brPostavljenihMina = 0;
                while (brPostavljenihMina < _brojMina)
                {
                    int i = rand.Next(0, DimenzijaX - 1);  // da bi dobili radnom mesta 
                    int j = rand.Next(0, DimenzijaY - 1);  // na koje postavljamo mine
                    if (!_tabla[i, j].ImaMinu)
                    {
                        _tabla[i, j].ImaMinu = true;
                        brPostavljenihMina += 1;
                    }
                }
            }
        }

        public void PrebaciUNiz()
        {
            _niz = new Polje[DimenzijaX * DimenzijaY];
            int index = 0;
            for(int i =0; i<_dimenzijaX; i++)
            {
                for(int j = 0; j < _dimenzijaY; j++)
                {
                    _niz[index] = _tabla[i, j];
                    index++;
                }
               
            }
        }

        public void PrebaciUTablu()
        {
            _tabla = new Polje[DimenzijaX, DimenzijaY];
            int index = 0;
            for (int i = 0; i < DimenzijaX; i++)
            {
                for(int j = 0; j < DimenzijaY; j++)
                {
                    _tabla[i, j] = new Polje(_niz[index]);
                    _tabla[i, j].TrenutnoStanje = this;
                    index++;
                }
            }
        }

        #endregion

        #region Konstruktori

        public Tabla()
        {
            
        }

        public Tabla(int dimenzijaX, int dimenzijaY, int brojMina)
        {
            _brojMina = brojMina;
            _dimenzijaX = dimenzijaX;
            _dimenzijaY = dimenzijaY;
            _tabla = new Polje[dimenzijaX, dimenzijaY];

            PopuniTablu();
        }

        public Tabla(int dimenzijaX, int dimenzijaY)
        {
            _dimenzijaX = dimenzijaX;
            _dimenzijaY = dimenzijaY;
            _tabla = new Polje[dimenzijaX, dimenzijaY];

            for (int i = 0; i < _dimenzijaX; i++)
            {
                for (int j = 0; j < _dimenzijaY; j++)
                {

                    _tabla[i, j] = new Polje();
                    
                }
            }
        }


        #endregion

    }
}
