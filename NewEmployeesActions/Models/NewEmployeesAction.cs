using System;
using SQLite;

namespace NewEmployeesActions.Models
{
    public class NewEmployeesAction
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
