using design_patterns.CreationalPattern.SimpleFactory.Interface;

namespace design_patterns.CreationalPattern.SimpleFactory
{
    public class DoorFactory
    {
        public static IDoor MakeDoor(float height, float width)
        {
            return new DoorService(height, width);
        }
    }
}
