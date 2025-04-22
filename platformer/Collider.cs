using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace platformer;

public class Collider
{
    public Vector2 _position, _dimensions;
    public Texture2D _texture;
    internal Rectangle BoundingBox
    {
        get
        {
            return new Rectangle((int)_position.X, (int)_position.Y, (int)_dimensions.X, (int)_dimensions.Y);
        }
    }

    internal void LoadContent(ContentManager contentManager, string texturename) 
    {
        _texture = contentManager.Load<Texture2D>(texturename);
    }

    internal void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, BoundingBox, new Rectangle(0, 0, 1, 1), Color.White);
    }

    
}