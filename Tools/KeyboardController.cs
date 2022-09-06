/*
 Implementation of IController to use a keyboard
 */

using System.Collections.Generic;
using System.Data;
using Microsoft.Xna.Framework.Input;

public class KeyboardController : IController
{
    KeyboardState keyState;
    public void update()
    {
        this.keyState = Keyboard.GetState();
    }

}