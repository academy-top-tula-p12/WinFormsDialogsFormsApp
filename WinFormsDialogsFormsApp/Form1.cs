namespace WinFormsDialogsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            var result = MessageBox.Show(
                "Text on back window",
                "Text caption",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.ServiceNotification);
            lblResult.Text = result.ToString();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = openFileDialog.FileName;
            var image = new Bitmap(fileName);
            pictBoxLoad.Image = image;
        }
    }
}
