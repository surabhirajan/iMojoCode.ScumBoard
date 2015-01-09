using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMojoCode.ScumBoard.Libri.Models
{
    public class Sprint
    {
    }

    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Effort { get; set; }
        public int Burned { get; set; }
    }
    
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Points { get; set; }
    }
}