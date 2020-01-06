using CoreGraphics;
using System.Collections.Generic;
using UIKit;

namespace FingerPaint
{
    public class Line
    {
        public float strokeWidth;
        public UIColor color;
        public List<CGPoint> point;

        public Line()
        {
            strokeWidth = 5;
            color = UIColor.Blue;
            point = new List<CGPoint>();
        }

        public Line(float strokeWidth, UIColor color, List<CGPoint> point)
        {
            this.strokeWidth = strokeWidth;
            this.color = color;
            this.point = point;
        }
    }
}

