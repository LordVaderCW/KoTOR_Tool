using System;
using System.Drawing;
using System.Windows.Forms;
namespace ModelPreview {
        // Conversion has no reliable percentage; animate activity without inventing progress.
        public sealed class LoadingBar : Control
        {
            readonly Timer timer = new Timer { Interval = 30 };
            float phase;
            public LoadingBar()
            {
                DoubleBuffered = true;
                BackColor = Color.FromArgb(20,38,58);
                timer.Tick += (s,e) => { phase = (phase + 0.025f) % 1f; Invalidate(); };
            }
            protected override void OnVisibleChanged(EventArgs e)
            {
                base.OnVisibleChanged(e);
                timer.Enabled = Visible;
                if (Visible) phase = 0;
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                float width = Math.Max(40, ClientSize.Width * 0.3f);
                using (var brush = new SolidBrush(Color.FromArgb(45,153,255)))
                    e.Graphics.FillRectangle(brush, phase * (ClientSize.Width + width) - width, 0, width, ClientSize.Height);
            }
            protected override void Dispose(bool disposing)
            {
                if (disposing) timer.Dispose();
                base.Dispose(disposing);
            }
        }
}
