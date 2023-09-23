using System.Xml.Linq;

namespace ProcessSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Process process1 = new Process(15328, 19378);

            Resource resource = new Resource();

            /*            MessageBox.Show(process.ToString());

                        process.IncreaseWorkTime();

                        MessageBox.Show(process.ToString());*/
        }

    }
}