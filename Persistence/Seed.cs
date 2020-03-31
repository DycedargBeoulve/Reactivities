using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {
                var actitvities = new List<Activity>{
                    new Activity{
                        Title = "Past Activity 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description="Activity 2 months ago",
                        Category = "drinks",
                        City ="London",
                        Venue="Pub"
                    },
                    new Activity{
                        Title = "Past Activity 2",
                        Date = DateTime.Now.AddMonths(-3),
                        Description="Activity 3 months ago",
                        Category = "foods",
                        City ="Paris",
                        Venue="Pub"
                    },
                    new Activity{
                        Title = "Past Activity 3",
                        Date = DateTime.Now.AddMonths(-4),
                        Description="Activity 4 months ago",
                        Category = "dancing",
                        City ="Hong Kong",
                        Venue="Restaurant"
                    },
                    new Activity{
                        Title = "Past Activity 4",
                        Date = DateTime.Now.AddMonths(-5),
                        Description="Activity 5 months ago",
                        Category = "talking",
                        City ="Managua",
                        Venue="Bar"
                    },
                    new Activity{
                        Title = "Past Activity 5",
                        Date = DateTime.Now.AddMonths(-6),
                        Description="Activity 6 months ago",
                        Category = "gaming",
                        City ="California",
                        Venue="Big House"
                    },
                    new Activity{
                        Title = "Past Activity 6",
                        Date = DateTime.Now.AddMonths(-7),
                        Description="Activity 7 months ago",
                        Category = "jumping",
                        City ="Roma",
                        Venue="Stadium"
                    },
                    new Activity{
                        Title = "Past Activity 7",
                        Date = DateTime.Now.AddMonths(-8),
                        Description="Activity 8 months ago",
                        Category = "playing",
                        City ="Caracas",
                        Venue="Park"
                    },
                    new Activity{
                        Title = "Past Activity 8",
                        Date = DateTime.Now.AddMonths(-9),
                        Description="Activity 9 months ago",
                        Category = "eating",
                        City ="Tokio",
                        Venue="Ramen pub"
                    },
                    new Activity{
                        Title = "Past Activity 9",
                        Date = DateTime.Now.AddMonths(-10),
                        Description="Activity 10 months ago",
                        Category = "trip",
                        City ="Yokohama",
                        Venue="Yokohama port"
                    },
                    new Activity{
                        Title = "Past Activity 10",
                        Date = DateTime.Now.AddMonths(-11),
                        Description="Activity 11 months ago",
                        Category = "walking",
                        City ="Wu han",
                        Venue="market"
                    }
                };
                context.Activities.AddRange(actitvities);
                context.SaveChanges();
            }
        }
    }
}