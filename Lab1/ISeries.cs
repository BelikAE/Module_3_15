using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        int starValue;
        int step;
        int currentValue;
        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = starValue;
        }

        public void SetStart(int x)
        {
            starValue = x;
            currentValue = starValue;
        }

        public void SetStep(int s)
        {
            step = s;
        }

    }
    class GeomProgression : ISeries
    {
        int starValue;
        int step;
        int currentValue;
        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = starValue;
        }

        public void SetStart(int x)
        {
            starValue = x;
            currentValue = starValue;
        }

        public void SetStep(int s)
        {
            step = s;
        }
    }
}
