using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspNetCoreAngularCliTemplate.Model
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideoContext(serviceProvider.GetRequiredService<DbContextOptions<VideoContext>>()))
            {
                if (context.Videos.Any())
                {
                    return;
                }

                context.Videos.AddRange(
                    new Video
                    {
                        Title = "Raghuvamsa Sudha",
                        Link = "https://www.youtube.com/watch?v=l89ZaBqYiTA",
                        Genre = "Music",
                        Watched= true
                    },
                    new Video
                    {
                        Title = "Kapil finds a match for Sarla",
                        Link = "https://www.youtube.com/watch?v=GfHEPKgkkpw",
                        Genre = "Comedy",
                        Watched = true
                    },
                    new Video
                    {
                        Title = "Arvind Gupta TED Talk",
                        Link = "https://www.youtube.com/watch?v=KnCqR2yUXoU",
                        Genre = "Inspirational",
                        Watched = true
                    },
                    new Video
                    {
                        Title = "Event Loop - Philip Roberts",
                        Link = "https://www.youtube.com/watch?v=8aGhZQkoFbQ",
                        Genre = "Tech",
                        Watched = true
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}