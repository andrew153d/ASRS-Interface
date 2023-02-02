using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRS_Interface
{
    public class Part : IEquatable<Part>
    {
        public string BinID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Package { get; set; }
        public int Quantity{ get; set; }
        public string voltageRating { get; set; }
        public string powerRating { get; set; }
        public string Part_Number { get; set; }
        public string Supplier{ get; set; }
        public int Bin_X { get; set; }
        public int Bin_Y { get; set; }
        public int Bin_Z { get; set; }
        public int Bin_Width { get; set; }
        public int Bin_R { get; set; }



        public override string ToString()
        {
            return BinID.ToString() + ',' + Name + "," + Value.ToString() + "," + Package.ToString() + "," + Quantity.ToString() + "," + voltageRating.ToString() + ","
                + powerRating.ToString() + "," + Part_Number.ToString() + "," + Supplier.ToString() + "," + Bin_X.ToString() + "," + Bin_Y.ToString() + ","
                + Bin_Z.ToString() + "," + Bin_Width.ToString() + "," + Bin_R.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return int.Parse(BinID);
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.BinID.Equals(other.BinID));
        }
        public static bool operator ==(Part a, Part b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.BinID == b.BinID;
        }
        public static bool operator !=(Part a, Part b)
        {
            return !(a == b);
        }
    }
}
