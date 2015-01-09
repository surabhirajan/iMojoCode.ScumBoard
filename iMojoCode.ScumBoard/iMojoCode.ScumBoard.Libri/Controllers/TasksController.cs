using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using iMojoCode.ScumBoard.Libri.Models;

namespace iMojoCode.ScumBoard.Libri.Controllers
{
    public class TasksController : ApiController
    {
        Task[] tasks = new Task[] {
            new Models.Task { Id= 1, Description="Dev Analysis", Type="DEV", Effort=6, Burned=0},
            new Models.Task { Id= 2, Description="Coding", Type="DEV", Effort=12, Burned=0},
            new Models.Task { Id= 3, Description="Unit Testing", Type="DEV", Effort=6, Burned=0},
            new Models.Task { Id= 4, Description="QA Analysis", Type="QA", Effort=4, Burned=0},
            new Models.Task { Id= 5, Description="Testing", Type="QA", Effort=8, Burned=0},
            new Models.Task { Id= 5, Description="Requirements", Type="BA", Effort=4, Burned=0}
        };

        public IEnumerable<Task> GetTasks(string type)
        {
            var items = from t in tasks where t.Type.Equals(type) select t;
            return items;
        }

        public IEnumerable<Task> GetTasks()
        {
            return tasks;
        }
    }
}
