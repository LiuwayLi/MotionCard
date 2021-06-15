using MotionCard.Core.Definitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MotionCard.Core
{
    /// <summary>
    /// 轴的抽象基类
    /// </summary>
    public abstract class AxisBase
    {
        protected AxisBase(string axisName)
        {
            this.AxisName = axisName;

            _directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MotionCardConfigFile", "Axis");

            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
        }

        /// <summary>
        /// 定长运动前触发该事件
        /// </summary>
        public event Action<string, double> StartToFixedLengthMovement;

        /// <summary>
        /// 向标定位置移动前触发该事件
        /// </summary>
        public event Action<string, string> StartToMoveToCalibrationPosition;

        /// <summary>
        /// 回零前触发该事件
        /// </summary>
        public event Action<string> StartToHome;

        /// <summary>
        /// 连续运动前触发该事件
        /// </summary>
        public event Action<string> StartToJog;

        /// <summary>
        /// 存放轴对象序列化结果的目录
        /// </summary>
        private string _directory;

        /// <summary>
        /// 轴名称
        /// </summary>
        public string AxisName { get; }

        /// <summary>
        /// 控制卡卡号
        /// </summary>
        public int CardNo { get; set; }

        /// <summary>
        /// 轴号
        /// </summary>
        public int AxisNo { get; set; }

        /// <summary>
        /// 脉冲当量
        /// </summary>
        public int PulsesPerUnit { get; set; }

        /// <summary>
        /// 可接受的位置误差带(举例：假设误差带设置成1mm，现让轴运动到45mm处，轴停止后，检测到轴当前位置是44mm-46mm，但认为轴是准确到位的；如果是46.1mm或43.9，则认为未准确到位。)
        /// </summary>
        public double AcceptablePositionError { get; set; }

        /// <summary>
        /// 调试速度；在轴调试界面运动轴时，轴以此速度运动；该速度的值可以通过轴调试界面调节。
        /// </summary>
        public Velocity DebugVelocity { get; set; }

        /// <summary>
        /// 最大速度；在轴调试界面调试轴时，轴运动速度不得超过此值
        /// </summary>
        public double MaxVelocity { get; set; }

        /// <summary>
        /// 在轴上的标定点位的集合
        /// </summary>
        public List<CalibrationPosition> CalibrationPositions { get; set; } = new List<CalibrationPosition>() { };

        /// <summary>
        /// 序列化轴对象到磁盘文件
        /// </summary>
        /// <param name="overwrite">false，当磁盘已存在该轴的序列化文件，则不再进行序列化；true，则始终会序列化并覆盖已存在的序列化文件</param>
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

        /// <summary>
        /// 从磁盘文件读取轴信息并反序列化轴对象
        /// </summary>
        /// <returns></returns>
        public AxisBase Load()
        {
            return JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(_directory, $"{AxisName}.json"), Encoding.UTF8), GetType()) as AxisBase;
        }

        /// <summary>
        /// 获取轴上的所有的标定位置的名称
        /// </summary>
        /// <returns></returns>
        public List<string> GetCalibrationPositionNamesOnAxis()
        {
            List<string> calibrationNames = new List<string>();
            foreach (var item in CalibrationPositions)
            {
                calibrationNames.Add(item.PositionName);
            }
            return calibrationNames;
        }

        /// <summary>
        /// 获取轴上指定标定点位的位置
        /// </summary>
        /// <param name="calibrationPositionName"></param>
        /// <returns></returns>
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

        #region 轴信号

        /// <summary>
        /// 判断轴是否已经回原
        /// </summary>
        /// <returns>true，已经回原；false，未回原</returns>
        public abstract bool HasHomed();

        /// <summary>
        /// 判断轴是否处于报警状态
        /// </summary>
        /// <returns>true，正在报警；false，正常状态</returns>
        public abstract bool IsAlarming();

        /// <summary>
        /// 判断轴是否处于使能状态
        /// </summary>
        /// <returns></returns>
        public abstract bool IsEnabled();

        /// <summary>
        /// 判断轴是否处于运动状态
        /// </summary>
        /// <returns>true，正在运动；false，停止状态</returns>
        public abstract bool IsMoving();

        /// <summary>
        /// 判断轴是否在负硬限位
        /// </summary>
        /// <returns>true，是；false，否</returns>

        public abstract bool IsOnLmtN();

        /// <summary>
        /// 判断轴是否在正硬限位
        /// </summary>
        /// <returns>true，是；false，否</returns>

        public abstract bool IsOnLmtP();

        /// <summary>
        /// 判断轴是否在原点
        /// </summary>
        /// <returns>true，是；false，否</returns>

        public abstract bool IsOnOrg();

        #endregion 轴信号

        #region 轴运动

        /// <summary>
        /// 绝对运动
        /// </summary>
        /// <param name="targetPosition">目标位置;(举例：+30mm表示正方向30mm；-30mm表示负方向30mm)</param>
        /// <param name="velocity">速度</param>
        /// <param name="waitStopped">方法是否等待轴绝对运动完毕再返回</param>
        /// <param name="timeoutSeconds">等待轴运动结束的时长，超过此时长轴还未停止的话，会抛出超时异常。该参数只有waitStopped = true时才有意义</param>
        /// <param name="expectedStopReason">轴绝对运动结束后，会检查轴停止的原因，若真正停止的原因与期望的停止原因不同，则抛出异常</param>
        public abstract void AbsoluteMove(double targetPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal);

        /// <summary>
        /// 定速运动
        /// </summary>
        /// <param name="velocity">做定速运动的速度</param>
        public abstract void Jog(Velocity velocity);

        /// <summary>
        /// 相对运动
        /// </summary>
        /// <param name="deltaPosition">运动距离（举例：-30,表示从当前位置向负方向移动30mm；+30,表示从当前位置向正方向移动30mm）</param>
        /// <param name="velocity">速度</param>
        /// <param name="waitStopped">方法是否等待轴绝对运动完毕再返回</param>
        /// <param name="timeoutSeconds">等待轴运动结束的时长，超过此时长轴还未停止的话，会抛出超时异常。该参数只有waitStopped = true时才有意义</param>
        /// <param name="expectedStopReason">轴绝对运动结束后，会检查轴停止的原因，若真正停止的原因与期望的停止原因不同，则抛出异常</param>
        public abstract void RelativeMove(double deltaPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal);

        /// <summary>
        /// 移动到标定点位
        /// </summary>
        /// <param name="calibrationPositionName">目标标定点位的名称</param>
        /// <param name="velocity">速度</param>
        /// <param name="waitStopped">方法是否等待轴绝对运动完毕再返回</param>
        /// <param name="timeoutSeconds">等待轴运动结束的时长，超过此时长轴还未停止的话，会抛出超时异常。该参数只有waitStopped = true时才有意义</param>
        /// <param name="expectedStopReason">轴绝对运动结束后，会检查轴停止的原因，若真正停止的原因与期望的停止原因不同，则抛出异常</param>
        public abstract void MoveToCalibrationPosition(string calibrationPositionName, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal);

        /// <summary>
        /// 检查轴是否已经准确到位
        /// </summary>
        public abstract void CheckAxisArrived(double targetPosition);

        /// <summary>
        /// 回原
        /// </summary>
        public abstract void Home();

        /// <summary>
        /// 指令停止
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// 等待轴停止
        /// </summary>
        /// <param name="timeoutSeconds"></param>
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

        /// <summary>
        /// Servo On/Off
        /// </summary>
        /// <param name="enable">true,On; false,Off</param>
        public abstract void Enable(bool enable);

        /// <summary>
        /// 获取轴的当前位置
        /// </summary>
        /// <returns></returns>
        public abstract double GetCurrentPosition();

        /// <summary>
        /// 获取轴停止原因
        /// </summary>
        /// <returns></returns>
        public abstract StopReason GetStopReason();

        #endregion 轴运动

        /// <summary>
        /// 清除轴报警
        /// </summary>
        public abstract void CLearAlarm();

        /// <summary>
        /// 读取轴的速度
        /// </summary>
        /// <returns></returns>
        public abstract Velocity GetVelocity();

        /// <summary>
        /// 设置轴的速度
        /// </summary>
        /// <param name="velocity"></param>
        public abstract void SetVelocity(Velocity velocity);
    }
}