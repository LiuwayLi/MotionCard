using MotionCard.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotionCard.Core
{
    public class Motion
    {
        private Motion()
        {
        }

        public static Motion Instance { get; } = new Motion();

        private Dictionary<string, AxisBase> _axis = new Dictionary<string, AxisBase>();
        private Dictionary<string, DIBase> _dis = new Dictionary<string, DIBase>();
        private Dictionary<string, DOBase> _dos = new Dictionary<string, DOBase>();

        public Action InitMotion;
        public Action DisposeMotion;

        public void LoadConfigFile()
        {
            string[] axisNames = _axis.Keys.ToArray();

            foreach (var item in axisNames)
            {
                _axis[item] = _axis[item].Load();
            }
        }

        public void SaveConfigToFile(bool overwrite = true)
        {
            foreach (var item in _axis.Keys)
            {
                _axis[item].Save(overwrite);
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

        public void Initialize()
        {
            InitMotion?.Invoke();
        }

        public void Release()
        {
            DisposeMotion?.Invoke();
        }

        public void AddAxis(AxisBase axis)
        {
            _axis[axis.AxisName] = axis;
            SaveConfigToFile(false);
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

        public void MoveToCalibrationPosition(string axisName, string calibrationPositionName, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            double positionValue = _axis[axisName].GetCalibrationPositionValue(axisName);
            _axis[axisName].AbsoluteMove(positionValue, velocity, waitStopped, timeoutSeconds, expectedStopReason);
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
    }
}