using CoreGraphics;
using FingerPaint;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace iOSPaintFinger
{
    public partial class DrawController : UIView
    {
        public List<Line> Lines = new List<Line>();

        public DrawController(IntPtr handle) : base(handle)
        {

        }
        public void Clear()
        {
            if (Lines.Count > 0)
            {
                Lines.Clear();
                SetNeedsDisplay();
            }
        }

        public void Undoline()
        {
            if (Lines.Count > 0)
            {
                Lines.Remove(Lines[Lines.Count - 1]);
                SetNeedsDisplay();
            }
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var context = UIGraphics.GetCurrentContext();

            foreach (Line line in Lines)
            {
                for (int i = 0; i < line.point.Count; i++)
                {
                    context.SetStrokeColor(line.color.CGColor);
                    context.SetLineWidth(line.strokeWidth);
                    context.SetLineCap(CGLineCap.Round);
                    if (i == 0)
                    {
                        context.MoveTo(line.point[i].X, line.point[i].Y);
                        context.AddLineToPoint(line.point[i].X, line.point[i].Y);
                    }
                    else
                        context.AddLineToPoint(line.point[i].X, line.point[i].Y);
                }
                context.StrokePath();
            }
        }
    }
}
