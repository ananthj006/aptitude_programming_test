using System.Collections.Generic;
using System.Linq;

namespace Construction_Game
{
    public class Building
    {
        private readonly List<string> _house = new List<string>();

        public Building AddKitchen()
        {
            _house.Add("kitchen");
            return this;
        }

        public Building AddBedroom(string type)
        {
            _house.Add($"{type} room");
            return this;
        }

        public Building AddBalcony()
        {
            _house.Add("balcony");
            return this;
        }

        public Building Build()
        {
            return this;
        }

        public string Describe()
        {
            return _house.Aggregate((res, el) => $"{res},{el}");
        }
    }
}
