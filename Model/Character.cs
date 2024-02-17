using SQLite;
using SQLiteNetExtensions.Attributes;

namespace anime.Model
{
    public class Character
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        [OneToMany]
        public List<ListCharacter> ListCharacters { get; set; }
    }
}
