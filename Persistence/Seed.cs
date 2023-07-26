using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activities>
            {
                new Activities
                {
                    Title = "Past Activities 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activities 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activities
                {
                    Title = "Past Activities 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activities 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activities
                {
                    Title = "Future Activities 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activities 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activities
                {
                    Title = "Future Activities 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activities 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Activities
                {
                    Title = "Future Activities 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activities 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Activities
                {
                    Title = "Future Activities 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activities 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Activities
                {
                    Title = "Future Activities 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activities 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Activities
                {
                    Title = "Future Activities 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activities 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activities
                {
                    Title = "Future Activities 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activities 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activities
                {
                    Title = "Future Activities 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activities 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}