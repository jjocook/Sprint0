/*
 Implementation of ISprite for sprites that are completely static and do not move
 */

public class SationaryStaticSprite : ISprite
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