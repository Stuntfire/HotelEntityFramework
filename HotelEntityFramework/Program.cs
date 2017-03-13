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

            ////Opgave 3a: List hotelnavn, adresse, samt værelsesinformation(nr, type, pris) om de værelser hotellerne har
            //using (var db = new HotelContext())
            //{
            //    var ListAllHotelsAndAllRooms = from h in db.Hotel
            //                                   join r in db.Room
            //                                   on h.Hotel_No equals r.Hotel.Hotel_No
            //                                   orderby h.Hotel_No
            //                                   select new { h.Name, h.Address, r.Room_No, r.Types, r.Price };

            //    foreach (var item in ListAllHotelsAndAllRooms)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}



            //Opgave 3b: List alle de reservationer hver enkelt værelse har.

            //using (var db = new HotelContext())
            //    db.Guest.Add(new Guest) = { Guest_No = 32, "Søren", "Nygade 4"};
            ////db.Guest.Add(32, "Søren", "Nygade 4");
            //{
            //    var ListAllReservationsOnEveryRoom = from b in db.Booking
            //                                         group b by b.Room_No
            //                                         into bookingGroup
            //                                         orderby bookingGroup.Key
            //                                         //select bookingGroup.Count();
            //                                         //join r in db.Room
            //                                         //on b.Room_No equals r.Room_No
            //                                         //orderby b.Hotel_No
            //                                         select new
            //                                         {
            //                                             Room_No = bookingGroup.Key,
            //                                             CountReservations = bookingGroup.Count()
            //                                         };


            //    foreach (var item in ListAllReservationsOnEveryRoom)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    // var ListAllReservationsOnEveryRoom =
            //    //    from r in db.Room
            //    //    group r by r.Room_No
            //    //in
            //}


            //Opgave 4a
            using (var db = new HotelContext())
            {
                var newGuest = db.Set<Guest>();
                newGuest.Add(new Guest { Guest_No = 32, Name = "Søren Roed Schack", Address = "Nygade 4" });
                db.SaveChanges();
            }



            Console.ReadLine();

        }
    }
}
