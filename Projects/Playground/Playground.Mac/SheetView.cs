// This file has been autogenerated from a class added in the UI designer.

using System;
using MvvmCross.Platforms.Mac.Presenters.Attributes;
using MvvmCross.Platforms.Mac.Views;
using Playground.Core.ViewModels;

namespace Playground.Mac
{
    [MvxFromStoryboard("Main")]
    [MvxSheetPresentation]
    public partial class SheetView : MvxViewController<SheetViewModel>
    {
        public SheetView(IntPtr handle) : base(handle)
        {
            Title = "Sheet view";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = CreateBindingSet();
            set.Bind(btnClose).To(vm => vm.CloseCommand);
            set.Apply();
        }
    }
}
