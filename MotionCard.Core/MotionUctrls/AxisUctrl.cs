using MotionCard.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void AxisUctrl_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            else
            {
                barVel.MinValue = 0;
                barVel.MaxValue = (float)Motion.Instance.GetAxis(AxisName).MaxVelocity;
                barVel.Value = (float)Motion.Instance.GetAxis(AxisName).DebugVelocity.Max;

                cbxCalibPos.Source = new List<KeyValuePair<string, string>>();
                
            }
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
                if (value == null || value == string.Empty)
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
            double? currPosition = null;
            bool? enable = null;
            bool? org = null;
            bool? elp = null;
            bool? eln = null;
            bool? moving = null;
            bool? alm = null;
            bool? homed = null;

            try
            {
                currPosition = Motion.Instance.GetCurrentPosition(AxisName);
                enable = Motion.Instance.IsEnabled(AxisName);
                org = Motion.Instance.IsOnOrg(AxisName);
                elp = Motion.Instance.IsOnLmtP(AxisName);
                eln = Motion.Instance.IsOnLmtN(AxisName);
                moving = Motion.Instance.IsMoving(AxisName);
                alm = Motion.Instance.IsAlarming(AxisName);
                homed = Motion.Instance.HasHomed(AxisName);
            }
            catch(Exception ex)
            {
                currPosition = null;
                enable = null;
                org = null;
                elp = null;
                eln = null;
                moving = null;
                alm = null;
                homed = null;
            }

            this.Invoke(new Action(() =>
            {
                if(currPosition != null)
                {
                    txtCurrentPosition.Text = "未知";
                    txtCurrentPosition.BackColor = Color.Yellow;
                }
                else
                {
                    txtCurrentPosition.Text = ((double)currPosition).ToString("0.000");
                    txtCurrentPosition.BackColor = Color.Yellow;
                }


                if(enable == null)
                {
                    switchEnable.Checked = false;
                    switchEnable.FalseColor = Color.Yellow;
                }
                else
                {
                    switchEnable.Checked = (bool)enable;
                    switchEnable.FalseColor = Color.Black;
                }
                
                if(org == null)
                {
                    lampORG.LampColor = new Color[] { Color.Yellow };
                }
                else if(org == false)
                {
                    lampORG.LampColor = new Color[] { Color.Gray };
                }
                else
                {
                    lampORG.LampColor = new Color[] { Color.Lime };
                }

                if (elp == null)
                {
                    lampELP.LampColor = new Color[] { Color.Yellow };
                }
                else if (elp == false)
                {
                    lampELP.LampColor = new Color[] { Color.Gray };
                }
                else
                {
                    lampELP.LampColor = new Color[] { Color.Red };
                }

                if (eln == null)
                {
                    lampELN.LampColor = new Color[] { Color.Yellow };
                }
                else if (eln == false)
                {
                    lampELN.LampColor = new Color[] { Color.Gray };
                }
                else
                {
                    lampELN.LampColor = new Color[] { Color.Red };
                }

                if (alm == null)
                {
                    lampALM.LampColor = new Color[] { Color.Yellow };
                }
                else if (alm == false)
                {
                    lampALM.LampColor = new Color[] { Color.Gray };
                }
                else
                {
                    lampALM.LampColor = new Color[] { Color.Red };
                }

                if (moving == null)
                {
                    lampMoving.LampColor = new Color[] { Color.Yellow };
                }
                else if (moving == false)
                {
                    lampMoving.LampColor = new Color[] { Color.Gray };
                }
                else
                {
                    lampMoving.LampColor = new Color[] { Color.Lime };
                }


                if (homed == null)
                {
                    lampHomed.LampColor = new Color[] { Color.Yellow };
                }
                else if (homed == false)
                {
                    lampHomed.LampColor = new Color[] { Color.Lime };
                }
                else
                {
                    lampHomed.LampColor = new Color[] { Color.Red };
                }


                if (moving == true || moving == null)
                {
                    btnHome.Enabled = false;
                    btnAbs.Enabled = false;
                    btnRel.Enabled = false;
                    btnMoveto.Enabled = false;
                }
                else
                {
                    btnHome.Enabled = true;
                    btnAbs.Enabled = true;
                    btnRel.Enabled = true;
                    btnMoveto.Enabled = true;
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
                    MessageBox.Show(ex.Message,"操作失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }



        private void btnRel_BtnClick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Motion.Instance.RelativeMove(AxisName, (double)udTargetDistance.Value, Motion.Instance.GetAxis(AxisName).DebugVelocity);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private void btnAbs_BtnClick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Motion.Instance.AbsoluteMove(AxisName, (double)udTargetDistance.Value, Motion.Instance.GetAxis(AxisName).DebugVelocity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
    }
}