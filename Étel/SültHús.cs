using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Étel
{
	internal class SültHús : Étel
	{
		public SültHús(double caloriesPerDkg, double weight, string name, bool isItDairyFree) : base(caloriesPerDkg, weight, name)
		{
			IsItDairyFree = isItDairyFree;
		}

		public override double CountCalories()
		{
			return (CaloriesPerDkg * Weight) / 100;
		}
	}
}
