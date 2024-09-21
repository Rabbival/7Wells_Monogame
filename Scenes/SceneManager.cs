using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public static class SceneManager {
    private static SceneTag activeSceneTag;
    private static List<Scene> scenes = new List<Scene>();

    public static void SetActiveScene(SceneTag sceneTag) {
        activeSceneTag = sceneTag;
        CurrentInputConfig.SetActiveKeyboardSchemeIfAssigned(sceneTag);
    }

    public static SceneTag GetActiveScene() {
        return activeSceneTag;
    }

    public static void DrawActiveScene(SpriteBatch spriteBatch) {
        DrawScene(activeSceneTag, spriteBatch);
    }

    public static void DrawScene(SceneTag sceneTag, SpriteBatch spriteBatch){
        Option<Scene> maybeScene = GetSceneByTag(sceneTag);
        if (maybeScene.HasValue) {
            maybeScene.Value.DrawAllObjects(spriteBatch);
        }else{
            Console.WriteLine("Error! Couldn't find scene to draw");
        }
    }

    public static Option<Scene> GetSceneByTag(SceneTag tag) {
        foreach (Scene scene in scenes) {
            if (scene.Tag() == tag) {
                return Option.Some(scene);
            }
        }
        return Option.None;
    }

    public static void AddScenes(ContentManager contentManager) {
        foreach (SceneTag sceneTag in Enum.GetValues(typeof(SceneTag))) {
            scenes.Add(new Scene(sceneTag, contentManager));
        }
    }
}