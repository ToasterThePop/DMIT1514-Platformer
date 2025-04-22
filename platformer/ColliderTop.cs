using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace platformer;

public class ColliderTop : Collider
{
    public ColliderTop(Vector2 position, Vector2 dimensions)
    {
        _position = position;
        _dimensions = dimensions;
    }

    internal bool ProcessCollision(Player player, GameTime gameTime) {
        bool didCollide = false;
        if(BoundingBox.Intersects(player.BoundingBox)) {
            player.Land(BoundingBox);
            player.StandOn(gameTime);
        }

        return didCollide;
    }

}