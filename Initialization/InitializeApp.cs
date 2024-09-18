
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MonoPlayground;

public class InitializeApp
{
    public static void InitializeViewport(GraphicsDeviceManager graphics, int width, int height) {
        graphics.PreferredBackBufferWidth = width;
        graphics.PreferredBackBufferHeight = height;
        graphics.ApplyChanges();
    }
}
