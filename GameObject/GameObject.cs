using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Utils;

public partial class GameObject {
    public GameObjectType type;
    public Option<int> id;
    public Option<Texture2D> texture;
    public Vector2 location;

    public void DrawIfHasTexture(SpriteBatch spriteBatch) {
        if (texture.HasValue) {
            spriteBatch.Draw(texture.Value, location, Color.White);
        }
    }
}

//Constructors
public partial class GameObject {

    public GameObject(GameObjectType type, Vector2 location) :
        this(type, Option.None, Option.None, location) {}

    public GameObject(GameObjectType type, int id, Vector2 location) :
        this(type, Option.Some(id), Option.None, location) {}

    public GameObject(GameObjectType type, Texture2D texture, Vector2 location) :
        this(type, Option.None, Option.Some(texture), location) {}

    public GameObject(GameObjectType type, int id, Texture2D texture, Vector2 location) :
        this(type, Option.Some(id), Option.Some(texture), location) {}

    private GameObject(GameObjectType type, Option<int> id, Option<Texture2D> texture, Vector2 location) {
        this.type = type;
        this.id = id;
        this.texture = texture;
        this.location = location;
    }

}