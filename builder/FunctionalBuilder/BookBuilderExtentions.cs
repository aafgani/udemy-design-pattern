using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FunctionalBuilder
{
    public static class BookBuilderExtentions
    {
        public static BookBuilder AuthoredBy(this BookBuilder builder, string author) => builder.Do(p => p.Author = author);

        public static BookBuilder ReleaseYear(this BookBuilder builder, int year) => builder.Do(p => p.Year = year);
    }
}
