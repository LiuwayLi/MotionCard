using MotionCard.Core;
using System;
using System.Windows.Forms;
using TestApp.VendorAxis;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motion.Instance.AddAxis(new LeadshineAxis("A"));
            Motion.Instance.AddAxis(new LeadshineAxis("B"));
            Motion.Instance.AddAxis(new LeadshineAxis("C"));
            Motion.Instance.AddAxis(new GoogoltechAxis("1"));
            Motion.Instance.AddAxis(new GoogoltechAxis("2"));
            Motion.Instance.AddAxis(new GoogoltechAxis("3"));

            Motion.Instance.LoadConfigFile();

            Motion.Instance.InitMotion = new Action(() => { });
            Motion.Instance.DisposeMotion = new Action(() => { });

            Console.WriteLine("------------------------------------------------------");
            AxisBase axisc = Motion.Instance.GetAxis("C");
            Console.WriteLine(axisc.GetType().Name);
            axisc = Motion.Instance.GetAxis("1");
            Console.WriteLine(axisc.GetType().Name);
            axisc = Motion.Instance.GetAxis("B");
            Console.WriteLine(axisc.GetType().Name);
            axisc = Motion.Instance.GetAxis("2");
            Console.WriteLine(axisc.GetType().Name);
            axisc = Motion.Instance.GetAxis("A");
            Console.WriteLine(axisc.GetType().Name);
            axisc = Motion.Instance.GetAxis("3");
            Console.WriteLine(axisc.GetType().Name);
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine($"axisc.MaxVelocity: {axisc.MaxVelocity}");

            Console.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WorkLevelReader.Instance.Save(@"C:\Users\Administrator\Desktop\123.json", Encoding.UTF8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}