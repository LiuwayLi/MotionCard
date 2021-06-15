using System;

namespace MotionCard.Core
{
    /// <summary>
    /// 数字输出的抽象基类
    /// </summary>
    public abstract class DOBase
    {
        /// <summary>
        /// 设置数字输出状态前，会触发该事件，一般用于气缸运动前的安全检查。
        /// string: 数字输出名称
        /// bool: 即将要设置的状态。true，工作状态；false，闲置状态
        /// </summary>
        public event Action<string, bool> StartToSetDOStatus;

        protected DOBase(string doName)
        {
            this.Name = doName;
        }

        /// <summary>
        /// 数字输出的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数字输出工作时的电平
        /// </summary>
        public int WorkLevel { get; set; }

        /// <summary>
        /// 数字输出的引脚地址
        /// </summary>
        public int Address { get; set; }

        /// <summary>
        /// 获取数字输出的电平；0 低电平；1 高电平
        /// </summary>
        /// <returns></returns>

        public abstract int GetLevel();

        /// <summary>
        /// 获取数字输出的状态
        /// </summary>
        /// <returns>true，工作状态；false，闲置状态</returns>
        public bool GetStatus()
        {
            return GetLevel() == WorkLevel;
        }

        /// <summary>
        /// 设置数字输出的电平
        /// </summary>
        /// <param name="level">0 低电平；1 高电平</param>
        public abstract void SetLevel(int level);

        /// <summary>
        /// 设置数字输出的状态
        /// </summary>
        /// <param name="status">true，工作状态；false，闲置状态</param>
        public void SetStatus(bool status)
        {
            StartToSetDOStatus(Name, status);
            SetLevel((status ? WorkLevel : 1 - WorkLevel));
        }
    }
}