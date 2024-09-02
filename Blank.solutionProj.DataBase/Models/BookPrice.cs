using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank.solutionProj.DataBase.Models
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int Amounnt { get; set; }

        public int BookId { get; set; }
        public int CurrencyId { get; set; }


        public Book Book { get; set; }
        public Currency Currency { get; set; }
        

    }
}
