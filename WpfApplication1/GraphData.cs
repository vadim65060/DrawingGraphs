
namespace drawing_graphs
{
    public class GraphData
    {
        public double ConstA;
        public double ConstB;
        public double StartX;
        public double StartY;
        public int CountCalculatePoints;
        public GraphData()
        {
            ConstA = 1;
            ConstB = 1;
            StartX = 1;
            StartY = 1;
            CountCalculatePoints = 1000;
        }
        public GraphData(double x, double y, double a, double b, int countPoints)
        {
            ConstA = a;
            ConstB = b;
            StartX = x;
            StartY = y;
            CountCalculatePoints = countPoints;
        }
    }
}
