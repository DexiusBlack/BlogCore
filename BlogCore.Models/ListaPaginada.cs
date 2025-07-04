﻿using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class ListaPaginada<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public string SearchString { get; set; }

        public ListaPaginada(List<T> items, int count, int pageIndex, int pageSize, string searchString)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count/(double)pageSize);
            SearchString = searchString;

            AddRange(items);
        }

        public bool HasPreviousPage => (PageIndex > 1);
        public bool HasNextPage => (PageIndex < TotalPages);
    }
}
