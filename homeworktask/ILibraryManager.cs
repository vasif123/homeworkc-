using homeworktask.Models2;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeworktask.Interfaces
{
    interface ILibraryManager
    {
        public List<Book> books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(Predicate<Book> predicate);
        List<Book> Filter(string genre);
    }
}
