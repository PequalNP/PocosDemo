using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class Stock_Exchange
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Place_Id { get; set; }

        public virtual Place Place { get; set; }
        public virtual ICollection<Broker_Stock_Ex> Broker_Stock_Ex {get;set;}
    }
}
