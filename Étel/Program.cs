namespace Étel
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Étel> etterem = new List<Étel>
			{
				new Leves(100, 20, "Krumplileves", true),
				new Leves(300, 10, "Gyümölcsleves", false),
				new Leves(50, 2000, "Húsleves", true),

				new Kenyérfélék(30, 10, "Magsvaskenyér", false),
				new Kenyérfélék(10, 5, "Rozsoskenyér", false),
				new Kenyérfélék(60, 10, "Mindeneskenyér", false),

				new SültHús(40, 10, "SZarvashús", true),
				new SültHús(50, 20, "Marhahús", true),
				new SültHús(60, 5, "Disznóhús", true),

			};

			

            

			List<Étel> dairyFree = new List<Étel>();

			for (int i = 0;i < etterem.Count; i++)
			{
				if (etterem[i].IsItDairyFree == true)
				{
					dairyFree.Add(etterem[i]);
				}
			}

           for (int i = 0; i < dairyFree.Count; i++)
			{
				Console.WriteLine(dairyFree[i].Name);
			}

           

        }

		public double sumCalories(List<Étel> etterem)
		{
			double sum = 0;
			for (int i = 0; i < etterem.Count; i++)
			{
				sum += etterem[i].CaloriesPerDkg;
				return sum;
			}
			return 0;
		}


	}
}
