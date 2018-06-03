using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           //Kataxoro ta onomata ton tainion kai ta ratings tous
            var movie1 = new Movies();
            { movie1.movieTitle = "Catch me if you Can ";  movie1.rating = 6; }
            var movie2 = new Movies();
            { movie2.movieTitle = "Phantom of the Opera "; movie2.rating = 7; }
            var movie3 = new Movies();
            { movie3.movieTitle = "Sound of Music "; movie3.rating = 8; }
            var movie4 = new Movies();
            { movie4.movieTitle = "West Side Story"; movie4.rating = 5; }
            var movie5 = new Movies();
            { movie5.movieTitle = "Rent "; movie5.rating = 10; }
            var movie6 = new Movies();
            { movie6.movieTitle = "Loveless "; movie6.rating = 4; }
            var movie7 = new Movies();
            { movie7.movieTitle = "The Incredibles "; movie7.rating = 5; }
            var movie8 = new Movies();
            { movie8.movieTitle = "Xmens Origin "; movie8.rating = 4; }
            var movie9 = new Movies();
            { movie9.movieTitle = "How to traing your Dragon 1 "; movie9.rating = 6; }
            var movie10 = new Movies();
            { movie10.movieTitle = "Game Night "; movie10.rating = 7; }
            var movie11 = new Movies();
            { movie11.movieTitle = "Leviathan "; movie11.rating = 9; }
            var movie12 = new Movies();
            { movie12.movieTitle = "The Return "; movie12.rating = 7; }
            var movie13 = new Movies();
            { movie13.movieTitle = "Cabaret "; movie13.rating = 4; }
            var movie14 = new Movies();
            { movie14.movieTitle = "Finding Nemo "; movie14.rating = 8; }
            var movie15 = new Movies();
            { movie15.movieTitle = "Finding Dory "; movie15.rating = 7; }

                       

            
            //Ftiaxno ena 2d Array opou vazo to rating kai to onoma tis tainias
            var ratingsList = new(int, string)[]
  {
      (movie1.rating,movie1.movieTitle),
      (movie2.rating,movie2.movieTitle),
      (movie3.rating,movie3.movieTitle),
      (movie4.rating,movie4.movieTitle),
      (movie5.rating,movie5.movieTitle),
      (movie6.rating,movie6.movieTitle),
      (movie7.rating,movie7.movieTitle),
      (movie8.rating,movie8.movieTitle),
      (movie9.rating,movie9.movieTitle),
      (movie10.rating,movie10.movieTitle),
      (movie11.rating,movie11.movieTitle),
      (movie12.rating,movie12.movieTitle),
      (movie13.rating,movie13.movieTitle),
      (movie14.rating,movie14.movieTitle),
      (movie15.rating,movie15.movieTitle),
  };
            //Taksinomo ton Pinaka me tis tainies vasi tou rating tous
            Array.Sort(ratingsList);

            //Antristrefo ton Pinaka
            Array.Reverse(ratingsList);


            Console.WriteLine("Οι 10 καλύτερες ταινίες βάσει τις προτιμήσεις των χρηστών είναι");
            //Emfanizo tis 10tainies me ta Ipsilotera Ratings
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+1+". ");
                Console.WriteLine( ratingsList[i]);
                

            }
            Console.ReadKey();



        }
    }

    public class Movies
    {
        public string movieTitle;
        public int rating;
        public long tickets;
        public string actors;
        public string reviews;
       
     }
}
