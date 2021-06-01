using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data
{
    public class Not : IComparable
    {
        public Not()
        {

        }
        public Not(string icerik)
        {
            Metin = icerik;
        }

        public string Metin { get; set; }
        public DateTime Zaman { get; set; } = DateTime.Now;
        public bool YildizliMi { get; set; } = false;

        public int CompareTo(object diger)
        {
            Not digerNot = (Not)diger;
            return -Zaman.CompareTo(digerNot.Zaman);
        }

        public override string ToString()
        {
            return (YildizliMi ? "★" : "") + " " + Metin + " " + (Zaman.ToShortTimeString());
        }
    }
}
