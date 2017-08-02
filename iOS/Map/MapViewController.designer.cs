// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace timyao.iOS.Map
{
    [Register ("MapViewController")]
    partial class MapViewController
    {
        [Outlet]
        MapKit.MKMapView Mapview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Mapview != null) {
                Mapview.Dispose ();
                Mapview = null;
            }
        }
    }
}