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

            ////Opgave 2a: laver en liste med alle hoteller og printer dem ud.
            //using (var db = new HotelContext())
            //{
            //    var AllHotels = from h in db.Hotel
            //                    select h;

            //    foreach (var item in AllHotels)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}

            ////Opgave 2b: laver en liste med alle gæsters informationer og printer dem ud.
            //using (var db = new HotelContext())
            //{
            //    var AllGuests = from g in db.Guest
            //                    select g;

            //    foreach (var item in AllGuests)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}

            //Opgave 3a: List hotelnavn, adresse, samt værelsesinformation(nr, type, pris) om de værelser hotellerne har
            using (var db = new HotelContext())
            {
                var ListAllHotelsAndAllRooms = from h in db.Hotel
                                               join r in db.Room
                                               on h.Hotel_No equals r.Hotel.Hotel_No
                                               orderby h.Hotel_No
                                               select new { h.Name, h.Address, r.Room_No, r.Types, r.Price };

                foreach (var item in ListAllHotelsAndAllRooms)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
