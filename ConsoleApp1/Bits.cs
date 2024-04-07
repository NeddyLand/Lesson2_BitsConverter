using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsConverter
{
    class Bits
    {
        public byte Value { get; private set; } = 0;
        public Bits() { }
        public Bits(byte b) 
        {
            this.Value = b;
        }

        public bool this[int index]
        {
            get 
            {
                if (index > 7 || index < 0)
                    return false;
                return ((Value >> index) & 1) == 1;
            }
            set 
            {
                if (index > 7 || index < 0)
                    return;
                if (value == true)
                    Value = (byte)(Value | (1 << index));
                else
                {
                    var mask = (byte)(1 << index);
                    mask = (byte)(0xff ^ mask);
                    Value = (byte)(Value & mask);
                }
            }
        }

        public static implicit operator Bits(byte b) => new Bits(b);
        public static implicit operator Bits(long b) => new Bits((byte)b);
        public static implicit operator Bits(int b) => new Bits((byte)b);

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
