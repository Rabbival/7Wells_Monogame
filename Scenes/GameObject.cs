using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

public class GameObject {
    public string textureName;
    public Texture2D texture;
    public Vector2 location;

    public GameObject(string textureName, Vector2 location, ContentManager contentManager) {
        this.textureName = textureName;        
        texture = contentManager.Load<Texture2D>(textureName);
        this.location = location;
    }

    public void Draw(SpriteBatch spriteBatch) {
        spriteBatch.Draw(texture, location, Color.White);
    }
}