using System.Drawing;
using System.Windows.Forms;

namespace Chronometer
{
    internal class Digit
    {
        private Label top;
        private Label topStart;
        private Label topEnd;
        private Label center;
        private Label bottomStart;
        private Label bottomEnd;
        private Label bottom;
        public Color color {  get; set; }
        public Color background { get; set; }
        

        public Digit(Label top, Label topStart, Label topEnd, Label center, Label bottomStart, Label bottomEnd, Label bottom)
        {
            this.top = top;
            this.topStart = topStart;
            this.topEnd = topEnd;
            this.center = center;
            this.bottomStart = bottomStart;
            this.bottomEnd = bottomEnd;
            this.bottom = bottom;
            color = Color.Red;
            background = Color.Transparent;
        }

        public void paintDigit(int number)
        {
            switch (number)
            {
                case 0:
                    center.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topStart.BackColor = color;
                    topEnd.BackColor = color;
                    bottomStart.BackColor = color;
                    bottomEnd.BackColor = color;
                    bottom.BackColor = color;
                    break;
                case 1:
                    top.BackColor = background;
                    topStart.BackColor = background;
                    center.BackColor = background;
                    bottomStart.BackColor = background;
                    bottom.BackColor = background;
                    //Active
                    topEnd.BackColor = color;
                    bottomEnd.BackColor = color;
                    break;
                case 2:
                    topStart.BackColor = background; 
                    bottomEnd.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topEnd.BackColor = color;
                    center.BackColor = color;
                    bottomStart.BackColor = color;
                    bottom.BackColor = color;
                    break;
                case 3:
                    topStart.BackColor = background;
                    bottomStart.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topEnd.BackColor = color;
                    center.BackColor = color;
                    bottomEnd.BackColor = color;
                    bottom.BackColor = color;
                    break;
                case 4:
                    top.BackColor = background;
                    bottomStart.BackColor = background;
                    bottom.BackColor = background;
                    //Active
                    topEnd.BackColor = color;
                    topStart.BackColor = color;
                    center.BackColor = color;
                    bottomEnd.BackColor = color;
                    break;
                case 5:
                    topEnd.BackColor = background;
                    bottomStart.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topStart.BackColor = color;
                    center.BackColor = color; 
                    bottomEnd.BackColor = color;
                    bottom.BackColor = color;
                    break;
                case 6:
                    topEnd.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topStart.BackColor = color;
                    center.BackColor = color;
                    bottomStart.BackColor = color;
                    bottomEnd.BackColor = color;
                    bottom.BackColor = color;
                    break;
                case 7:
                    topStart.BackColor = background;
                    bottomStart.BackColor = background;
                    center.BackColor = background;
                    bottom.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topEnd.BackColor = color;
                    bottomEnd.BackColor = color;
                    break;
                case 8:
                    //Active
                    top.BackColor = color;
                    topStart.BackColor = color;
                    topEnd.BackColor = color;
                    center.BackColor = color;
                    bottomStart.BackColor = color;
                    bottomEnd.BackColor = color;
                    bottom.BackColor = color;
                    break;
                case 9:
                    bottomStart.BackColor = background;
                    //Active
                    top.BackColor = color;
                    topStart.BackColor = color;
                    topEnd.BackColor = color;
                    center.BackColor = color;
                    bottomEnd.BackColor = color;
                    bottom.BackColor = color;
                    break;


                default:
                    topStart.BackColor = background;
                    bottomEnd.BackColor = background;
                    top.BackColor = background;
                    topEnd.BackColor = background;
                    center.BackColor = background;
                    bottomStart.BackColor = background;
                    bottom.BackColor = background;
                    //Active
                    break;
            }
        }
    }
}
