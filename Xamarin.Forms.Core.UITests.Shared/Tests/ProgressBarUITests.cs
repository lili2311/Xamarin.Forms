using NUnit.Framework;
using Xamarin.Forms.CustomAttributes;

namespace Xamarin.Forms.Core.UITests
{
	[TestFixture]
	[Category(UITestCategories.ProgressBar)]
	internal class ProgressBarUITests : _ViewUITests
	{
		public ProgressBarUITests()
		{
			PlatformViewType = Views.ProgressBar;
		}

		protected override void NavigateToGallery()
		{
			App.NavigateToGallery(GalleryQueries.ProgressBarGallery);
		}

		[UiTestExempt(ExemptReason.CannotTest, "Invalid interaction")]
		public override void _Focus()
		{
		}

		// TODO
		public override void _GestureRecognizers()
		{
		}

		[UiTestExempt(ExemptReason.CannotTest, "Invalid interaction")]
		public override void _IsFocused()
		{
		}

		[UiTestExempt(ExemptReason.CannotTest, "Invalid interaction")]
		public override void _UnFocus()
		{
		}

		// TODO
		// Implement control specific ui tests

		protected override void FixtureTeardown()
		{
			App.NavigateBack();
			base.FixtureTeardown();
		}

#if __ANDROID__ || __IOS__
		[Ignore("This is covered by the platform opacity tests")]
		public override void _Opacity() { }
#endif

#if __ANDROID__ || __IOS__
		[Ignore("This is covered by the platform tests")]
		public override void _IsEnabled() { }
#endif
	}
}