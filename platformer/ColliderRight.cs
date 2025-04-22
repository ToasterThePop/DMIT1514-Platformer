using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace platformer;

public class ColliderRight : Collider
{

    public ColliderRight(Vector2 position, Vector2 dimensions)
    {
        this.position = position;
        this.dimensions = dimensions;
    }

    internal bool ProcessCollision(Player player, GameTime gameTime) {
        bool didCollide = false;
        if(BoundingBox.Intersects(player.BoundingBox)) {
            if(player.Velocity.X < 0)
            {
                player.MoveHorizontally(0);
            }
        }

        return didCollide;
    }

}