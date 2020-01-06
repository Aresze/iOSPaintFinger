// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSPaintFinger
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider BrushColor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider BrushSize { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClearBT { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        iOSPaintFinger.DrawController DrawView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel infoBrushSize { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton undoBT { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BrushColor != null) {
                BrushColor.Dispose ();
                BrushColor = null;
            }

            if (BrushSize != null) {
                BrushSize.Dispose ();
                BrushSize = null;
            }

            if (ClearBT != null) {
                ClearBT.Dispose ();
                ClearBT = null;
            }

            if (DrawView != null) {
                DrawView.Dispose ();
                DrawView = null;
            }

            if (infoBrushSize != null) {
                infoBrushSize.Dispose ();
                infoBrushSize = null;
            }

            if (undoBT != null) {
                undoBT.Dispose ();
                undoBT = null;
            }
        }
    }
}