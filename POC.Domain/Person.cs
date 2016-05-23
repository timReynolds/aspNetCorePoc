using POC.Application;

namespace POC.Domain
{
    public class Person : Entity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = Email;
        }

        public void Update(string email)
        {
            Email = email;
        }
    }
}
