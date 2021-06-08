using MotionCard.Core.Definitions;
using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace MotionCard.Core
{
    class AxisBaseHelper : AxisBase
    {
        public override void AbsoluteMove(double targetPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            throw new NotImplementedException();
        }

        public override void CheckAxisArrived()
        {
            throw new NotImplementedException();
        }

        public override void CLearAlarm()
        {
            throw new NotImplementedException();
        }

        public override void Enable(bool enable)
        {
            throw new NotImplementedException();
        }

        public override double GetCurrentPosition()
        {
            throw new NotImplementedException();
        }

        public override StopReason GetStopReason()
        {
            throw new NotImplementedException();
        }

        public override Velocity GetVelocity()
        {
            throw new NotImplementedException();
        }

        public override bool HasHomed()
        {
            throw new NotImplementedException();
        }

        public override void Home()
        {
            throw new NotImplementedException();
        }

        public override bool IsAlarming()
        {
            throw new NotImplementedException();
        }

        public override bool IsEnabled()
        {
            throw new NotImplementedException();
        }

        public override bool IsMoving()
        {
            throw new NotImplementedException();
        }

        public override bool IsOnLmtN()
        {
            throw new NotImplementedException();
        }

        public override bool IsOnLmtP()
        {
            throw new NotImplementedException();
        }

        public override bool IsOnOrg()
        {
            throw new NotImplementedException();
        }

        public override bool IsReady()
        {
            throw new NotImplementedException();
        }

        public override void Jog(Velocity velocity)
        {
            throw new NotImplementedException();
        }

        public override void MoveToCalibrationPosition(string calibrationPositionName, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            throw new NotImplementedException();
        }

        public override void RelativeMove(double deltaPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            throw new NotImplementedException();
        }

        public override void SetVelocity(Velocity velocity)
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class AxisBase
    {
        protected AxisBase()
        {
            _directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MotionCardConfigFile");
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
        }

        private string _directory;
        public string AxisName { get; set; }
        protected int CardNo { get; set; }
        protected int AxisNo { get; set; }
        protected int PulseOutMode { get; set; }
        protected int PulsesPerUnit { get; set; }
        protected double PositionError { get; set; }
        public Velocity DebugVelocity { get; set; }
        public double MaxVelocity { get; set; }
        public CalibrationPosition[] CalibrationPositions { get; set; }

        public void Load(Encoding encoding)
        {
            AxisBase axisBase = JsonConvert.DeserializeObject<AxisBaseHelper>(File.ReadAllText(Path.Combine(_directory, AxisName, ".json"), encoding));
            this.AxisName = axisBase.AxisName;
            this.CardNo = axisBase.CardNo;
            this.AxisNo = axisBase.AxisNo;
            this.PulseOutMode = axisBase.PulseOutMode;
            this.PulsesPerUnit = axisBase.PulsesPerUnit;
            this.PositionError = axisBase.PositionError;
            this.DebugVelocity = axisBase.DebugVelocity;
            this.MaxVelocity = axisBase.MaxVelocity;
            this.CalibrationPositions = axisBase.CalibrationPositions;
        }


        public double GetCalibrationPositionValue(string calibrationPositionName)
        {
            foreach (var item in CalibrationPositions)
            {
                if(item.PositionName == calibrationPositionName)
                {
                    return item.PositionValue;
                }
            }
            throw new ArgumentException($"在轴{AxisName}上不存在标定点位{calibrationPositionName}!");
        }

        public void Save(Encoding encoding)
        {
            File.WriteAllText(Path.Combine(_directory, AxisName, ".json"), JsonConvert.SerializeObject(this, Formatting.Indented), encoding);
        }

        #region 轴信号
        public abstract bool HasHomed();

        public abstract bool IsAlarming();

        public abstract bool IsEnabled();

        public abstract bool IsMoving();

        public abstract bool IsOnLmtN();

        public abstract bool IsOnLmtP();

        public abstract bool IsOnOrg();

        public abstract bool IsReady();
        #endregion

        #region 轴运动
        public abstract void AbsoluteMove(double targetPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal);
        public abstract void Jog(Velocity velocity);
        public abstract void RelativeMove(double deltaPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal);
        public abstract void MoveToCalibrationPosition(string calibrationPositionName, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal);
        public abstract void CheckAxisArrived();
        public abstract void Home();
        public abstract void Stop();

        public void WaitAixsStopped(double timeoutSeconds = double.PositiveInfinity)
        {
            DateTime dateTime = DateTime.Now;
            while ((DateTime.Now - dateTime).TotalSeconds < timeoutSeconds)
            {
                if (!IsMoving())
                {
                    return;
                }
            }
            throw new TimeoutException();
        }
        public abstract void Enable(bool enable);

        public abstract double GetCurrentPosition();

        public abstract StopReason GetStopReason();
        #endregion

        public abstract void CLearAlarm();
        public abstract Velocity GetVelocity();
        public abstract void SetVelocity(Velocity velocity);
    }
}