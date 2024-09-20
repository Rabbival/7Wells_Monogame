using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

public static class SceneObjectsInit{

    public static List<GameObject> GetGameObjectByScene(SceneTag tag, ContentManager contentManager){
        switch (tag) {
            case SceneTag.TitleScreen:
                return new List<GameObject>([
                    new GameObject(FileNames.OurLogo, new Vector2(0, 0), contentManager)
                ]);
            default:
                return new List<GameObject>();
        }
    }
}