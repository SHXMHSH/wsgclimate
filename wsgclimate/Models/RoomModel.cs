namespace wsgclimate.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatedPlaces { get; set; }
        public decimal SquareMeters { get; set; }
        public decimal MaxTemperature { get; set; }
        public decimal MaxHumidity { get; set; }


    }
}
