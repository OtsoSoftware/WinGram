using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGram.Controls
{
	/// <summary>
	/// Goofy but working custom flowlayoutpanel
	/// </summary>
	public class SmoothFlowPanel : FlowLayoutPanel
	{
		private Timer scrollTimer = new();
		private int targetScrollY;
		private const int SCROLL_STEP = 9;
		private const int SCROLL_SPEED = 3;

		public SmoothFlowPanel()
		{
			this.DoubleBuffered = true;
			this.AutoScroll = true;
			scrollTimer.Interval = SCROLL_SPEED;
			scrollTimer.Tick += ScrollTimer_Tick;
		}

		// override to suppress the base scroll behavior
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			// don't uncomment:
			// base.OnMouseWheel(e);

			int currentScroll = -AutoScrollPosition.Y;
			int scrollDelta = -e.Delta;

			targetScrollY = currentScroll + scrollDelta;

			int maxScroll = VerticalScroll.Maximum - ClientSize.Height;
			targetScrollY = Math.Max(0, Math.Min(maxScroll, targetScrollY));

			scrollTimer.Start();
		}

		private void ScrollTimer_Tick(object sender, EventArgs e)
		{
			int currentScroll = -AutoScrollPosition.Y;
			int delta = targetScrollY - currentScroll;

			if (Math.Abs(delta) <= SCROLL_STEP)
			{
				SetScrollPosition(targetScrollY);
				scrollTimer.Stop();
			}
			else
			{
				SetScrollPosition(currentScroll + Math.Sign(delta) * SCROLL_STEP);
			}
		}

		public void ScrollToBottom()
		{
			if (this.Controls.Count == 0)
				return;

			var lastControl = this.Controls[this.Controls.Count - 1];
			this.ScrollControlIntoView(lastControl);
		}

		private void SetScrollPosition(int y)
		{
			AutoScrollPosition = new Point(0, y);
		}
	}
}
