using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTech.Course.Domain.Entities
{
    public class PractiseTest
    {
        public Guid TestId { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
