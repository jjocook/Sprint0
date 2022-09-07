/*
 *Implementation of ISprite for mobile animated sprites
 */
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Reflection;

public class MovingAnimatedSprite : ISprite
{
    /*
     * Data for source of sprite information for each frame to animate
     */
    public string sourceFileDirectory;
    public int sourceX1;
    public int sourceY1;
    public int sourceWidth1;
    public int sourceHeight1;

    public int sourceX2;
    public int sourceY2;
    public int sourceWidth2;
    public int sourceHeight2;

    public int sourceX3;
    public int sourceY3;
    public int sourceWidth3;
    public int sourceHeight3;

    /*
     * Data for where to place sprite in window
     */


    public int positionX;
    public int positionY;
    public int width;
    public int height;


   

    /*
     Frame Counter
     */
    private int currentFrame = 0;


    public void initialize()
    {
        sourceFileDirectory="";
        sourceX1=0;
        sourceY1 = 0;
        sourceWidth1 = 0;
        sourceHeight1 = 0;

        sourceX2 = 0;
        sourceY2 = 0;
        sourceWidth2 = 0;
        sourceHeight2 = 0;

        sourceX3 = 0;
        sourceY3 = 0;
        sourceWidth3 = 0;
        sourceHeight3 = 0;

        /*
         * Data for where to place sprite in window
         */


        positionX = 0;
        positionY = 0;
        width = 0;
        height = 0;
    }

    public void update()
    {
        currentFrame = (currentFrame + 1) % 3;
        
    }

    public Rectangle getPositionRectangle()
    {
        return new Rectangle(positionX, positionY+currentFrame, width, height);
    }

    public Rectangle getSourceRectangle()
    {
        switch (currentFrame)
        {
            case 0: return new Rectangle(sourceX1, sourceY1, sourceWidth1, sourceHeight1);
                
            case 1: return new Rectangle(sourceX2, sourceY2, sourceWidth2, sourceHeight2);
                
            case 2: return new Rectangle(sourceX3, sourceY3, sourceWidth3, sourceHeight3);

            default: return new Rectangle(0, 0, 0, 0);

        }
    }

    public void setPositionRectangle(int x, int y, int w, int h)
    {
        positionX = x;
        positionY = y;
        width = w;
        height = h;
    }

    public void setFrame1Rectangle(int x, int y, int w, int h)
    {
        sourceX1 = x;
        sourceY1 = y;
        sourceWidth1 = w;
        sourceHeight1 = h;
    }
    public void setFrame2Rectangle(int x, int y, int w, int h)
    {
        sourceX2 = x;
        sourceY2 = y;
        sourceWidth2 = w;
        sourceHeight2 = h;
    }
    public void setFrame3Rectangle(int x, int y, int w, int h)
    {
        sourceX3 = x;
        sourceY3 = y;
        sourceWidth3 = w;
        sourceHeight3 = h;
    }

}