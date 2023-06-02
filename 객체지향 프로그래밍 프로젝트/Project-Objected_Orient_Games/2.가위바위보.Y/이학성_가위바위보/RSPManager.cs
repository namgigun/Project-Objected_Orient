using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이학성_가위바위보
{
    public class RSPManager
    {
        public int points;

        public int Points(int value)
        {
            points = value;
            return points;
        }

        public void UpdatePoints(int newPoints)
        {
            points += newPoints;
        }
    }
}
