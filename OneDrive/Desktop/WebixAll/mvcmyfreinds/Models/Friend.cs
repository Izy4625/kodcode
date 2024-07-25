namespace mvcmyfreinds.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public int Age { get; set; }

        public Friend(int ID, string name, int age)
        {
            Id = ID;
            Name = name;
            Age = age;


        }
    }
}
