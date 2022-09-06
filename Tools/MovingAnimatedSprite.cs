/*
 *Implementation of ISprite for mobile animated sprites
 */
public class MovingAnimatedSprite : ISprite
{
    /*
     * Data for source of sprite information for each frame to animate
     */
    private struct sourceFrame1
    {
        public string file;
        public int topLeftCornerCoordinateX;
        public int topLeftCornerCoordinateY;
        public int width;
        public int height;
    }
    private struct sourceFrame2
    {
        public string file;
        public int topLeftCornerCoordinateX;
        public int topLeftCornerCoordinateY;
        public int width;
        public int height;
    }
    private struct sourceFrame3
    {
        public string file;
        public int topLeftCornerCoordinateX;
        public int topLeftCornerCoordinateY;
        public int width;
        public int height;
    }
    /*
     * Data for where to place sprite in window
     */
    private struct placement
    {
        int topLeftCornerCoordinateX;
        int topLeftCornerCoordinateY;
        int width;
        int height;
    }
    private placement windowPlacement {get; set;}
    private sourceFrame1 sourceFrame1Data { get; set; }
    private sourceFrame2 sourceFrame2Data { get; set; }
    private sourceFrame3 sourceFrame3Data { get; set; }

    public void loadContent()
    {
        throw new System.NotImplementedException();
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }
}