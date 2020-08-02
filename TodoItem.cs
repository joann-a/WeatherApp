using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Blazor
{
    public class TodoItem
    {
        // create a class to store attributes for each Todo item, each item will have a title and whether it's completed
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
