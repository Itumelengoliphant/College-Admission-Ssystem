using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
   public class Book
    {
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string USBN_Number { get; set; }
        public DateTime DateOfBookUploaded { get; set; }
        public byte[] Picture { get; set; }
        public bool IsSold { get; set; }
        public string BookCondition { get; set; }
        public double Price { get; set; }
       


    }
}
