using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BH_WaitingPopupWinform
{
    public partial class WaitOverlayForm : Form
    {
        int width = 300;
        int height = 100;
        string title = "";
        string desc = "";
        private readonly Form _owner;
        WaitPopupForm waitPopupControl1;
        public WaitOverlayForm(Form owner, int width, int height, string title, string desc)
        {
            InitializeComponent();

            _owner = owner;

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;

            this.width = width;
            this.height = height;
            this.title = title;
            this.desc = desc;
            //BackColor = Color.Black;
            Opacity = 0.01;   // ✅ 진짜 반투명

            TopMost = false;

            SyncBounds();

            owner.LocationChanged += (_, __) => SyncBounds();
            owner.SizeChanged += (_, __) => SyncBounds();
        }

        private void SyncBounds()
        {
            if (_owner == null)
                return;

            // 🔥 부모의 Client 영역만 덮는다
            Rectangle clientRect = _owner.RectangleToScreen(_owner.ClientRectangle);
            Bounds = clientRect;
            CenterPopup();
        }
              
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            waitPopupControl1 = new WaitPopupForm();
            waitPopupControl1.Width = width;
            waitPopupControl1.Height = height;
            waitPopupControl1.lbTitle.Text = title;
            waitPopupControl1.lbDesc.Text = desc;
            waitPopupControl1.Show(this);
            // 🔥 레이아웃 완료 후 중앙 정렬
            this.BeginInvoke(new Action(() =>
            {
                CenterPopup();
            }));
        }

        private void CenterPopup()
        {
            if (waitPopupControl1 == null)
                return;

            // 팝업 크기 기준으로 중앙 좌표 계산
            int x = this.Location.X + ( (this.ClientSize.Width - waitPopupControl1.Width) / 2);
            int y = this.Location.Y + ( (this.ClientSize.Height - waitPopupControl1.Height) / 2);

            waitPopupControl1.Location = new Point(x, y);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Brush brush = new SolidBrush(Color.FromArgb(5, Color.Transparent)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // 🔥 내부 클릭 흡수
        protected override void OnMouseDown(MouseEventArgs e) { }
        protected override void OnMouseMove(MouseEventArgs e) { }
        protected override void OnMouseUp(MouseEventArgs e) { }

        public void SetCaption(string text)
        {
            if (waitPopupControl1 == null)
                return;
            waitPopupControl1.lbTitle.Text = text;
        }

        public void SetDescription(string text)
        {
            if (waitPopupControl1 == null)
                return;
            waitPopupControl1.lbDesc.Text = text;
        }

        internal void SetPopupSize(int width, int height)
        {
            if (waitPopupControl1 == null)
                return;
            waitPopupControl1.Width = width;
            waitPopupControl1.Height = height;  
        }
    }
}