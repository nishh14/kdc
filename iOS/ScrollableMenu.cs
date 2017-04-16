using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace KensingtonDryCleaners.iOS
{
	public class ScrollableMenu:UIScrollView
	{
		nfloat h = 50.0f;
		nfloat w = 50.0f;
		nfloat padding = 10.0f;
		nint n = 25;

		public ScrollableMenu(UIView View)
		{
			Frame = new CGRect(0, View.Frame.Top + 10, View.Frame.Width, h + 1 * padding);
			ContentSize = new CGSize((w + padding) * n, h);
			BackgroundColor = UIColor.Red;
			AutoresizingMask = UIViewAutoresizing.FlexibleWidth;


			List<UIButton> buttons = new List<UIButton>();


			for (int i = 0; i < n; i++)
			{
				var button = UIButton.FromType(UIButtonType.RoundedRect);
				button.SetTitle(i.ToString(), UIControlState.Normal);
				button.Frame = new CGRect(padding * (i + 1) + (i * w), padding, w, h);
				this.AddSubview(button);
				buttons.Add(button);
			}
		}


	}
}
