using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHDTaskApp
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Task() { }
        public Task(string name, string description, bool isCompleted)
        {
            throw new NotImplementedException();
        }
    }
}
