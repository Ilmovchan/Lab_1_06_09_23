namespace ProcessSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Process process = new Process(15328, 19378);

            MessageBox.Show(process.ToString());

            process.IncreaseWorkTime();

            MessageBox.Show(process.ToString());
        }
    }
}