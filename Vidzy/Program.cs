using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyDbContext();

            var genre1 = new Genre()
            {
                Name = "Thriller",
                //Id = 1
            };
            var genre2 = new Genre()
            {
                Name = "Romance",
                //Id = 2

            };
            var genre3 = new Genre()
            {
                Name = "Action",
                //Id = 3
            };
            var video1 = new Video
            {
                Name = "Video 1",
                ReleaseDate = new DateTime(2011, 1, 11),
                Genre = genre3,
                //Id = 1
            };
            var video2 = new Video
            {
                Name = "Video 2",
                ReleaseDate = new DateTime(2012, 2, 12),
                Genre = genre2,
                //Id = 2
            };
            var video3 = new Video
            {
                Name = "Video 3",
                ReleaseDate = new DateTime(2013, 3, 13),
                Genre = genre3,
                //Id = 3
            };
            //genre1.Videos.Add(video1);
            //genre2.Videos.Add(video2);
            //genre3.Videos.Add(video3);


            //context.Videos.Add(video1);
            //context.Videos.Add(video2);
            //context.Videos.Add(video3);

            //context.Genres.Add(genre1);
            //context.Genres.Add(genre2);
            //context.Genres.Add(genre3);
            //context.Videos.RemoveRange(context.Videos.AsParallel());
            context.AddVideo(video1.Name, video1.ReleaseDate, video1.Genre.Name);
            context.AddVideo(video2.Name, video2.ReleaseDate, video2.Genre.Name);
            context.AddVideo(video3.Name, video3.ReleaseDate, video3.Genre.Name);
            context.SaveChanges();


            foreach (Video video in genre1.Video)
            {
                Console.WriteLine(video.Name);
                //Console.WriteLine(video.Id);
            }
            /*Console.WriteLine();
            foreach (Genre genre in video1.Genres)
            {
                Console.WriteLine(genre.Name);
                //Console.WriteLine(genre.Id);
            }*/
        }
    }
}
