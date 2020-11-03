using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBookingPortal.Data.Models;

namespace TravelBookingPortal.Data.Seeding
{
    public class ToursSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Tours.Any())
            {
                return;
            }
            var tours = new List<Tour>();
            tours.Add(new Tour
            {
                Name = "Glamping Asia: A Luxury Camping Experience Thailand, Laos & Cambodia",
                Price = 9990m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(11),
                Highlights = @"Join a brandnew itinerary that blends amazing cultural encounters and exquisite architectural wonders with stays at some of the region’s most luxurious, and unique, properties.
Savour delectable local cuisine, browse colourful markets overflowing with exotic produce, learn to prepare regional specialties during handson cooking classes, and shop for highquality handicrafts, including exquisite silks.
Discover the charming town of Luang Prabang, once home to the royal family, and explore the palace, pagodas, lovely temples, and participate in a morning almsgiving.
Explore the exquisite temple complexes of magical Angkor Wat, a UNESCO World Heritage Site.
The tour Glamping Asia: A Luxury Camping Experience Thailand, Laos & Cambodia starts from and ends in Bangkok. This is a trekking tour that takes 11 days. You will travel through Laos, Thailand and Cambodia and visit Bangkok, Luang Prabang and Phuket. This is a guided small group tour that includes accommodation, transport, meals and others.

This corner of Asia is a blend of urban, rural, and unspoilt wilderness areas famous for its well-preserved architecture, religions, culture, perfect beaches, wildlife, and tasty cuisine. Thailand, Laos, and Cambodia are geographically south east of the Indian subcontinent and south of China.We'll stay at some of Asia's most luxurious tented properties as you discover the many charms of lovely Luang Prabang, the amazing ruins of Siem Reap, and the lush natural beauty of Koh Yoa Noi Island.",
                Included = @"ACCOMMODATION
All accommodations
MEALS
All group meals, including selected beverages with lunch and dinner
OTHERS
Flights within the itinerary
All excursions in the company of a world-class expedition leader and local guides
All gratuities
All entrance fees
Arrival and departure transfers on group dates
Gift certificates for recommended expedition gear
Medical expense coverage and emergency evacuation insurance.",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/glamping-asia-a-luxury-camping-experience-thailand-laos-and-cambodia-tour-2-516212_1584077075.JPG",
                Activity = Activity.Adventure,
                CompanyId = 1,
                DestinationId = 1,
            });

            tours.Add(new Tour
            {
                Name = "Finnish Wilderness Week",
                Price = 2579m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(8),
                Highlights = @"Enjoy a host of winter activities in magical surroundings
Stay in fantastic lodge accommodation
Experience an evening snowshoeing under the Northern Lights 
The Finnish Wilderness Week tour starts and ends in Basecamp Oulanka. It is a winter adventures tour that takes 8 days taking you through Riisitunturi National Park, Oulanka National Park and Juuma Lake in Finland. Finnish Wilderness Week is a guided small group tour that includes accommodation, transport, meals and others.

In the heart of Oulanka National Park sits Basecamp Oulanka, a self-sustained complex of wooden buildings in a truly stunning location. In one of the most sparsely populated areas in Europe, you are able to enjoy a variety of winter activities in this beautiful landscape and hardly ever see another soul. Dogsledding through the silent snow-caked forests, you couldn’t feel more removed from the hustle and bustle of city life. Get back to nature this winter and head to Basecamp.",
                Included = @"ACCOMMODATION
All accommodation
MEALS
All breakfasts, 5 lunches and 7 dinners
TRANSPORT
All transport and listed activities
(if booking incl. flights)
OTHERS
7 nights Basecamp Oulanka: twin/double rooms two separate buildings
5 days mixed activities
Group normally starting from 4, plus leaders. Min age 16 years
All Arctic winter equipment and clothing provided
Local tour leaders throughout
All specialist equipment",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/finnish-wilderness-week-tour-2-348215_1592536791.JPG",
                Activity = Activity.Adventure,
                CompanyId = 1,
                DestinationId = 2,
            });

            tours.Add(new Tour
            {
                Name = "Greenland Adventure: Explore by Sea, Land and Air",
                Price = 11495m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(9),
                Highlights = @"Experience an indepth exploration of Southern Greenland from land, sea and air
Enjoy included helicopter excursions for a unique perspective of this rarely visited region
Participate in optional helicopter adventure options such as Alpine Kayaking, Greenland Camp Experience and Mountain Biking
Learn about the environment and wildlife from our onboard Polar experts
The tour Greenland Adventure: Explore By Sea, Land And Air starts from and ends in Reykjavik. This is a polar expeditions and cruise tour that takes 9 days taking you through Reykjavik, Tunulliarfik Fjord, Narsarsuaq and Reykjavik in Iceland and Greenland. This is a guided group tour that includes accommodation in hotels, transport, meals and others.",
                Included = @"ACCOMMODATION
7 nights on the ship, 1 night hotel in Reykjavik , All accommodation
MEALS
Beer and house wine during dinner
TRANSPORT
All transport and listed activities
We can include flights from the UK.  Please contact us for a quote.
OTHERS
Expedition cruising in comfortable conditions
All meals while on the ship
Tour leader throughout and qualified Expedition Staff",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/greenland-adventure-explore-by-sea-land-and-air-tour-2-516210_1584077095.JPG",
                Activity = Activity.BoatTours,
                CompanyId = 1,
                DestinationId = 2,
            });

            tours.Add(new Tour
            {
                Name = "National Parks and Lodges",
                Price = 7599m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(15),
                Highlights = @"Stay in historic national park lodges and hotels
Navajo guided backroads tour of Monument Valley 
Salt Lake City tour guided by local Mormon
Six USA National Parks; Yosemite, Death Valley, Zion, Grand Canyon, Arches & Yellowstone
Start in San Francisco and end in Bozeman, the National Parks And Lodges tour is a guided cultural, religious and historic sites tour that takes 15 days. You will travel through Arches National Park, Zion National Park, Alcatraz Island and 8 other destinations in the USA. National Parks And Lodges is a small group tour which includes accommodation, transport and others.",
                Included = @"ACCOMMODATION
2 hotel nights and 12 lodge nights included , All accommodation
TRANSPORT
Travel by private minibus
All transport and listed activities
We can include flights from the UK.  Please contact us for a quote.
OTHERS
Variety of daywalks to suit all abilities
Some long journeys
Group normally 6 to 13, plus leader. Min age 16 yrs
Tour leader throughout",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/national-parks-and-lodges-tour-2-507257_1578308659.JPG",
                Activity = Activity.Wildlife,
                CompanyId = 1,
                DestinationId = 4,
            });

            tours.Add(new Tour
            {
                Name = "The Wildstrubel Circuit",
                Price = 1804m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(8),
                Highlights = @"The ‘quieter’ Alpine classic
Includes two stages of the famous Alpine Pass Route
Stroll between German and French speaking Cantons
The Wildstrubel Circuit tour starts from and ends in Kandersteg. It is a walking tour that takes 8 days taking you through Crans-Montana, Adelboden and Lenk im Simmental in Switzerland. The Wildstrubel Circuit is a self-guided tour that includes accommodation, transport, meals and others.",
                Included = @"ACCOMMODATION
7 nights accommodation in 3 star hotels on a twin share basis with ensuite facilities
Information pack including route notes & maps (1 pack per room booked)
MEALS
7 breakfasts, 4 dinners
TRANSPORT
Luggage transfer (1 bag per person not weighing anymore than 20kg)
OTHERS
Emergency hotline",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/the-wildstrubel-circuit-tour-2-432222_1553148002.JPG",
                Activity = Activity.Adventure,
                CompanyId = 2,
                DestinationId = 2,
            });

            tours.Add(new Tour
            {
                Name = "Cuba Libre",
                Price = 683m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(6),
                Highlights = @"Experience Cuban hospitality during a homestay.
Visit a tobacco farm that produces worldfamous Cuban cigars.
Discover Havana's street art
Start and end in Havana, the Cuba Libre tour is a guided explorer trip that takes 6 days. You will travel through Vinales, Havana and Soroa in Cuba. Cuba Libre is a small group tour which includes accommodation, transport, meals and others.

Wander among pincushion hills and colourful orchids on this tour through the Garden Province of Cuba. Find out what gives Cuban cigars their world-renowned reputation at a tobacco farm. Experience nature unfold in the UNESCO Biosphere Reserve of Las Terrazas. Soak up local culture in a homestay for an immersive experience that travellers rarely get to know. Let our knowledgeable CEO lead you off the beaten path and discover the cultural treasures of Cuba.",
                Included = @"ACCOMMODATION
Casas particulares (homestays) (5 nts).
MEALS
5 breakfasts
TRANSPORT
Private vehicle, walking.
STAFF & EXPERTS
CEO (Chief Experience Officer) throughout, local guides.
INCLUDED ACTIVITIES
Your Welcome Moment: Meet Your CEO and Group
Your Local Living Moment: Havana Homestay, Havana
Arrival transfer
Havana street art walk
Las Terrazas Biosphere Reserve visit
Tobacco farm visit
Viñales orientation walk
Walk through Old Havana with the CEO
Revolution Square visit (Havana)
Free time in Viñales
Informal Spanish lesson
All transport between destinations and to/from included activities",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/cuba-libre-tour-2-266368_1553148002.JPG",
                Activity = Activity.Explorer,
                CompanyId = 3,
                DestinationId = 4,
            });

            await dbContext.Tours.AddAsync(new Tour
            {
                Name = "Highlights of Portugal",
                Price = 1349m,
                DepartureDate = DateTime.UtcNow,
                ReturnDate = DateTime.UtcNow.AddDays(7),
                Highlights = @"Explore the seven hills of Lisbon.
Step back in history wandering charming hill towns.
Taste local delicacies and become a port wine connoisseur.
Soak up classic European culture.
The Highlights Of Portugal trip starts from Lisbon and ends in Porto. It is a local culture trip that takes 7 days taking you through Porto, Coimbra and Lisbon in Portugal. Highlights Of Portugal is a guided small group trip that includes accommodation in hotels, transport, meals and others.

In Portugal, the sun is bright, the food is delicious, and the living is easy. Wander the hilly streets of coastal Lisbon, where you can munch on a custard tart while gazing at sun-dappled architecture. Get your fill of history and culture at UNESCO World Heritage Sites like the Monastery of Batalha, Coimbra University, and the picturesque town of Sintra (optional). End the tour in Porto, where the majestic Douro Valley begs for you to lounge back with a glass of port wine in hand. Felicidades! And welcome to Portugal.",
                Included = @"ACCOMMODATION
Hotels (6 nts).
MEALS
6 breakfasts, 1 dinner
Note: Allow USD200-260 for meals not included.
TRANSPORT
Walking, private vehicle, train.
STAFF & EXPERTS
CEO (Chief Experience Officer) throughout, local guides.
INCLUDED ACTIVITIES
Your Welcome Moment: Meet Your CEO and Group
Your Foodie Moment: Fado Night with Traditional Portuguese Meal, Lisbon
Your Hands-On Moment: Port Wine Cellar Visit, Porto
Lisbon orientation walk
Fado performance with traditional Portuguese dinner
Batalha gothic monastery entrance and visit
Porto orientation walk
Port wine cellars visit and tasting
Transport to/from all included activities and between all destinations",
                Image = "https://d3hne3c382ip58.cloudfront.net/resized/750x420/highlights-of-portugal-tour-2-271157_1553147994.JPG",
                Activity = Activity.Sightseeing,
                CompanyId = 3,
                DestinationId = 2,
            });

            foreach (var tour in tours)
            {
                await dbContext.Tours.AddAsync(tour);
            }

        }
    }
}