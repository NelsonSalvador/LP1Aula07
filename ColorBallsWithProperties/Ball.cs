namespace ColorBallsWithProperties
{
    public class Ball
    {
        // Instance variables
        private Color color;
        private float radius;
        public int TimesThrown { get; set; }

        // Constructors
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            TimesThrown = 0;
        }

        // Operational methods
        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                TimesThrown++;
            }
        }

    }
}