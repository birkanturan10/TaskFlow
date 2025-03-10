using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tasks
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        public string? TaskName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Situation { get; set; }
    }
}
