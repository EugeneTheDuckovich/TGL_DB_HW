

namespace src.db
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Puppy> Puppies { get; set; }
    }
}
