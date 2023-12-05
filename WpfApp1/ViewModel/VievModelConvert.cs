using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.ModelSupport;

namespace WpfApp1.ViewModel
{
    internal class VievModelConvert: BaseViewModel
    {
		
		private List<Moneta> _moneta;
					   

		public List<Moneta> Moneta
		{
			get { return _moneta; }
			set { _moneta = value;  PropChanged("Moneta"); }
		}


		

		public VievModelConvert()
		{
			Moneta = new List<Moneta>()
            {
				
			new Moneta()
			{

				Value = 0,
				Text = "EUR",
			

			},
			new Moneta()
				{

				Value = 1,
				Text = "ITL",

				},
			new Moneta()
			{
				Value = 2,

			Text="FRF"
			},
			new Moneta()
			{
				Value=3,
				Text="DEM"
			}


			};

			

		}


		public void Converti()
		{


            if ( Moneta[1].Value==1)
            {
                MessageBox.Show($"Haiscelto la lira {Moneta.Count}");

            }
           else if ( Moneta[2].Value==2)
            {
                MessageBox.Show("Haiscelto la FRF");

            }
			else if ( Moneta[3].Value == 3)
			{

			}

        }








    }
}
