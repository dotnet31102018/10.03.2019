using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003HW
{
    class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"Book Title {Title} : Author : {Author}  Category : "+
                $"{ Category} Content: { Content} ";
        }

        /// <summary>
        /// Sort by author name
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Book other)
        {
            return Author.CompareTo(other.Author);
        }
    }
}
