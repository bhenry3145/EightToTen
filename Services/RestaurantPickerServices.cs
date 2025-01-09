using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Services
{
    public class RestaurantPickerServices
    {
        public string response = "";
        public int randomNum;
        public Random rng = new Random();
        public bool runs;

        public string GetRestaurant(string category)
        {
            runs = (category.Contains("Mexican") || category.Contains("Chinese") || category.Contains("Fast Food"));
            if (runs == false)
            {
                response = "Please select from one of the categories: Mexican, Chinese, or Fast Food";
            }
            else
            {
                if (category.Contains("Mexican"))
                {
                    randomNum = rng.Next(1, 11);
                    switch (randomNum)
                    {
                        case 1:
                            response = "El Torito";
                            break;

                        case 2:
                            response = "Casa Flores";
                            break;

                        case 3:
                            response = "Adalberto's";
                            break;

                        case 4:
                            response = "Carolina's Grill and Taqueria";
                            break;

                        case 5:
                            response = "Octavio's";
                            break;

                        case 6:
                            response = "Arroyo's";
                            break;

                        case 7:
                            response = "Nena's";
                            break;

                        case 8:
                            response = "Las Palmas";
                            break;

                        case 9:
                            response = "Cancun";
                            break;

                        case 10:
                            response = "Alberto's Mexican Food";
                            break;

                        default:
                            response = "This restaurant is permanently closed so it's not listed.";
                            break;
                    }
                }
                else if (category.Contains("Chinese"))
                {
                    randomNum = rng.Next(1, 11);
                    switch (randomNum)
                    {
                        case 1:
                            response = "Mandarin Villa Express";
                            break;

                        case 2:
                            response = "Tsing Tao Restaurant";
                            break;

                        case 3:
                            response = "Dynasty Food Restaurant";
                            break;

                        case 4:
                            response = "Dave Wong's";
                            break;

                        case 5:
                            response = "Sherman's Chinese Buffet";
                            break;

                        case 6:
                            response = "China Village Restaurant";
                            break;

                        case 7:
                            response = "China Palace Restaurant";
                            break;

                        case 8:
                            response = "Beijing Buffet";
                            break;

                        case 9:
                            response = "Yen Du Restaurant";
                            break;

                        case 10:
                            response = "New Yen Ching Restaurant";
                            break;

                        default:
                            response = "This restaurant is permanently closed so it's not listed.";
                            break;
                    }
                }
                else if (category.Contains("Fast Food"))
                {
                    randomNum = rng.Next(1, 11);
                    switch (randomNum)
                    {
                        case 1:
                            response = "McDonald's";
                            break;

                        case 2:
                            response = "Burger King";
                            break;

                        case 3:
                            response = "In n Out Burger";
                            break;

                        case 4:
                            response = "Wendy's";
                            break;

                        case 5:
                            response = "Taco Bell";
                            break;

                        case 6:
                            response = "Chick-fil-a";
                            break;

                        case 7:
                            response = "Sonic";
                            break;

                        case 8:
                            response = "KFC";
                            break;

                        case 9:
                            response = "Popeyes";
                            break;

                        case 10:
                            response = "Del Taco";
                            break;

                        default:
                            response = "This restaurant is permanently closed so it's not listed.";
                            break;
                    }
                }
            }
            return response;
        }
    }
}