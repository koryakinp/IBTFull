using IBTFull.Models;

namespace IBTFull
{
    public static class AbuFactory
    {
        public static Abu Produce(int model)
        {
            if (model == 5)
            {
                return new Abu
                {
                    Model = 5,
                    DefaultPower = "27",
                    FanPower = "22",
                    Humidity = "2.0",
                    Air = "40.0",
                    Bio = "20-30",
                    Size = new Size(3800, 2200, 5400),
                    Load = 18,
                    PowerConsumption1 = "22",
                    PowerConsumption2 = "1.5",
                    PowerConsumption3 = "1.5",
                    Ventilator = "ВИР400-5-1-LG0-180М2-О-П-У1",
                    VentilatorEngine = 22,
                    VentilatorRPM = 2950,
                    ImageUrl = "/files/abu-5.jpg"
                };
            }
            else if (model == 10)
            {
                return new Abu
                {
                    Model = 10,
                    DefaultPower = "36",
                    FanPower = "30",
                    Humidity = "3.0",
                    Air = "60.0",
                    Bio = "30-40",
                    Size = new Size(5800, 2500, 5700),
                    Load = 25,
                    PowerConsumption1 = "30",
                    PowerConsumption2 = "2.2",
                    PowerConsumption3 = "2.2",
                    Ventilator = "ВИР400-5-1-LG0-180М2-О-П-У1",
                    VentilatorEngine = 30,
                    VentilatorRPM = 2950,
                    ImageUrl = "/files/abu-10.jpg"
                };
            }
            else if (model == 25)
            {
                return new Abu
                {
                    Model = 25,
                    DefaultPower = "61",
                    FanPower = "55",
                    Humidity = "4.0",
                    Air = "80.0",
                    Bio = "40-50",
                    Size = new Size(6500, 5500, 7900),
                    Load = 25,
                    PowerConsumption1 = "55",
                    PowerConsumption2 = "3.0",
                    PowerConsumption3 = "2.2",
                    Ventilator = "ВИР400-5-1-LG0-180М2-О-П-У1",
                    VentilatorEngine = 55,
                    VentilatorRPM = 1735,
                    ImageUrl = "/files/abu-25.jpg"
                };
            }
            else
            {
                return null;
            }
        }
    }
}