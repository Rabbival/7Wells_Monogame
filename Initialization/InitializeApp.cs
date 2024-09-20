
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Utils;


namespace MonoPlayground;

public static class InitializeApp
{
    public static void InitializeViewportToLogoSize(Scene titleScene, GraphicsDeviceManager graphics) {
        Texture2D logoSprite;
        Option<GameObject> maybeLogoObject = titleScene.GetGameObject(GameObjectType.Logo);
        if (!maybeLogoObject.HasValue) {
            Console.WriteLine("Error! Logo Object not found");
            return;
        }
        if (!maybeLogoObject.Value.texture.HasValue) {
            Console.WriteLine("Error! Logo Texture not found");
            return;
        }
        logoSprite = maybeLogoObject.Value.texture.Value;
        InitializeViewport(graphics, logoSprite.Width, logoSprite.Height);
    }

    public static void InitializeViewport(GraphicsDeviceManager graphics, int width, int height) {
        graphics.PreferredBackBufferWidth = width;
        graphics.PreferredBackBufferHeight = height;
        graphics.ApplyChanges();
    }
}
