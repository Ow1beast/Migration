using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public virtual Team Team { get; set; }
    }
}
