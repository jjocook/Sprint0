/*
 Implementation of ISprite for sprites that are completely static and do not move
 */

public class SationaryStaticSprite : ISprite
{
    public string sourceFile;
    public int sourceTopLeftCornerCoordinateX;
    public int sourceTopLeftCornerCoordinateY;
    public int sourceWidth;
    public int sourceHeight;
    public void initialize()
    {
        throw new System.NotImplementedException();
    }

    public void update()
    {
        throw new System.NotImplementedException();
    }
}