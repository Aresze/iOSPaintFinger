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
        UIKit.UIButton ClearBT { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        iOSPaintFinger.DrawController DrawView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Green { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Medium { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Orange { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Red { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Thick { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Thin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton undoBT { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ClearBT != null) {
                ClearBT.Dispose ();
                ClearBT = null;
            }

            if (DrawView != null) {
                DrawView.Dispose ();
                DrawView = null;
            }

            if (Green != null) {
                Green.Dispose ();
                Green = null;
            }

            if (Medium != null) {
                Medium.Dispose ();
                Medium = null;
            }

            if (Orange != null) {
                Orange.Dispose ();
                Orange = null;
            }

            if (Red != null) {
                Red.Dispose ();
                Red = null;
            }

            if (Thick != null) {
                Thick.Dispose ();
                Thick = null;
            }

            if (Thin != null) {
                Thin.Dispose ();
                Thin = null;
            }

            if (undoBT != null) {
                undoBT.Dispose ();
                undoBT = null;
            }
        }
    }
}