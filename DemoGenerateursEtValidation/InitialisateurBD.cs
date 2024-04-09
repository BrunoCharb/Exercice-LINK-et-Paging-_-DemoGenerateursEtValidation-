using DemoGenerateursEtValidation.Models;

namespace DemoGenerateursEtValidation
{
    public static class InitialisateurBD
    {
        public static List<Auto> _auto = new List<Auto>
        {
            new Auto {Marque = "Toyota", Model = "Corolla", Prix = 25000 },
            new Auto{Marque = "Honda", Model = "Civic", Prix = 45000},
            new Auto{Marque = "Ford", Model = "Focus", Prix = 29000},
            new Auto{Marque = "Audi", Model = "Q5", Prix = 75000},
            new Auto{Marque = "Chevrolet", Model = "Cruze", Prix = 26000},
            new Auto{Marque = "Volkswagen", Model = "Golf", Prix = 32000},
            new Auto{Marque = "BMW", Model = "3 Series", Prix = 42000},
            new Auto{Marque = "Mercedes-Benz", Model = "C-Class", Prix = 51000},
            new Auto{Marque = "Nissan", Model = "Sentra", Prix = 23000},
            new Auto{Marque = "Hyundai", Model = "Elantra", Prix = 22000},
            new Auto{Marque = "Kia", Model = "Forte", Prix = 21000},
            new Auto{Marque = "Subaru", Model = "Impreza", Prix = 27000},
            new Auto{Marque = "Mazda", Model = "3", Prix = 28000},
            new Auto{Marque = "Jeep", Model = "Wrangler", Prix = 35000},
            new Auto{Marque = "Toyota", Model = "Camry", Prix = 33000},
            new Auto{Marque = "Honda", Model = "Accord", Prix = 34000},
            new Auto{Marque = "Ford", Model = "Fusion", Prix = 32000},
            new Auto{Marque = "Audi", Model = "A4", Prix = 45000},
            new Auto{Marque = "Chevrolet", Model = "Malibu", Prix = 28000},
            new Auto{Marque = "Volkswagen", Model = "Jetta", Prix = 26000},
            new Auto{Marque = "BMW", Model = "5 Series", Prix = 55000},
            new Auto{Marque = "Mercedes-Benz", Model = "E-Class", Prix = 60000},
            new Auto{Marque = "Nissan", Model = "Altima", Prix = 29000},
            new Auto{Marque = "Hyundai", Model = "Sonata", Prix = 26000},
            new Auto{Marque = "Kia", Model = "Optima", Prix = 27000},
            new Auto{Marque = "Subaru", Model = "Legacy", Prix = 29000},
            new Auto{Marque = "Mazda", Model = "6", Prix = 31000},
            new Auto{Marque = "Jeep", Model = "Grand Cherokee", Prix = 40000},
            new Auto{Marque = "Toyota", Model = "RAV4", Prix = 35000},
            new Auto{Marque = "Honda", Model = "CR-V", Prix = 36000},
            new Auto{Marque = "Ford", Model = "Escape", Prix = 33000},
            new Auto{Marque = "Audi", Model = "Q7", Prix = 67000},
            new Auto{Marque = "Chevrolet", Model = "Equinox", Prix = 32000},
            new Auto{Marque = "Volkswagen", Model = "Tiguan", Prix = 31000},
            new Auto{Marque = "BMW", Model = "X3", Prix = 48000},
            new Auto{Marque = "Mercedes-Benz", Model = "GLC-Class", Prix = 52000},
            new Auto{Marque = "Nissan", Model = "Rogue", Prix = 31000},
            new Auto{Marque = "Hyundai", Model = "Tucson", Prix = 28000},
            new Auto{Marque = "Kia", Model = "Sportage", Prix = 29000},
            new Auto{Marque = "Subaru", Model = "Forester", Prix = 33000},
            new Auto{Marque = "Mazda", Model = "CX-5", Prix = 34000},
            new Auto{Marque = "Jeep", Model = "Cherokee", Prix = 36000},
            new Auto{Marque = "Toyota", Model = "Highlander", Prix = 40000},
            new Auto{Marque = "Honda", Model = "Pilot", Prix = 42000},
            new Auto{Marque = "Ford", Model = "Explorer", Prix = 40000},
            new Auto{Marque = "Audi", Model = "A6", Prix = 57000},
            new Auto{Marque = "Chevrolet", Model = "Traverse", Prix = 37000},
            new Auto{Marque = "Volkswagen", Model = "Atlas", Prix = 35000},
            new Auto{Marque = "BMW", Model = "X5", Prix = 60000},
            new Auto{Marque = "Mercedes-Benz", Model = "GLE-Class", Prix = 65000},
            new Auto{Marque = "Nissan", Model = "Pathfinder", Prix = 38000},
            new Auto{Marque = "Hyundai", Model = "Santa Fe", Prix = 34000},
            new Auto{Marque = "Kia", Model = "Sorento", Prix = 35000},
            new Auto{Marque = "Subaru", Model = "Outback", Prix = 37000},
            new Auto{Marque = "Mazda", Model = "CX-9", Prix = 38000},
            new Auto{Marque = "Jeep", Model = "Renegade", Prix = 29000},
            new Auto{Marque = "Toyota", Model = "4Runner", Prix = 45000},
            new Auto{Marque = "Honda", Model = "Odyssey", Prix = 42000},
            new Auto{Marque = "Ford", Model = "Expedition", Prix = 55000},
            new Auto{Marque = "Audi", Model = "Q8", Prix = 80000},
            new Auto{Marque = "Chevrolet", Model = "Tahoe", Prix = 52000},
            new Auto{Marque = "Volkswagen", Model = "Passat", Prix = 30000},
            new Auto{Marque = "BMW", Model = "X7", Prix = 75000},
            new Auto{Marque = "Mercedes-Benz", Model = "GLS-Class", Prix = 70000},
            new Auto{Marque = "Nissan", Model = "Armada", Prix = 53000},
            new Auto{Marque = "Hyundai", Model = "Palisade", Prix = 42000},
            new Auto{Marque = "Kia", Model = "Telluride", Prix = 43000},
            new Auto{Marque = "Subaru", Model = "Ascent", Prix = 40000},
            new Auto{Marque = "Mazda", Model = "CX-30", Prix = 28000},
            new Auto{Marque = "Jeep", Model = "Compass", Prix = 29000},
            new Auto{Marque = "Toyota", Model = "Sienna", Prix = 40000},
            new Auto{Marque = "Honda", Model = "Ridgeline", Prix = 42000},
            new Auto{Marque = "Ford", Model = "Ranger", Prix = 35000},
            new Auto{Marque = "Audi", Model = "A8", Prix = 90000},
            new Auto{Marque = "Chevrolet", Model = "Colorado", Prix = 28000},
            new Auto{Marque = "Volkswagen", Model = "Arteon", Prix = 38000},
            new Auto{Marque = "BMW", Model = "4 Series", Prix = 48000},
            new Auto{Marque = "Mercedes-Benz", Model = "S-Class", Prix = 95000},
            new Auto{Marque = "Nissan", Model = "Frontier", Prix = 31000},
            new Auto{Marque = "Hyundai", Model = "Kona", Prix = 25000},
            new Auto{Marque = "Kia", Model = "Niro", Prix = 28000},
            new Auto{Marque = "Subaru", Model = "Crosstrek", Prix = 27000},
            new Auto{Marque = "Mazda", Model = "MX-5 Miata", Prix = 32000},
            new Auto{Marque = "Jeep", Model = "Gladiator", Prix = 35000},
            new Auto{Marque = "Toyota", Model = "Tacoma", Prix = 32000},
            new Auto{Marque = "Honda", Model = "Fit", Prix = 18000},
            new Auto{Marque = "Ford", Model = "F-150", Prix = 45000},
            new Auto{Marque = "Audi", Model = "S4", Prix = 59000},
            new Auto{Marque = "Chevrolet", Model = "Silverado", Prix = 40000},
            new Auto{Marque = "Volkswagen", Model = "ID.4", Prix = 42000},
            new Auto{Marque = "BMW", Model = "M3", Prix = 67000},
            new Auto{Marque = "Mercedes-Benz", Model = "AMG GT", Prix = 150000},
            new Auto{Marque = "Nissan", Model = "Titan", Prix = 45000},
            new Auto{Marque = "Hyundai", Model = "Veloster", Prix = 22000},
            new Auto{Marque = "Kia", Model = "Stinger", Prix = 40000},
            new Auto{Marque = "Subaru", Model = "BRZ", Prix = 30000},
            new Auto{Marque = "Mazda", Model = "CX-3", Prix = 26000},
            new Auto{Marque = "Jeep", Model = "Trackhawk", Prix = 90000},
            new Auto{Marque = "Toyota", Model = "Supra", Prix = 55000},
            new Auto{ Marque = "Honda", Model = "Insight", Prix = 28000}
        };

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AutoDbContext autoDbContext = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AutoDbContext>();

            if (!autoDbContext.Autos.Any())
            {
                autoDbContext.Autos.AddRange(_auto);
            }

            autoDbContext.SaveChanges();
        }
    }
}
