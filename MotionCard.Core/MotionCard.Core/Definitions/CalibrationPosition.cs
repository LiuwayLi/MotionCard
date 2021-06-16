using System;

namespace MotionCard.Core.Definitions
{
    /// <summary>
    /// 标定点位
    /// </summary>
    public struct CalibrationPosition:ICloneable
    {
        /// <summary>
        /// 标定点位的名称
        /// </summary>
        public string PositionName { get; set; }
        /// <summary>
        /// 标定点位的坐标
        /// </summary>
        public double PositionValue { get; set; }
        /// <summary>
        /// 标定点位的描述信息（可选，非必要信息）
        /// </summary>
        public string Description { get; set; }

        public object Clone()
        {
            return new CalibrationPosition()
            {
                PositionName = this.PositionName,
                PositionValue = this.PositionValue,
                Description = this.Description
            };
        }
    }
}