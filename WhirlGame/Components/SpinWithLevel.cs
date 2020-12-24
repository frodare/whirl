using System;
using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;
using Whirl.Desktop.Scenes;

namespace Whirl.Desktop.Components
{
  public class SpinWithLevel : Component, IUpdatable
  {
    private float lastRot = 0;

    void IUpdatable.Update()
    {

      Entity.Transform.Rotation = -GameScene.rotation;
      Entity.Transform.Position = RotateAboutOrigin(Entity.Transform.Position, -(GameScene.rotation - lastRot));
      lastRot = GameScene.rotation;

    }

    public Vector2 RotateAboutOrigin(Vector2 point, float rotation)
    {
      return Vector2.Transform(point, Matrix.CreateRotationZ(rotation));
    }

  }
}
