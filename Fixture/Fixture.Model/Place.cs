using System;

namespace Fixture.Model
{
    public class Place
    {
        string placeName;
        string address;

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

            this.placeName = placeName;
            this.address   = address;
        }

        public string PlaceName
        {
            get { return placeName; }
            set { placeName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
