using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AwesomePlatformer
{
    class Player
    {
        Sprite sprite = new Sprite();

        public Player()
        {
        }

        public void Load(ContentManager content)
        {
            sprite.Load(content, "adventurer_stand");
        }

        public void Update(float deltaTime)
        {
            sprite.Update(deltaTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
