using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Utils;

namespace MonoPlayground;

public class Game1 : Game
{
    public GraphicsDeviceManager graphicsManager;
    public SpriteBatch spriteBatch;

    public Game1()
    {
        graphicsManager = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        SceneManager.activeSceneTag = SceneTag.TitleScreen;
        base.Initialize();
    }

    protected override void LoadContent()
    {
        Option<Scene> maybeTitleScene;
        spriteBatch = new SpriteBatch(GraphicsDevice);
        SceneManager.AddScene(new Scene(SceneTag.TitleScreen, Content));
        maybeTitleScene = SceneManager.GetSceneByTag(SceneTag.TitleScreen);
        if (maybeTitleScene.HasValue) {
            InitializeApp.InitializeViewportToLogoSize(maybeTitleScene.Value, graphicsManager);
        }else{
            Console.WriteLine("Error! Title Scene not found");
        }
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        spriteBatch.Begin();
        SceneManager.DrawActiveScene(spriteBatch);
        spriteBatch.End();

        base.Draw(gameTime);
    }
}
