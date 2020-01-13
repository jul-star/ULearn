using System;
using System.Collections.Generic;
using System.Text;

namespace Branching
{
    public class Queen
    {
        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            bool horizontal = (dx == 0) && (dy != 0);
            bool vertical = (dx != 0) && (dy == 0);
            bool diagonal = ((dx - dy) == 0) && (dx != 0) && (dy != 0);
            return (horizontal) || (vertical) || (diagonal);
        }
    }
}
