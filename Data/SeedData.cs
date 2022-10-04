using Country.Models;
using Microsoft.EntityFrameworkCore;
public static class SeedData
{
    //this is an extension method to the ModelBuilder class

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
        new Province(){ //1
            ProvinceCode = "AB",
            ProvinceName = "Alberta"
        },
        new Province(){ //2
            ProvinceCode = "BC",
            ProvinceName = "British Columbia"
        },
        new Province(){ //3
            ProvinceCode = "MB",
            ProvinceName = "Manitoba"
        }
    };
        return provinces;
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City {  //1
                CityId = 1,
                CityName = "Calgary",
                Population = 1239220,
                ProvinceCode = "AB"
            },
            new City {  //2
                CityId = 2,
                CityName = "Edmonton",
                Population = 979587,
                ProvinceCode = "AB"
            },
            new City {  //3
                CityId = 3,
                CityName = "Red Deer",
                Population = 100418,
                ProvinceCode = "AB"
            },
            new City {  //4
                CityId = 4,
                CityName = "Vancouver",
                Population = 631486,
                ProvinceCode = "BC"
            },
            new City {  //5
                CityId = 5,
                CityName = "Victoria",
                Population = 367770,
                ProvinceCode = "BC"
            },
            new City {  //6
                CityId = 6,
                CityName = "Winnipeg",
                Population = 778489,
                ProvinceCode = "MB"
            },
            new City {  //7
                CityId = 7,
                CityName = "Brandon",
                Population = 45985,
                ProvinceCode = "MB"
            },
            new City {  //8
                CityId = 8,
                CityName = "Steinbach",
                Population = 13245,
                ProvinceCode = "MB"
            }
            };

        return cities;
    }
}


