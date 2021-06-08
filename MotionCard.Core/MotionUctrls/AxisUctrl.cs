using MotionCard.Core;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionUctrls
{
    public partial class AxisUctrl : UserControl
    {
        public AxisUctrl()
        {
            InitializeComponent();
        }

        public AxisUctrl(string axisName)
        {
            InitializeComponent();
            AxisName = axisName;
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
                if(value == null || value == string.Empty)
                {
                    txtDisplayName.Text = AxisName;
                }
                else
                {
                    txtDisplayName.Text = value;
                }
            }
        }

        private string _axisName;

        public string AxisName
        {
            get
            {
                return _axisName;
            }
            set
            {
                _axisName = value;
                if (_displayName == null || _displayName == string.Empty)
                    txtDisplayName.Text = value;
            }
        }

        public void UpdateUI()
        {
            double currPosition = Motion.Instance.GetCurrentPosition(AxisName);
            bool enable = Motion.Instance.IsEnabled(AxisName);
            bool org = Motion.Instance.IsOnOrg(AxisName);
            bool elp = Motion.Instance.IsOnLmtP(AxisName);
            bool eln = Motion.Instance.IsOnLmtN(AxisName);
            bool moving = Motion.Instance.IsMoving(AxisName);
            bool alm = Motion.Instance.IsAlarming(AxisName);
            bool homed = Motion.Instance.HasHomed(AxisName);
            this.Invoke(new Action(() =>
            {
                if (moving)
                {
                    btnHome.Enabled = false;
                    btnAbs.Enabled = false;
                    btnRel.Enabled = false;
                }
                else
                {
                    btnHome.Enabled = true;
                    btnAbs.Enabled = true;
                    btnRel.Enabled = true;
                }
            }));
        }

        private void btnHome_BtnClick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Motion.Instance.Home(this.AxisName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作失败！");
                }
            });
        }

        private void btnClrAlm_BtnClick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Motion.Instance.CLearAlarm(this.AxisName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作失败！");
                }
            });
        }
    }
}