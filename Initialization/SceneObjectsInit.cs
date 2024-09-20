using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Utils;

public static class SceneObjectsInit{

    public static List<GameObject> LoadGameObjectsForScene(SceneTag tag, ContentManager contentManager){
        switch (tag) {
            case SceneTag.TitleScreen:
                return new List<GameObject>([
                    new GameObject(
                        GameObjectType.Logo,
                        contentManager.Load<Texture2D>(FileNames.OurLogo),
                        new Vector2(0, 0)
                    )
                ]);
            default:
                return new List<GameObject>();
        }
    }
}