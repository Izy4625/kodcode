namespace mvcmyfreinds.Models
{
    public class Dog
    {
        public int Tag { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Dog(int ID, string name, int age)
        {
            Tag = ID;
            Name = name;
            Age = age;
        }
    }
}
