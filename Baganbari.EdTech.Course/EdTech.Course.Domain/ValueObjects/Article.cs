using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTech.Course.Domain.ValueObjects
{
    /// <summary>
    /// This will repeset any text based learning (e.g. books,published papaer, journals etc.)
    /// </summary>
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// This signify the content location of this article
        /// </summary>
        public string URL { get; set; }

    }
}
