namespace BH_WaitingPopupWinform.Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            string title = "Please Wait";
            string desc = "Loading..";
            if(string.IsNullOrEmpty(txtTitle.Text) == false)
            {
                title = txtTitle.Text;
            }
            if(string.IsNullOrEmpty(txtDesc.Text) == false)
            {
                desc = txtDesc.Text;
            }
            WaitingPopupManager.ShowForm(this, (int)width.Value, (int)height.Value, title, desc);
            await Task.Delay(2000);
            WaitingPopupManager.SetCaption("제목바꾸고");
            WaitingPopupManager.SetDescription("설명도바꿔서");
            await Task.Delay(2000);
            WaitingPopupManager.CloseForm();
        }
    }
}
