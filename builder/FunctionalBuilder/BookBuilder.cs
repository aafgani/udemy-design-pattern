using domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FunctionalBuilder
{
    //public sealed class BookBuilder
    //{
    //    private readonly List<Func<Book, Book>> actions = new List<Func<Book, Book>>();

    //    public BookBuilder Do(Action<Book> action) => AddAction(action);
    //    private BookBuilder AddAction(Action<Book> action)
    //    {
    //        actions.Add(p =>
    //        {
    //            action(p);
    //            return p;
    //        });
    //        return this;
    //    }

    //    public BookBuilder Titled(string title) => Do(p => p.Title = title);

    //    public Book Build() => actions.Aggregate(new Book(), (b, f) => f(b));
    //}

    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<Book, Book>> actions = new List<Func<Book, Book>>();
        
        public TSelf Do(Action<Book> action) => AddAction(action);

        private TSelf AddAction(Action<Book> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return (TSelf) this;
        }
        public Book Build() => actions.Aggregate(new Book(), (b, f) => f(b));
    }

    public sealed class BookBuilder : FunctionalBuilder<Book, BookBuilder>
    {
        public BookBuilder Titled(string title) => Do(p => p.Title = title);
    }
}
