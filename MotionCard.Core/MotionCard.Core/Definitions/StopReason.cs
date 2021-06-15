using System.ComponentModel;

namespace MotionCard.Core.Definitions
{
    /// <summary>
    /// 轴的停止原因
    /// </summary>
    public enum StopReason
    {
        [Description("脉冲发送完毕正常停止")]
        Normal,

        [Description("指令停止")]
        Instruction,

        [Description("遇原点传感器停止")]
        TouchORGSensor,

        [Description("遇正限位传感器停止")]
        TouchPLPSensor,

        [Description("遇负限位传感器停止")]
        TouchNLPSensor,

        [Description("遇正软限位停止")]
        TouchSoftPLP,

        [Description("遇负软限位停止")]
        TouchSoftNLP,

        [Description("因急停停止")]
        Emergency,

        [Description("驱动器报警停止")]
        Alarm,

        [Description("未知原因")]
        Unknown
    }
}