using System;
using System.Linq;
using System.Collections.Generic;

namespace EAD_Ca3.Data
{
    public class TempUser
    {
		public List<Photo> myFavs;
		public List<Photo> SortedList;

		public string name { get; init; } = "toasty";


		public TempUser()
		{


			this.myFavs = new List<Photo>();
		}

		public void sortFavs()
		{

			if(myFavs != null)
            {

				SortedList = myFavs.OrderBy(p => p.earth_date).ToList();
				foreach (var item in SortedList)
				{
					Console.WriteLine(item);
				}

			}
            else
            {
				Console.WriteLine("No list available");
            }
			

		}


		public void viewFavorites()
		{
			foreach (var item in myFavs)
			{
				Console.WriteLine(item);
			}
		}


	}
}
