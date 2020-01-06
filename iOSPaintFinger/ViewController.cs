using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace iOSPaintFinger
{
    public partial class ViewController : UIViewController
    {
        UIColor brushColor = UIColor.Red;

        int brushSize = 5;

        public ViewController (IntPtr handle) : base (handle)
        {
           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //undo, clear
            undoBT.TouchUpInside += (sender, e) =>
            {
                DrawView.Undoline();
            };
            ClearBT.TouchUpInside += (sender, e) =>
            {
                DrawView.Clear();
            };

            //set brush color
            Red.TouchUpInside += (sender, e) =>
            {
                brushColor = Red.BackgroundColor;
            };
            Green.TouchUpInside += (sender, e) =>
            {
                brushColor = Green.BackgroundColor;
            };
            Orange.TouchUpInside += (sender, e) =>
            {
                brushColor = Orange.BackgroundColor;
            };

            //set brush size
            Thick.TouchUpInside += (sender, e) =>
            {
                brushSize = 25;
            };
            Medium.TouchUpInside += (sender, e) =>
            {
                brushSize = 15;
            };
            Thin.TouchUpInside += (sender, e) =>
            {
                brushSize = 5;
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
                newline.strokeWidth = brushSize;
                newline.color = brushColor;

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
                DrawView.Lines[DrawView.Lines.Count - 1].strokeWidth = brushSize;
                DrawView.Lines[DrawView.Lines.Count - 1].color = brushColor;
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