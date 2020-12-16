using design_patterns.CreationalPattern.SimpleFactory.Interface;

namespace design_patterns.CreationalPattern.SimpleFactory
{
    public class DoorService : IDoor
    {
        private readonly float height;
        private readonly float width;

        public DoorService(float height, float width)
        {
            this.width = width;
            this.height = height;
        }

        public float GetHeight()
        {
            return height;
        }

        public float GetWidth()
        {
            return width;
        }
    }
}
