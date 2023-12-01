using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.ModelSupport;

namespace WpfApp1.ViewModel
{
    internal class VievModelConvert: BaseViewModel
    {
		
		private float _eur;

		public float EUR
		{
			get { return _eur; }
			set { _eur = value; }
		}


		private int _ITL;

		public int ITL
		{
			get { return _ITL; }
			set { _ITL = value; }
		}

		private int _valore;

		public int Valore
		{
			get { return _valore; }
			set { _valore = value; PropChanged("Valore"); }
		}




		private int _FRF;

		public int FRF
		{
			get { return _FRF; }
			set { _FRF = value; }
		}

        private double _valoreeur;

        public double ValoreEur {
			get { return _valoreeur; } 
			set { _valoreeur = value; PropChanged("ValoreEuro"); 
			}
		}

		private double _risultato;

		public double Risultato
		{
			get { return _risultato; }
			set { _risultato = value; PropChanged("Risultato"); }
		}

		private string _moneta;

		public string Monete
		{
			get { return _moneta; }
			set { _moneta = value; PropChanged("Moneta"); }
		}



		public VievModelConvert()
		{
			_moneta = new List<Moneta>()
            {
			new Moneta()
			{

				value = 0,
				text = "EUR",

			},
			new Moneta()
				{

				value = 1,
				text = "ITL",

				},
			new Moneta()
			{
				value = 2,

			text="FRF"
			},
			new Moneta()
			{
				value=3,
				text="DEM"
			}


			};

			_moneta = Monete;

		}


		public void Converti()
		{



		}



		public void ConveredDEM() => _risultato= _valoreeur * 1.96;
        public void ConveredITL() => _risultato = _valoreeur * 1936;
        public void ConveredFRF() => _risultato = _valoreeur * 6.56 ;





    }
}
