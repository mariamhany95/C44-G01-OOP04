using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace demo.OverLoading
{
    internal class Complexx
    {
        #region Properties

        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real} + {Img}i ";
        }
        #endregion

        #region Operator OverLoading

        public static Complexx operator +(Complexx left, Complexx right)
        {
            return new Complexx()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img??0),
            };
        }


        public static Complexx operator -(Complexx left, Complexx right)
        {
            return new Complexx() 
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - ( right?.Img ?? 0)
            };



        }

            #endregion
        }
    }


