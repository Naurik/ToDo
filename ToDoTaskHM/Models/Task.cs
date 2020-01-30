using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoTaskHM.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public bool? IsDone { get; set; }
    }
}