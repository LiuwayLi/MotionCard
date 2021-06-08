namespace MotionCard.Core
{
    public abstract class DOBase
    {
        protected DOBase()
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

        public abstract void SetLevel(int level);

        public void SetStatus(bool status)
        {
            SetLevel((status ? WorkLevel : 1 - WorkLevel));
        }
    }
}