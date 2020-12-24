using System;
using Microsoft.Xna.Framework;
using Nez;

namespace Whirl.Desktop.Scenes
{
  public class GameScene : Scene
  {
    public static float rotation = 0;
    public static float speed = 1.25f;

    public override void Initialize()
    {
      base.Initialize();


    }

    public override void OnStart()
    {
      base.OnStart();

    }

    public override void Update()
    {
      base.Update();
      Camera.Position = Vector2.Zero;
      rotation += speed * Time.DeltaTime;
      Camera.Rotation = rotation;
    }
  }
}
