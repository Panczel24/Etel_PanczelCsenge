using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Étel
{
	internal abstract class Étel
	{
		double caloriesPerDkg;
		double weight;
		string name;

		public bool IsItDairyFree { get; set; }
		public double CaloriesPerDkg { get => caloriesPerDkg; set => caloriesPerDkg = value; }
		public double Weight { get => weight; set => weight = value; }
		public string Name { get => name; set => name = value; }

		//egy bool típusú publikusan írható és olvasható IsItDairyFree tulajdonságot - ha nagy betű és tulajdonság, akkor bizto kell get és set

		protected Étel(double caloriesPerDkg, double weight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.name = name;
			this.IsItDairyFree = false;
		}

		public abstract double CountCalories();//láthatósaá, jellemző, típus


	}
}
