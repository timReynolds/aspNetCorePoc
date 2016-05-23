using System.Collections.Generic;
using POC.Application;

namespace POC.Domain
{
    public class Team : Entity
    {
        public string Name { get;  }
        public Sport Sport { get;  }
        public List<Person> Members { get;  }

        public Team(string name, Sport sport)
        {
            Members = new List<Person>();
            Name = name;
            Sport = sport;
        }

        public void RegisterMember(Person person)
        {
            Members.Add(person);
        }

        public void RemoveMember(Person person)
        {
            Members.Remove(person);
        }
    }
}