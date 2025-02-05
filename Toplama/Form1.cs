namespace Toplama
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sonuc = sayi1 + sayi2;
            lblSonuc.Text = Convert.ToString(sonuc);
        }
    }
}