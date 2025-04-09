namespace NumberTheory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            Exercise1 lab2_BaiTap1 = new Exercise1();
            lab2_BaiTap1.ShowDialog();
        }

        private void btn_BaiTap2_Click(object sender, EventArgs e)
        {
            Exercise2 lab2_BaiTap2 = new Exercise2();
            lab2_BaiTap2.ShowDialog();
        }
        private void btn_BaiTap3_Click(object sender, EventArgs e)
        {
            Exercise3 lab2_BaiTap3 = new Exercise3();
            lab2_BaiTap3.ShowDialog();
        }
        //private void btn_BaiTap4_Click(object sender, EventArgs e)
        //{
        //    XOR lab1_BaiTap4 = new XOR();
        //    lab1_BaiTap4.ShowDialog();
        //}
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_BaiTap5_Click(object sender, EventArgs e)
        {
            //Lab2_BaiTap5 BaiTap5 = new Lab2_BaiTap5();
            //BaiTap5.ShowDialog();
        }

        //private void btn_BaiTap1_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
