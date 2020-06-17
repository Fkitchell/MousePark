namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MousePark.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MousePark.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Parks.AddOrUpdate(x => x.ParkId,
            new Park() { ParkId = 1, ParkName = "Magic Kingdom", AdmissionPrice = 109 },
            new Park() { ParkId = 2, ParkName = "EPCOT", AdmissionPrice = 109 },
            new Park() { ParkId = 3, ParkName = "Hollywood Studios", AdmissionPrice = 109 },
            new Park() { ParkId = 4, ParkName = "Animal Kingdom", AdmissionPrice = 109 },
            new Park() { ParkId = 5, ParkName = "Typhoon Lagoon", AdmissionPrice = 69 },
            new Park() { ParkId = 6, ParkName = "Splashin' Safari", AdmissionPrice = 69 },
            new Park() { ParkId = 7, ParkName = "Disney Springs", AdmissionPrice = 0 }
            );

            context.Areas.AddOrUpdate(x => x.AreaId,
                new Area() { AreaId = 1, AreaName = "Main Street, U.S.A.", ParkId = 1 },
                new Area() { AreaId = 2, AreaName = "Tomorrowland", ParkId = 1 },
                new Area() { AreaId = 3, AreaName = "Fantasyland", ParkId = 1 },
                new Area() { AreaId = 4, AreaName = "Frontierland", ParkId = 1 },
                new Area() { AreaId = 5, AreaName = "Adventureland", ParkId = 1 },
                new Area() { AreaId = 6, AreaName = "Liberty Square", ParkId = 1 },
                new Area() { AreaId = 7, AreaName = "SpaceShip Earth", ParkId = 2 },
                new Area() { AreaId = 8, AreaName = "Future World East", ParkId = 2 },
                new Area() { AreaId = 9, AreaName = "Mission: Space", ParkId = 2 },
                new Area() { AreaId = 10, AreaName = "EPCOT Experience ", ParkId = 2 },
                new Area() { AreaId = 11, AreaName = "Showcase Plaza", ParkId = 2 },
                new Area() { AreaId = 12, AreaName = "World Showcase", ParkId = 2 },
                new Area() { AreaId = 13, AreaName = "Mexico", ParkId = 2 },
                new Area() { AreaId = 14, AreaName = "Norway", ParkId = 2 },
                new Area() { AreaId = 15, AreaName = "China", ParkId = 2 },
                new Area() { AreaId = 16, AreaName = "Outpost", ParkId = 2 },
                new Area() { AreaId = 17, AreaName = "Germany", ParkId = 2 },
                new Area() { AreaId = 18, AreaName = "Italy", ParkId = 2 },
                new Area() { AreaId = 19, AreaName = "The American Adventure", ParkId = 2 },
                new Area() { AreaId = 20, AreaName = "Japan", ParkId = 2 },
                new Area() { AreaId = 21, AreaName = "Morocco", ParkId = 2 },
                new Area() { AreaId = 22, AreaName = "France", ParkId = 2 },
                new Area() { AreaId = 23, AreaName = "International Gateway", ParkId = 2 },
                new Area() { AreaId = 24, AreaName = "United Kingdom", ParkId = 2 },
                new Area() { AreaId = 25, AreaName = "Canada", ParkId = 2 },
                new Area() { AreaId = 26, AreaName = "Imagination!", ParkId = 2 },
                new Area() { AreaId = 27, AreaName = "The Land", ParkId = 2 },
                new Area() { AreaId = 28, AreaName = "The Seas with Nemo and Friends", ParkId = 2 },
                new Area() { AreaId = 29, AreaName = "Future World West", ParkId = 2 },
                new Area() { AreaId = 30, AreaName = "Hollywood Boulevard", ParkId = 3 },
                new Area() { AreaId = 31, AreaName = "Echo Lake", ParkId = 3 },
                new Area() { AreaId = 32, AreaName = "Commissary Lane", ParkId = 3 },
                new Area() { AreaId = 33, AreaName = "Grand Avenue", ParkId = 3 },
                new Area() { AreaId = 34, AreaName = "Sunset Boulevard", ParkId = 3 },
                new Area() { AreaId = 35, AreaName = "Toy Story Land", ParkId = 3 },
                new Area() { AreaId = 36, AreaName = "Animation Courtyard", ParkId = 3 },
                new Area() { AreaId = 37, AreaName = "An Incredible Celebration", ParkId = 3 },
                new Area() { AreaId = 38, AreaName = "Oasis", ParkId = 4 },
                new Area() { AreaId = 39, AreaName = "Discovery Island", ParkId = 4 },
                new Area() { AreaId = 40, AreaName = "Camp Minnie-Mickey", ParkId = 4 },
                new Area() { AreaId = 41, AreaName = "Rafiki's Planet Watch", ParkId = 4 },
                new Area() { AreaId = 42, AreaName = "Africa", ParkId = 4 },
                new Area() { AreaId = 43, AreaName = "Asia", ParkId = 4 },
                new Area() { AreaId = 44, AreaName = "DinoLand U.S.A.", ParkId = 4 }
                );

            context.Rides.AddOrUpdate(x => x.ID,
                new Ride() { ID = 1, Name = "The Magic Carpets of Aladdin", RideDescription = "Fly high on a magic carpet above Adventureland", HeightReq = 0, RideType = RideType.Gentle, AreaId = 5 },
                new Ride() { ID = 2, Name = "Jungle Cruise", RideDescription = "There are snakes in the water", HeightReq = 0, RideType = RideType.Gentle, AreaId = 5 },
                new Ride() { ID = 3, Name = "Pirates of the Caribbean", RideDescription = "We wants the redhead!!!", HeightReq = 0, RideType = RideType.Gentle, AreaId = 5 },
                new Ride() { ID = 4, Name = "Splash Mountain", RideDescription = "Great for photo ops. Now racism-free!", HeightReq = 40, RideType = RideType.Water, AreaId = 4 },
                new Ride() { ID = 5, Name = "Big Thunder Mountain Railroad", RideDescription = "Ride through a gold-mining town on a runaway train", HeightReq = 40, RideType = RideType.RollerCoaster, AreaId = 4 },
                new Ride() { ID = 6, Name = "Liberty Square Riverboat", RideDescription = "Cruise the Rivers of America aboard the Liberty Belle", HeightReq = 0, RideType = RideType.Transportation, AreaId = 6 },
                new Ride() { ID = 7, Name = "Haunted Mansion", RideDescription = "Grim-grinning ghosts come out to socialize!", HeightReq = 0, RideType = RideType.Gentle, AreaId = 6 },
                new Ride() { ID = 8, Name = "Prince Charming Regal Carousel", RideDescription = "It goes in circles", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3 },
                new Ride() { ID = 9, Name = "Peter Pan's Flight", RideDescription = "You can fly! You can fly! You can fly!", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3 },
                new Ride() { ID = 10, Name = "it's a small world", RideDescription = "take a boat tour around the globe. once a year they clean out the money.", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3 },
                new Ride() { ID = 11, Name = "Under the Sea - Journey of The Little Mermaid", RideDescription = "It's hotta unda de watta.", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3 },
                new Ride() { ID = 12, Name = "The Barnstormer", RideDescription = "Baby coaster!", HeightReq = 35, RideType = RideType.RollerCoaster, AreaId = 3 },
                new Ride() { ID = 13, Name = "Dumbo the Flying Elephant", RideDescription = "It goes in circles", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3 },
                new Ride() { ID = 14, Name = "Mad Tea Party", RideDescription = "If you don't feel sick before the ride even starts, you're not spinning fast enough.", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3 },
                new Ride() { ID = 15, Name = "Seven Dwarves Mine Train", RideDescription = "The only ride in which it's a good thing to rock the boat", HeightReq = 38, RideType = RideType.RollerCoaster, AreaId = 3 },
                new Ride() { ID = 16, Name = "Tomorrowland Speedway", RideDescription = "Take a ride in your very own hot rod", HeightReq = 54, RideType = RideType.Thrill, AreaId = 2 },
                new Ride() { ID = 17, Name = "Space Mountain", RideDescription = "Twists and turns in the dark", HeightReq = 44, RideType = RideType.RollerCoaster, AreaId = 2 },
                new Ride() { ID = 18, Name = "Astro Orbiter", RideDescription = "Pilot your very own spaceship.", HeightReq = 0, RideType = RideType.Gentle, AreaId = 2 },
                new Ride() { ID = 18, Name = "Tomorrowland Transit Authority PeopleMover", RideDescription = "It moves people. If Space Mountain breaks, you can see inside with the lights on.", HeightReq = 0, RideType = RideType.Transportation, AreaId = 2 },
                new Ride() { ID = 19, Name = "Walt Disney's Carousel of Progress", RideDescription = "Great place for a nap", HeightReq = 0, RideType = RideType.Gentle, AreaId = 2 },
                new Ride() { ID = 20, Name = "Buzz Lightyear's Space Ranger Spin", RideDescription = "Moving arcade game. Defeat Zerg and make the high score board!", HeightReq = 0, RideType = RideType.Gentle, AreaId = 2 },
                new Ride() { ID = 21, Name = "Walt Disney World Railroad", RideDescription = "It's kind of iconic.", HeightReq = 0, RideType = RideType.Transportation, AreaId = 1},
                new Ride() { ID = 22, Name = "The Many Adventures of Winnie the Pooh", RideDescription = "Ride a hunney-pot deep into the Hundred Acre Wood", HeightReq = 0, RideType = RideType.Gentle, AreaId = 3}
                );

            context.Shows.AddOrUpdate(x => x.ID,
                new Show() { ID = 1, Name = "Walt Disney's Enchanted Tiki Room", Capacity = 230, RunTime = 17, AreaId = 5, TargetAge = TargetAge.All },
                new Show() { ID = 2, Name = "Country Bear Jamboree", Capacity = 350, RunTime = 16, AreaId = 4, TargetAge = TargetAge.All },
                new Show() { ID = 3, Name = "The Hall of Presidents", Capacity = 700, RunTime = 25, AreaId = 6, TargetAge = TargetAge.All },
                new Show() { ID = 4, Name = "Mickey's PhilharMagic", Capacity = 496, RunTime = 12, AreaId = 5, TargetAge = TargetAge.Child },
                new Show() { ID = 5, Name = "Enchanted Tales With Belle", Capacity = 120, RunTime = 20, AreaId = 5, TargetAge = TargetAge.Child },
                new Show() { ID = 6, Name = "Monsters, Inc. Laugh Floor", Capacity = 350, RunTime = 15, AreaId = 5, TargetAge = TargetAge.All },
                new Show() { ID = 7, Name = "Main Street Trolley Show", Capacity = 1000, RunTime = 20, AreaId = 1, TargetAge = TargetAge.All },
                new Show() { ID = 8, Name = "Happily Ever After", Capacity = 5000, RunTime = 18, AreaId = 1, TargetAge = TargetAge.All }
                );

            context.Eateries.AddOrUpdate(x => x.ID,
                new Eatery() { ID = 1, Name = "Main Street Bakery", AreaId = 1, DineIn = false, Tier = PriceTier.Low, CuisineType = "Starbucks, pastries" },
                new Eatery() { ID = 2, Name = "The Crystal Palace", AreaId = 1, DineIn = true, Tier = PriceTier.MidHigh, CuisineType = "American, Character" },
                new Eatery() { ID = 3, Name = "Sunshine Tree Terrace", AreaId = 5, DineIn = false, Tier = PriceTier.Low, CuisineType = "Ice Cream" },
                new Eatery() { ID = 4, Name = "Jungle Navigation Co. LTD Skipper Canteen", AreaId = 5, DineIn = true, Tier = PriceTier.MidLow, CuisineType = "South American, African, Asian" },
                new Eatery() { ID = 5, Name = "Golden Oak Outpost", AreaId = 4, DineIn = true, Tier = PriceTier.Low, CuisineType = "American" },
                new Eatery() { ID = 6, Name = "Pecos Bill Tall Tale Inn and Cafe", AreaId = 4, DineIn = true, Tier = PriceTier.Low, CuisineType = "Tacos, Burgers" },
                new Eatery() { ID = 7, Name = "Cinderella's Royal Table", AreaId = 3, DineIn = true, Tier = PriceTier.High, CuisineType = "American, Steakhouse, Character, Breakfast" },
                new Eatery() { ID = 8, Name = "Be Our Guest", AreaId = 3, DineIn = true, Tier = PriceTier.Middle, CuisineType = "French, Breakfast, Soups, Salads, Sandwiches" },
                new Eatery() { ID = 9, Name = "Liberty Square Market", AreaId = 6, DineIn = false, Tier = PriceTier.Low, CuisineType = "Turkey Legs, Snacks" },
                new Eatery() { ID = 10, Name = "The Diamond Horseshoe", AreaId = 6, DineIn = true, Tier = PriceTier.Middle, CuisineType = "Barbecue, Midwest, Family Style" },
                new Eatery() { ID = 11, Name = "Cosmic Ray's Starlight Cafe", AreaId = 2, DineIn = true, Tier = PriceTier.Low, CuisineType = "Burgers, Salad" },
                new Eatery() { ID = 12, Name = "Auntie Gravity's Galactic Goodies", AreaId = 2, DineIn = false, Tier = PriceTier.Low, CuisineType = "Ice Cream" }
                );
        }
    }
}
