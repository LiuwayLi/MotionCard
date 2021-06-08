using MotionCard.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MotionUctrls
{
    public partial class DIUctrl : UserControl
    {
        public DIUctrl()
        {
            InitializeComponent();
        }

        public DIUctrl(string diName)
        {
            InitializeComponent();
            DIName = diName;
        }

        private string _displayName;

        public string DisplayName
        {
            get
            {
                return _displayName;
            }
            set
            {
                _displayName = value;
                lblDisplayName.Text = value;
            }
        }

        private string _diName;

        public string DIName
        {
            get
            {
                return _diName;
            }
            set
            {
                _diName = value;
                if (_displayName == null)
                    lblDisplayName.Text = value;
            }
        }

        public void UpdateUI()
        {
            bool? status = null;
            try
            {
                status = Motion.Instance.GetDIStatus(DIName);
            }
            catch
            {
                status = null;
            }

            this.Invoke(new Action(() =>
            {
                if (status == true)
                {
                    btnDI.LampColor = new Color[] { Color.Green };
                }
                else if (status == false)
                {
                    btnDI.LampColor = new Color[] { Color.DarkGray };
                }
                else
                {
                    btnDI.LampColor = new Color[] { Color.Yellow };
                }
            }));
        }
    }
}