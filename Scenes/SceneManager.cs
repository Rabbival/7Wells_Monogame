using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Utils;

public static class SceneManager {
    public static SceneTag activeSceneTag;
    private static List<Scene> scenes = new List<Scene>();

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

    public static void AddScene(Scene scene) {
        scenes.Add(scene);
    }
}