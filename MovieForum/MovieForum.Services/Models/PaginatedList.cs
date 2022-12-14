using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieForum.Web.Models
{
    public class PaginatedList<T> : List<T>
    {
        public PaginatedList(List<T> items, int totalPages, int pageNumber)
        {
            this.AddRange(items);
            this.TotalPages = totalPages;
            this.PageNumber = pageNumber;
        }

        public bool HasPreviousPage
        {
            get
            {
                return this.PageNumber > 1;
            }
        }

        public bool HasNextPage
        {
            get
            {
                return this.PageNumber < this.TotalPages;
            }
        }

        public int TotalPages { get; }
        public int PageNumber { get; }
    }
}
