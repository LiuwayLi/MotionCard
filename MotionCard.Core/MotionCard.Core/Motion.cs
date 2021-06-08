using MotionCard.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace MotionCard.Core
{
    public class Motion
    {

        private Motion() { }
        public static Motion Instance { get; } = new Motion();

        private Dictionary<string, AxisBase> _axis = new Dictionary<string, AxisBase>();
        private Dictionary<string, DIBase> _dis = new Dictionary<string, DIBase>();
        private Dictionary<string, DOBase> _dos = new Dictionary<string, DOBase>();

        public Action<string, double> StartToFixedLengthMovement;
        public Action<string> StartToHome;
        public Action<string> StartToJog;
        public Action<string, bool> StartToSetDOStatus;
        public Action InitMotion;
        public Action DisposeMotion;

        public void LoadCommonConfigFile(Encoding encoding)
        {
            foreach (var item in _axis.Keys)
            {
                _axis[item].Load(encoding);
            }
        }

        public AxisBase GetAxis(string axisName)
        {
            return _axis[axisName];
        }

        public DIBase GetDI(string diName)
        {
            return _dis[diName];
        }

        public DOBase GetDO(string doName)
        {
            return _dos[doName];
        }

        public void InitializeMotion()
        {
            InitMotion.Invoke();
        }

        public void ReleaseMotion()
        {
            DisposeMotion.Invoke();
        }

        public void AddAxis(AxisBase axis)
        {
            _axis[axis.AxisName] = axis;
        }

        public void AddDI(DIBase di)
        {
            _dis[di.Name] = di;
        }

        public void AddDO(DOBase @do)
        {
            _dos[@do.Name] = @do;
        }




        #region Axis

        public void AbsoluteMove(string axisName, double targetPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            StartToFixedLengthMovement?.Invoke(axisName,targetPosition);
            _axis[axisName].AbsoluteMove(targetPosition, velocity, waitStopped, timeoutSeconds, expectedStopReason);
        }

        public void CheckAxisArrived(string axisName)
        {
            _axis[axisName].CheckAxisArrived();
        }

        public void CLearAlarm(string axisName)
        {

            _axis[axisName].CLearAlarm();
        }

        public void Enable(string axisName, bool enable)
        {

            _axis[axisName].Enable(enable);
        }

        public double GetCurrentPosition(string axisName)
        {

            return _axis[axisName].GetCurrentPosition();
        }

        public StopReason GetStopReason(string axisName)
        {

            return _axis[axisName].GetStopReason();
        }

        public Velocity GetVelocity(string axisName)
        {

            return _axis[axisName].GetVelocity();
        }

        public bool HasHomed(string axisName)
        {
            StartToHome?.Invoke(axisName);
            return _axis[axisName].HasHomed();
        }

        public void Home(string axisName)
        {
            _axis[axisName].Home();
        }

        public bool IsAlarming(string axisName)
        {
            return _axis[axisName].IsAlarming();
        }

        public bool IsEnabled(string axisName)
        {
            return _axis[axisName].IsEnabled();
        }

        public bool IsMoving(string axisName)
        {
            return _axis[axisName].IsMoving();
        }

        public bool IsOnLmtN(string axisName)
        {
            return _axis[axisName].IsOnLmtN();
        }

        public bool IsOnLmtP(string axisName)
        {
            return _axis[axisName].IsOnLmtP();
        }

        public bool IsOnOrg(string axisName)
        {
            return _axis[axisName].IsOnOrg();
        }

        public bool IsReady(string axisName)
        {
            return _axis[axisName].IsReady();
        }

        public void Jog(string axisName, Velocity velocity)
        {
            StartToJog?.Invoke(axisName);
            _axis[axisName].Jog(velocity);
        }

        public void MoveToCalibrationPosition(string axisName, string calibrationPositionName, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            double positionValue = _axis[axisName].GetCalibrationPositionValue(axisName);
            _axis[axisName].AbsoluteMove(positionValue, velocity, waitStopped, timeoutSeconds, expectedStopReason);
        }

        public void RelativeMove(string axisName, double targetPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            double currPosition = GetCurrentPosition(axisName);
            StartToFixedLengthMovement?.Invoke(axisName,targetPosition + currPosition);
            _axis[axisName].RelativeMove(targetPosition, velocity, waitStopped, timeoutSeconds, expectedStopReason);
        }

        public void SetVelocity(string axisName, Velocity velocity)
        {
            _axis[axisName].SetVelocity(velocity);
        }

        public void Stop(string axisName)
        {

            _axis[axisName].Stop();
        }

        public void WaitAixsStopped(string axisName, double timeoutSeconds = double.PositiveInfinity)
        {
            _axis[axisName].WaitAixsStopped(timeoutSeconds);
        }

        /// <summary>
        /// 多轴联动
        /// </summary>
        /// <param name="axes">轴列表</param>
        /// <param name="positions">轴目标位置列表，要与轴列表顺序一致</param>
        /// <param name="velocities">轴速度列表，要与轴列表顺序一致</param>
        public void MoveAxes(List<string> axes, List<double> positions, List<Velocity> velocities)
        {
            for (int i = 0; i < axes.Count; ++i)
            {

                _axis[axes[i]].AbsoluteMove(positions[i], velocities[i], false);
            }
        }

        /// <summary>
        /// 移动相关轴到标定位置
        /// </summary>
        /// <param name="axes">轴列表</param>
        /// <param name="calibrationPositionName">标定位置名称</param>
        public void MoveRelativeAxesToCalibrationPosition(List<string> axes, List<Velocity> velocities, string calibrationPositionName)
        {
            for (int i = 0; i < axes.Count; ++i)
            {
                MoveToCalibrationPosition(axes[i], calibrationPositionName, velocities[i]);
            }
        }

        #endregion Axis

        #region IO

        public void SetDOStatus(string doName, bool status)
        {
            StartToSetDOStatus?.Invoke(doName,status);
            _dos[doName].SetStatus(status);
        }

        public bool GetDOStatus(string doName)
        {
            return _dos[doName].GetStatus();
        }

        public bool GetDIStatus(string diName)
        {
            return _dis[diName].GetStatus();
        }

        #endregion IO

    }
}
