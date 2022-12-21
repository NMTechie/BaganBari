using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTech.Course.Domain.ValueObjects
{
    internal class Lecture
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// This signify the content location of this video material
        /// </summary>
        public string URL { get; set; }

    }
}
