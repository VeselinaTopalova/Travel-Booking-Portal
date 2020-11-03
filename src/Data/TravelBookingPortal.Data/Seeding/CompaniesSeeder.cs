namespace TravelBookingPortal.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using TravelBookingPortal.Data.Models;

    public class CompaniesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Companies.Any())
            {
                return;
            }
            var companies = new List<Company>();

            companies.Add(new Company
            {
                Name = "Exodus Travels",
                Address = "Grange Mills, Weir Road - SW12 0NE, London",
                AboutUs = @"It is all about adventure. That is what Exodus was founded upon and what the company is still all about. Discovering countries, cultures, environments, cities, mountain ranges, deserts, coasts and jungles; exploring this amazing planet we all live on.

You know you’re in good hands with Exodus. All our office staff have a passion for travel and adventure, and between us we’ve notched up experience that spans 171 different countries – all of which means we know how to give you the best experience when you travel with us. We’ve even won awards for it.

That’s not all. In their former lives, our team members have been professional archaeologists, wildlife guides, overland drivers, mountain leaders, diving and ski specialists and mountain bike gurus – and we use our expertise to give you the very best adventure possible. Extensive planning, research, fact-finding and training are just some of the ways this expertise comes through in your adventure.",
                WhyBookWithUs = "At Exodus, we know what makes you tick when it comes to holidays. It’s a desire shared by so many others. A yearning to visit new places and come home with a real sense of what they’re all about. This means delving into local traditions, cultures, cuisine, lifestyles – anything that contributes to its unique identity. At the same time, we always remember that we are only guests. So we travel courteously and respectfully, in smaller groups to minimize our impact, to ensure that every Exodus holiday is a beneficial experience for everyone involved.",
                Logo = "https://www.bookmundi.com/files/resized/400x400/892178baef384ab5bf7b0c713a9faa55_1525323648.JPG",
                YearEstablished = "1974",
            });
            companies.Add(new Company
            {
                Name = "Sherpa Expeditions",
                Address = "1B Osiers Road - SW18 1NL, London, England",
                AboutUs = @"In more than 20 countries across Europe, Sherpa Expeditions offers walking and cycling holidays. Whether you are interested in self guided trips or like to be escorted by an experienced leader, Sherpa Expeditions can help you organise your active European holiday.
Holidays are a sacred thing for all of us, so of course you want to make sure that you have got the best people looking after you. We’ve found the reasons why people choose to travel with Sherpa Expeditions and keep coming back year after year, all come down to three important elements; our experience, our people and your holiday.
You overnight where available in locally owned and operated B&Bs, hotels and inns to provide you with a charming local experience.",
                Logo = "https://www.bookmundi.com/files/resized/400x400/8d04c1cd8a6a2a7acfc5a2228dd9d6dc_1528279398.JPG",
                YearEstablished = "1973",
            });

            companies.Add(new Company
            {
                Name = "G Adventures",
                Address = "19 Charlotte St - ON M5, Toronto , Canada",
                AboutUs = @"Started by Bruce Poon Tip in the year 1990, G Adventures transformed from a young man’s vision into a global conglomerate in a very short amount of time. As an enthusiastic and passionate traveler, Bruce dreamt of sharing his travel experience with the world. Giving birth to G Adventures with nothing but personal credit cards, this one-man army soon emerged with over 2000 employees spread over 23 different offices all over the world. Now catering to more than 150000 travelers each year, G Adventures is truly one of the largest and most passionate tour operators out there.

A Sense of Adventure
Ever had that overpowering feeling of heading off to an adventure after watching movies like Lord of the Rings, Pirates of the Caribbean, Indiana Jones and Tomb Raider? Adventure travel has a way of making you fall in love with the world, helping you discover yourself and learn unique skillsets as you explore the planet, meet new people and get your adrenaline pumping. G Adventures will help you do all that.",
                WhyBookWithUs = @"- 100% Guaranteed Departures
- Lifetime Deposits
- 24/7 Service
- Smaller groups
- Responsible Travel",
                Logo = "https://www.bookmundi.com/files/resized/400x400/c425c7686f76a399bf4633c45137da14_1525323693.JPG",
                YearEstablished = "1990",
            });

            foreach (var company in companies)
            {
                await dbContext.Companies.AddAsync(company);
            }
        }
    }
}
