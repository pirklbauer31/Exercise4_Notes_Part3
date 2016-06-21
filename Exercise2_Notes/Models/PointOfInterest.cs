using Windows.Devices.Geolocation;

namespace Exercise2_Notes.Models
{
    public class PointOfInterest
    {
        public string Description { get; set; }

        public Geopoint Location { get; set; }

        public PointOfInterest(string description, Geopoint location)
        {
            Description = description;
            Location = location;
        }
    }
}