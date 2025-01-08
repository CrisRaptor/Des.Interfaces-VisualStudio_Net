using System.Collections.Generic;
using System.Drawing;

namespace Chronometer
{
    internal class Counter
    {
        private List<Digit> digits { get; set; }
        public int number;
        private int maxValue;
        private Color _color;
        private Color _backcolor;

        public Color color
        {
            get { 
                return _color; 
            }
            set { 
                _color = value;
                foreach (Digit digit in digits)
                {
                    digit.color = _color;
                }
                if (number != 0)
                {
                    paintDigits();
                } else
                {
                    paintDigitsReset();
                }
            }
        }
        public Color backcolor
        {
            get
            {
                return _backcolor;
            }
            set
            {
                _backcolor = value;
                foreach (Digit digit in digits)
                {
                    digit.background = _backcolor;
                }
                if (number != 0)
                {
                    paintDigits();
                }
                else
                {
                    paintDigitsReset();
                }
            }
        }


        public Counter(List<Digit> digits, int max, Color color, Color backcolor) {
            this.digits = digits;
            maxValue = max;
            this.color = color;
            this.backcolor = backcolor;
        }

        public int getMaxValue()
        {
            return maxValue;
        }


        public int increase()
        {
            if (number < maxValue)
            {
                number++;
                paintDigits();
            }
            else
            {
                number = 0;
                paintDigitsReset();
            }

            return number;
        }

        private void paintDigits()
        {
            int[] number = getIntArray(this.number);
            for (int i = 0; i < number.Length; i++) {
                digits[digits.Count-i-1].paintDigit(number[number.Length-i-1]);
            }
            for (int i = number.Length; i < digits.Count; i++)
            {
                digits[digits.Count - i - 1].paintDigit(0);
            }
        }

        private void paintDigitsReset()
        {
            foreach (Digit digit in digits)
            {
                digit.paintDigit(0);
            }
        }


        private int intPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }

        private int[] getIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
