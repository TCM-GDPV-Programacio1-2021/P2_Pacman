using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    /* // No tocar aquesta estructura
     * // exemples
     * Position p1 = new Position (1 ,2);
     * Position p2 = new Position (0, 0);
     * p2.row = 3;
     * p2.col = 4;
     * //Podem sumar o restar:
     * Position p3 = p1 + p2; //obtenim (4, 6)
     * */
    public struct Position
    {
        public int row;
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.row + p2.row, p1.col + p1.row);
        }
        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.row - p2.row, p1.col - p1.row);
        }
    }
}
