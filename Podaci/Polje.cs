using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Podaci
{
    [Serializable]
    public class Polje
    {
        #region Atributes

        private bool _imaMinu;
        private bool _imaZastavicu;
        private bool _otkriveno;
        private int _x;
        private int _y;
        private Tabla _trenutnoStanje;

        #endregion 

        #region Konstruktori

        public Polje()
        {

        }

        public Polje(bool zastavica, bool mina, bool otkriveno, int x, int y, Tabla stanje)
        {
            _imaMinu = mina;
            _imaZastavicu = zastavica;
            _otkriveno = otkriveno;
            _x = x;
            _y = y;
            _trenutnoStanje = stanje;
        }

        public Polje(Polje p)
        {
            _imaMinu = p._imaMinu;
            _imaZastavicu = p._imaZastavicu;
            _otkriveno = p.Otkriveno;
            _x = p.X;
            _y = p.Y;
            _trenutnoStanje = p.TrenutnoStanje;
        }

        #endregion

        #region Properti

        [XmlElementAttribute("ImaMinu")]
        public bool ImaMinu
        {
            get { return _imaMinu; }
            set { _imaMinu = value; }
        }

        [XmlElementAttribute("ImaZastavicu")]
        public bool ImaZastavicu
        {
            get { return _imaZastavicu; }
            set { _imaZastavicu = value; }
        }

        [XmlElementAttribute("Otkriveno")]
        public bool Otkriveno
        {
            get { return _otkriveno; }
            set { _otkriveno = value; }
        }

        [XmlElementAttribute("X")]
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        [XmlElementAttribute("Y")]
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        [XmlIgnore]
        public Tabla TrenutnoStanje
        {
            get { return _trenutnoStanje; }
            set { _trenutnoStanje = value; }
        }

        #endregion

        #region Metode

        public int brojMinaOkolo()
        {
            int brojacMina = 0;
            for (int i = X-1; i <= X+1; i++)
            {
                for(int j = Y-1; j <= Y+1; j++)
                {
                    if( i >= 0 && i < TrenutnoStanje.DimenzijaX && j >= 0 && j < TrenutnoStanje.DimenzijaY
                        && (i != X || j != Y ))              
                    {
                        
                        if (_trenutnoStanje.PoljeValue[i, j].ImaMinu)
                            brojacMina += 1;
                    }
                }
            }
            return brojacMina;
        }

        #endregion
    }
}
