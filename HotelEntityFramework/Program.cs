using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HotelContext())
            {
                var AllHotels = from h in db.Hotel
                                select h;

                foreach (var item in AllHotels)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            
        }
    }
}
