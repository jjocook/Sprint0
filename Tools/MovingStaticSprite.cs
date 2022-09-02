/*
 Implementation of ISprite for static sprites that move (maybe easier to understand as single frame sprites)
 */

public class MovingStaticSprite : ISprite
{
    string sourceFile;
    int sourceTopLeftCornerCoordinateX;
    int sourceTopLeftCornerCoordinateY;
    int sourceWidth;
    int sourceHeight;
    public void loadContent()
    {
        throw new System.NotImplementedException();
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }
}
