using System;
using System.Threading.Tasks;



namespace Task
{
    public partial class Form1 : Form
    {
        private bool process;
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonBegin_Click(object sender, EventArgs e)
        {
            if (process)
                return;

            process = true;
            buttonBegin.Enabled = false;

            await System.Threading.Tasks.Task.Run(() =>
            {
                System.Threading.Tasks.Task.Delay(2000).Wait();
                CounterValue();
            });

            buttonBegin.Enabled = true;
            process = false;
        }

        private void CounterValue()
        {
            if (labelNumber.InvokeRequired)
            {
                labelNumber.Invoke(new Action(CounterValue));
            }
            else
            {
                int a = int.Parse(labelNumber.Text);
                a++;
                labelNumber.Text = a.ToString();
            }
        }
    }
}