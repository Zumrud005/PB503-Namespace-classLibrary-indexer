using ClassLibraryHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Namespace_list_indexer_Classlibrary.Models
{
    public class Book
    {
       
        private static int _count = 0;
      
        public int Id { get; }
        
        public string? Name { get; set; }
        public string? AuthorName { get; set; }

        public int PageCount { get; set; }

        public string? Code { get; set; }

        public Book(string name)
        {
            Id = ++_count;
            Name = name;
            Code = Helper.CreateBookCode(name,Id);
            
        }


        
        public void ShowBookInfo()
        {

            Console.WriteLine($"{Name}  {AuthorName}   {PageCount}    {Code}");

        }
    }
}
