

namespace src.db
{
    public class Puppy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Breed { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
