using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Utils;

public class Scene {
    private List<GameObject> initialObjectPlacements;
    private SceneTag tag;

    public Scene(SceneTag tag, ContentManager contentManager) {
        this.tag = tag;
        initialObjectPlacements = SceneObjectsInit.GetGameObjectByScene(tag, contentManager);
    }

    public SceneTag Tag() {
        return tag;
    }

    public List<GameObject> GetGameObjects() {
        return initialObjectPlacements;
    }

    public void DrawAllObjects(SpriteBatch spriteBatch) {
        foreach (GameObject gameObject in initialObjectPlacements) {
            gameObject.Draw(spriteBatch);
        }
    }

    public Option<GameObject> GetObjectByTextureName(string textureName) {
        foreach (GameObject gameObject in initialObjectPlacements) {
            if (gameObject.textureName == textureName) {
                return Option.Some(gameObject);
            }
        }
        return Option.None;
    }
}