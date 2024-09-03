using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double  Degree { get; set; }

        public double MinDegree { get; set; }

        public virtual ICollection<Instractor> Instractors { get; set; }

        public virtual ICollection<Courseresult> Courseresults { get; set; }


    }
}
