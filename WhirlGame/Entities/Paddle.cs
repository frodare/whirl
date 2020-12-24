using System;
using Nez;
using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;
using Whirl.Desktop.Components;
using Microsoft.Xna.Framework;

namespace Whirl.Desktop.Entities
{
  public class Paddle
  {
    public static void New(Scene scene, int player)
    {
      var e = scene.CreateEntity("paddle" + player);
      Texture2D texture = scene.Content.Load<Texture2D>("paddle");
      e.AddComponent(new SpriteRenderer(texture));

      BoxCollider boxCollider = new BoxCollider();
      e.AddComponent(boxCollider);

      SpinBody body = new SpinBody();
      e.AddComponent(body);

      e.AddComponent(new PaddleMover(player));

      e.AddComponent<FaceOrigin>();


      if (player == 0)
      {
        body.position.Angle = 0;
      }
      else
      {
        body.position.Angle = 1;
      }

      body.position.Radius = 300;


      //e.transform.position = new Vector2(0, -400f + (player * 800));
    }

  }
}
