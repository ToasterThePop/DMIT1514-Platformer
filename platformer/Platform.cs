using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace platformer;

public class Platform
{
    private Texture2D _texture;
    private string _textureName;
    private Vector2 _position, _dimensions;
    private ColliderTop _colliderTop;
    private ColliderRight _colliderRight;
    private ColliderBottom _colliderBottom;
    private ColliderLeft _colliderLeft;

    internal Rectangle BoundingBox
    {
        get
        {
            return new Rectangle((int)_position.X, (int)_position.Y, (int)_dimensions.X, (int)_dimensions.Y);
        }
    }

    public Platform(Vector2 position, Vector2 dimensions, string textureName)
    {
        _textureName = textureName;
        _position = position;
        _dimensions = dimensions;

        _colliderTop = new ColliderTop(new Vector2(position.X + 3, position.Y), new Vector2(dimensions.X - 6, 1));
        _colliderRight = new ColliderRight(new Vector2(position.X + dimensions.X - 1, position.Y + 1), new Vector2(1, dimensions.Y - 2));
        _colliderBottom = new ColliderBottom(new Vector2(position.X + 3, position.Y + dimensions.Y), new Vector2(dimensions.X - 6, 1));
        _colliderLeft = new ColliderLeft(new Vector2(position.X + 1, position.Y + 1), new Vector2(1, dimensions.Y - 2));
    }
    internal void LoadContent(ContentManager content)
    {
        _texture = content.Load<Texture2D>(_textureName);
    }
    internal void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, BoundingBox, Color.White);
    }
    internal void ProcessCollisions(Player player, GameTime gameTime)
    {
        _colliderTop.ProcessCollision(player, gameTime);
        _colliderRight.ProcessCollision(player, gameTime);
        _colliderBottom.ProcessCollision(player, gameTime);
        _colliderLeft.ProcessCollision(player, gameTime);
    }
}