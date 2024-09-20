using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Utils;

public class Scene {
    private List<GameObject> initialObjectPlacements;
    private SceneTag tag;

    public Scene(SceneTag tag, ContentManager contentManager) {
        this.tag = tag;
        initialObjectPlacements = SceneObjectsInit.LoadGameObjectsForScene(tag, contentManager);
    }

    public SceneTag Tag() {
        return tag;
    }

    public List<GameObject> GetGameObjects() {
        return initialObjectPlacements;
    }

    public void DrawAllObjects(SpriteBatch spriteBatch) {
        foreach (GameObject gameObject in initialObjectPlacements) {
            gameObject.DrawIfHasTexture(spriteBatch);
        }
    }

    public Option<GameObject> GetGameObject(GameObjectType gameObjectType, int id) {
        return GetGameObject(gameObjectType, Option.Some(id));
    }

    public Option<GameObject> GetGameObject(GameObjectType gameObjectType) {
        return GetGameObject(gameObjectType, Option.None);
    }

    public Option<GameObject> GetGameObject(GameObjectType gameObjectType, Option<int> id) {
        foreach (GameObject gameObject in initialObjectPlacements) {
            if (gameObject.type == gameObjectType) {
                if (!id.HasValue || gameObject.id.Equals(id)) {
                    return Option.Some(gameObject);
                }
            }
        }
        return Option.None;
    }
}