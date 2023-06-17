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

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            if (process)
                return;

            process = true;
            buttonBegin.Enabled = false;

            System.Threading.Tasks.Task.Run(() =>
           {
               CounterValue();
               System.Threading.Tasks.Task.Delay(2000).Wait();
               

               this.Invoke(new Action(() =>
               {
                   buttonBegin.Enabled = true;
                   process = false;
               }));
           });
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