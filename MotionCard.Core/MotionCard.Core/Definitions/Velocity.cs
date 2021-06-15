using System;

namespace MotionCard.Core.Definitions
{
    /// <summary>
    /// 速度模型
    /// </summary>
    public struct Velocity : ICloneable
    {
        /// <summary>
        /// 起始速度
        /// </summary>
        public double Start { get; set; }

        /// <summary>
        /// 停止速度
        /// </summary>
        public double Stop { get; set; }

        /// <summary>
        /// 最大速度
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// S段时间
        /// </summary>
        public double TimeS { get; set; }

        /// <summary>
        /// 加速时长
        /// </summary>
        public double TimeAcc { get; set; }

        /// <summary>
        /// 减速时长
        /// </summary>
        public double TimeDec { get; set; }

        public object Clone()
        {
            return new Velocity()
            {
                Start = this.Start,
                Max = this.Max,
                Stop = this.Stop,
                TimeAcc = this.TimeAcc,
                TimeDec = this.TimeDec,
                TimeS = this.TimeS
            };
        }
    }
}