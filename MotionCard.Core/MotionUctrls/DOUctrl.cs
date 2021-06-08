using MotionCard;
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

namespace MotionUctrls
{
    public partial class DOUctrl : UserControl
    {
        public DOUctrl()
        {
            InitializeComponent();
        }

        
        public DOUctrl(string doName)
        {
            InitializeComponent();
            DOName = doName;
        }

        private string _doName;
        public string DOName
        {
            get => _doName;
            set
            {
                _doName = value;
                if(_displayName == null)
                    lblDisplayName.Text = value;
            }
        }


        private string _displayName;
        public string DIsplayName
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

        public void UpdateUI()
        {
            bool? status = null;
            try
            {
                status = Motion.Instance.GetDOStatus(DOName);
            }
            catch
            {
                status = null;
            }
      
            this.Invoke(new Action(() =>
            {
                if (status == true)
                {
                    lampDO.LampColor = new Color[] { Color.Green };
                }
                else if(status == false)
                {
                    lampDO.LampColor = new Color[] { Color.DarkGray };
                }
                else
                {
                    lampDO.LampColor = new Color[] { Color.Yellow };
                }
            }));
        }

        private void lampDO_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = Motion.Instance.GetDOStatus(DOName);
                Motion.Instance.SetDOStatus(DOName, !status);
            }
            catch(Exception ex)
            {
                MessageBox.Show("操作失败！");
            }
        }
    }
}
