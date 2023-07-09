using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public override string? ToString()
        {
            return $"{nameof(Title)} : {Title}, {nameof(Author)} : {Author}, {nameof(Year)} : {Year}";
        }
    }
}
