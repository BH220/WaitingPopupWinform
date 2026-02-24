using System;
using System.Windows.Forms;

namespace BH_WaitingPopupWinform
{
    public static class WaitingPopupManager
    {
        private static WaitOverlayForm _overlay;

        public static void ShowForm(Form owner, string title="Please Wait", string desc="Loading..")
        {
            int width = 310, height = 90;
            if (owner.InvokeRequired)
            {
                owner.Invoke(new Action(() => ShowForm(owner, width, height, title, desc)));
                return;
            }

            if (_overlay != null)
                return;

            _overlay = new WaitOverlayForm(owner, width, height, title, desc);
            _overlay.Show(owner);
        }

        public static void ShowForm(Form owner, int width, int height, string title = "Please Wait", string desc = "Loading..")
        {
            if (owner.InvokeRequired)
            {
                owner.Invoke(new Action(() => ShowForm(owner, width, height, title, desc)));
                return;
            }

            if (_overlay != null)
                return;

            _overlay = new WaitOverlayForm(owner, width, height, title, desc);
            _overlay.Show(owner);

        }

        public static void CloseForm()
        {
            if (_overlay == null)
                return;

            _overlay.Close();
            _overlay.Dispose();
            _overlay = null;
        }

        public static void SetCaption(string text)
        {
            if (_overlay == null)
                return;
            _overlay?.SetCaption(text);
        }

        public static void SetDescription(string text)
        {
            if (_overlay == null)
                return;
            _overlay?.SetDescription(text);
        }
    }
}