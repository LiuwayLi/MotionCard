using MotionCard.Core.Definitions;
using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MotionCard.Core
{
    public abstract class AxisBase
    {
        protected AxisBase(string axisName)
        {
            this.AxisName = axisName;

            _directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MotionCardConfigFiles","Axis");

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
        public List<CalibrationPosition> CalibrationPositions { get; set; } = new List<CalibrationPosition>() {};


        public AxisBase Load()
        {
            return JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(_directory, $"{AxisName}.json"), Encoding.UTF8),GetType()) as AxisBase;
        }

        #region 标定位置
        public double GetCalibrationPositionValue(string calibrationPositionName)
        {
            foreach (var item in CalibrationPositions)
            {
                if (item.PositionName == calibrationPositionName)
                {
                    return item.PositionValue;
                }
            }
            throw new ArgumentException($"在轴{AxisName}上不存在标定点位{calibrationPositionName}!");
        }
        #endregion


        public void Save(bool overwrite = true)
        {
            string path = Path.Combine(_directory, $"{AxisName}.json");
            if (!overwrite)
            {
                if (File.Exists(path))
                {
                    return;
                }
            }

            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented), Encoding.UTF8);
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
        #region IO
        
        #endregion
    }
}