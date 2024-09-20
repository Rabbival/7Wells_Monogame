
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Utils;


namespace MonoPlayground;

public static class InitializeApp
{
    public static void InitializeViewportToLogoSize(Scene titleScene, GraphicsDeviceManager graphics) {
        Texture2D logoSprite;
        Option<GameObject> maybeLogoObject = titleScene.GetObjectByTextureName(FileNames.OurLogo);
        if (maybeLogoObject.HasValue) {
            logoSprite = maybeLogoObject.Value.texture;
            InitializeViewport(graphics, logoSprite.Bounds.Width, logoSprite.Bounds.Height);
        }else{
            Console.WriteLine("Error! Logo Object not found");
        }
    }

    public static void InitializeViewport(GraphicsDeviceManager graphics, int width, int height) {
        graphics.PreferredBackBufferWidth = width;
        graphics.PreferredBackBufferHeight = height;
        graphics.ApplyChanges();
    }
}
