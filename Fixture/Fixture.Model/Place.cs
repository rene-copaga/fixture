using System;

namespace Fixture.Model
{
    public class Place
    {
        public Place(string placeName, string address)
        {
            if (placeName == null)
            {
                throw new ArgumentNullException("placeName");
            }

            if (address== null)
            {
                throw new ArgumentNullException("address");
            }

            PlaceName = placeName;
            Address   = address;
        }

        public int PlaceId { get; set; }

        public string PlaceName { get; set; }

        public string Address { get; set; }

        public Championship Championship { get; set; }
    }
}
