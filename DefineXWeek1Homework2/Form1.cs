namespace DefineXWeek1Homework2
{
    public partial class Form1 : Form
    {
        public string PayType = "";
        public string message = "";
        public ILogger iLogger;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Type selectedtype = Type.GetType("DefineXWeek1Homework2." + PayType.Replace(" ", ""));

            //if (selectedtype != null)
            //{
            //    ILogger logger = (ILogger)Activator.CreateInstance(selectedtype); 
            //    message = logger.Pay(textBox1.Text);
            //    lblSonuc.Text = message;
            //}

            //log factory kullanarak çözüm
            PayTypeFactory logFactory = new PayTypeFactory();
            iLogger = logFactory.GetInstance(PayType);
            
            lblSonuc.Text = iLogger.Pay(textBox1.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PayType = comboBox1.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
