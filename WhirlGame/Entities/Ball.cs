using System;
using Nez;
using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;
using Whirl.Desktop.Components;
using Microsoft.Xna.Framework;

namespace Whirl.Desktop.Entities
{
  public class Ball
  {
    public static Entity New(Scene scene)
    {
      var e = scene.CreateEntity("ball");
      Texture2D tex = BallTexture(scene);

      e.AddComponent(new SpriteRenderer(tex));

      e.AddComponent<CircleCollider>();

      BallBody body = new BallBody(scene);
      body.velocity = new Vector2(0, 0);
      e.AddComponent(body);

      e.AddComponent(new CircularBounds(Vector2.Zero, 300));

      return e;
    }

    private static Texture2D BallTexture(Scene scene)
    {
      Texture2D originalTexture = scene.Content.Load<Texture2D>("balls");
      var sourceRectangle = new Rectangle(0, 0, 32, 32);


      var texture = new Texture2D(Core.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
      Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
      originalTexture.GetData(0, sourceRectangle, data, 0, data.Length);
      texture.SetData(data);
      return texture;
    }

  }
}
