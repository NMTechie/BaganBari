using EdTech.Course.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTech.Course.Domain.Entities
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Article> Articles { get; set; }
        public List<PractiseTest> PractiseTests { get; set; }
    }
}
