using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace platformer;

public class ColliderBottom : Collider
{

    public ColliderBottom(Vector2 position, Vector2 dimensions)
    {
        this.position = position;
        this.dimensions = dimensions;
    }

    internal bool ProcessCollision(Player player, GameTime gameTime) {
        bool didCollide = false;
        if(BoundingBox.Intersects(player.BoundingBox)) {
            if(player.Velocity.Y < 0)
            {
                player.MoveVertically(0);
            }
        }

        return didCollide;
    }

}