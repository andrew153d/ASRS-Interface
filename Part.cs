using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRS_Interface
{
    public class Part : IEquatable<Part>
    {
        public int BinID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Package { get; set; }
        public int Quantity{ get; set; }
        public int voltageRating { get; set; }
        public int powerRating { get; set; }
        public int Part_Number { get; set; }


        public int ID { get; set; }


        public override string ToString()
        {
            return Value.PadRight(10) + Name.PadRight(10) + Package.PadRight(10);
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
            return ID;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
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
            return a.ID == b.ID;
        }
        public static bool operator !=(Part a, Part b)
        {
            return !(a == b);
        }
    }
}
