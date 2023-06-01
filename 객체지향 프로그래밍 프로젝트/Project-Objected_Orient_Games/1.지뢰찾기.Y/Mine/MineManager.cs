using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    public class MineManager
    {
        public int highScore;
        public int points;

        public int Points(int value) {
            points = value;
            return points;
        }

        public void UpdatePoints(int newPoints) {
            points += newPoints;
        }
    }
}
