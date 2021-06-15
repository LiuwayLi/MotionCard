namespace MotionCard.Core
{
    /// <summary>
    /// 数字输入的抽象基类
    /// </summary>
    public abstract class DIBase
    {
        protected DIBase(string diName)
        {
            this.Name = diName;
        }

        /// <summary>
        /// 数字输入的名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 数字输入工作状态时的电平；0，低电平；1，高电平
        /// </summary>
        public int WorkLevel { get; set; }

        /// <summary>
        /// 数字输入的引脚地址
        /// </summary>
        public int Address { get; set; }

        /// <summary>
        /// 获取数字输入的电平；0，低电平；1，高电平
        /// </summary>
        /// <returns></returns>

        public abstract int GetLevel();

        /// <summary>
        /// 获取数字输入的状态
        /// </summary>
        /// <returns>true，工作状态；false，闲置状态</returns>
        public bool GetStatus()
        {
            return GetLevel() == WorkLevel;
        }
    }
}