namespace MotionCard.Core
{
    public abstract class DIBase
    {
        protected DIBase()
        {
        }

        public string Name { get; set; }
        public int WorkLevel { get; set; }
        public int Address { get; set; }

        public abstract int GetLevel();

        public bool GetStatus()
        {
            return GetLevel() == WorkLevel;
        }
    }
}