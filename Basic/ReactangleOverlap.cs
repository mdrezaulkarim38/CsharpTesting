namespace Basic;

public class ReactangleOverlap{
    public struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public bool DoOverlap(Point l1, Point r1, Point l2, Point r2)
    {
        if(l1.x > r2.x || l2.x > r1.x)
        {
            return false;
        }

        if(r1.y > l2.y || r2.y > l1.y)
        {
            return false;
        }
        return true;
    }
}