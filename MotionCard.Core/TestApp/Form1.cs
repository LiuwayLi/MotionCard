using MotionCard.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CalibrationPositionReader.Instance.Load(@"C:\Users\Administrator\Desktop\MotionFinalVersion\MotionCard.Core\TestApp\MotionCardConfigFiles\AxisCalibrationPosition.json", Encoding.UTF8);
            double a = CalibrationPositionReader.Instance.GetCalibrationPositionValue("A", "Axis1");
            Console.WriteLine(a);






            //WorkLevelReader.Instance.Load(@"C:\Users\Administrator\Desktop\MotionFinalVersion\MotionCard.Core\TestApp\MotionCardConfigFiles\WorkLevel.json", Encoding.UTF8);
            //int level = WorkLevelReader.Instance.GetDIWorkLevel("A");
            //Console.WriteLine($"A:{level}");
            //level = WorkLevelReader.Instance.GetDIWorkLevel("B");
            //Console.WriteLine($"B:{level}");
            //level = WorkLevelReader.Instance.GetDIWorkLevel("C");
            //Console.WriteLine($"C:{level}");
            //level = WorkLevelReader.Instance.GetDIWorkLevel("D");
            //Console.WriteLine($"D:{level}");
            //level = WorkLevelReader.Instance.GetDOWorkLevel("A");
            //Console.WriteLine($"A:{level}");
            //level = WorkLevelReader.Instance.GetDOWorkLevel("B");
            //Console.WriteLine($"B:{level}");
            //level = WorkLevelReader.Instance.GetDOWorkLevel("C");
            //Console.WriteLine($"C:{level}");
            //level = WorkLevelReader.Instance.GetDOWorkLevel("D");
            //Console.WriteLine($"D:{level}");
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
