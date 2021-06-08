using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionUctrls
{
    public partial class CylinderUctrl : UserControl
    {
        public CylinderUctrl()
        {
            InitializeComponent();
        }

        public CylinderUctrl(string cylinderName)
        {
            InitializeComponent();
            CylinderName = cylinderName;
        }

        private string _cylinderName;
        public string CylinderName
        {
            get
            {
                return _cylinderName;
            }
            set
            {
                _cylinderName = value;
                btnSlider.BtnText = value;
            }
        }

        public void UpdateUI()
        {

        }
    }
}
