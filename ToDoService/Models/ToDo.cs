using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoService.Models
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool Completed { get; set; }
        public int Id { get; set; }
    }
}
