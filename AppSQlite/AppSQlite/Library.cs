using SQLite;

namespace SQLiteApp
{
    [Table("Library")]
    public class Library
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Author { get; set; }
        public string BookName { get; set; }
        
    }
}