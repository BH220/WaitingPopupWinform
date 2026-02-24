using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_WaitingPopupWinform
{
    public class CustomBorderPanel : Panel
    {
        private int _borderThickness = 1;
        private Color _borderColor = Color.Black;

        public CustomBorderPanel()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            this.UpdateStyles();
        }

        [Category("Appearance")]
        [Description("테두리 두께")]
        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                if (value < 0) value = 0;
                _borderThickness = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("테두리 색상")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_borderThickness > 0)
            {
                using (Pen pen = new Pen(_borderColor, _borderThickness))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    Rectangle rect = this.ClientRectangle;
                    rect.Width -= 1;
                    rect.Height -= 1;

                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
