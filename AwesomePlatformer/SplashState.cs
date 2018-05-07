using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace AwesomePlatformer
{
    public class SplashState : AIE.State
    {
        SpriteFont font = null;
        float timer = 7;

        public SplashState() : base()
        {

        }

        public override void CleanUp()
        {
            font = null;
            timer = 7;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
                spriteBatch.DrawString(font, "Welcome to the Awesome Platformer", new Vector2(200,200),Color.White);
            spriteBatch.End();
        }

        public override void Update(ContentManager Content, GameTime gameTime)
        {
            if (font == null)
            {
                font = Content.Load<SpriteFont>("Arial");
            }

            timer -= (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (timer <= 0)
            {
                AIE.StateManager.ChangeState("Game");
            }
        }
    }
}
