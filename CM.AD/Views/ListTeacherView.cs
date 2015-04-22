using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace CM.AD.Views
{
    [Activity(Label = "View for ListTeacherViewModel")]
    public class ListTeacherView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListTeacherView);
        }
    }
}