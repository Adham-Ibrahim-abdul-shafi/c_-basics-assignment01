using System;
using System.Collections.Generic;
using System.Text;

namespace c__basics_Assignment01
{
    internal class Book
    {
        public string title = default!;
        public int pages;

        public override bool Equals(object? obj)
        {
            Book other = (Book)obj!;
            return other.title == title && other.pages == pages;
        }

        public override string ToString()
        {
            return $"Title : {title} , pages = {pages}";
        }
    }
}
