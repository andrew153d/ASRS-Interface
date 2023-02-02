using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRS_Interface
{

    public class PartCollection : List<Part>
    {
        public PartCollection() { }
        private PartCollection(List<Part> inputList) {
            foreach (var part in inputList)
            {
                Add(part);
            }
        }
        public Part getPartByBinID(string BinID)
        {
           foreach(Part p in this)
            {
                if(p.BinID == BinID)
                {
                    return p;
                }
            }
           return null;
        }
        public void removePartByBinID(string BinID)
        {
            foreach (Part p in this)
            {
                if (p.BinID == BinID)
                {
                    this.Remove(p);
                    return;
                }
            }
        }
        public PartCollection searchFor(string searchTerm)
        {
            PartCollection outlist = new PartCollection();
            foreach(Part p in this)
            {
                if (p.ToString().ToLower().Contains(searchTerm.ToLower()))
                {
                    outlist.Add(p);
                }
            }
            return outlist;
        }
        public PartCollection sortByRetreive()
        {
            //List<Part> out = this.OrderByDescending(p => p.times_accessed).ToList();
            PartCollection retlist = new PartCollection(this.OrderByDescending(p => p.times_accessed).ToList());

            return retlist;
        }
        
    }
}
