using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace iOSPaintFinger
{
    public partial class ViewController : UIViewController
    {
        List<UIColor> uIColors = new List<UIColor>();
        int selectedColor = 0;
        public ViewController (IntPtr handle) : base (handle)
        {
           
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            uIColors.Add(UIColor.Black);
            uIColors.Add(UIColor.DarkGray);
            uIColors.Add(UIColor.LightGray);
            uIColors.Add(UIColor.White);
            uIColors.Add(UIColor.Blue);
            uIColors.Add(UIColor.Red);
            uIColors.Add(UIColor.Yellow);
            uIColors.Add(UIColor.Magenta);
            uIColors.Add(UIColor.Green);
            uIColors.Add(UIColor.Cyan);

            BrushColor.ThumbTintColor = uIColors[selectedColor];

            undoBT.TouchUpInside += (sender, e) =>
            {
                DrawView.Undoline();
            };
            ClearBT.TouchUpInside += (sender, e) =>
            {
                DrawView.Clear();
            };

            BrushColor.ValueChanged += (sender, e) =>
            {
                if (BrushColor.Value > 0)
                {
                    selectedColor = (int)Math.Ceiling(BrushColor.Value / BrushColor.MaxValue * uIColors.Count - 1);
                    BrushColor.ThumbTintColor = uIColors[selectedColor];
                }
            };
            BrushSize.TouchUpInside += (sender, e) =>
            {
                infoBrushSize.Hidden = true;
            };
            BrushSize.ValueChanged += (sender, e) =>
            {
                infoBrushSize.Text = ((int)BrushSize.Value).ToString();
                infoBrushSize.Hidden = false;
            };
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            foreach (UITouch touch in touches.Cast<UITouch>())
            {
                var point = touch.LocationInView(DrawView);
                var newline = new FingerPaint.Line();
                
                newline.point.Add(point);
                newline.strokeWidth = BrushSize.Value;
                newline.color = uIColors[selectedColor];

                DrawView.Lines.Add(newline);
            }
            DrawView.SetNeedsDisplay();
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            base.TouchesMoved(touches, evt);
            foreach (UITouch touch in touches.Cast<UITouch>())
            {
                var point = touch.LocationInView(DrawView);
                DrawView.Lines[DrawView.Lines.Count - 1].strokeWidth = BrushSize.Value;
                DrawView.Lines[DrawView.Lines.Count - 1].color = uIColors[selectedColor];
                DrawView.Lines[DrawView.Lines.Count - 1].point.Add(point);
            }
            DrawView.SetNeedsDisplay();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}