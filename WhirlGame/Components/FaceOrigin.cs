using System;
using Nez;
using Microsoft.Xna.Framework;

namespace Whirl.Desktop.Components
{
  public class FaceOrigin : Component, IUpdatable
  {
    void IUpdatable.Update()
    {
      Entity.Transform.Rotation = VectorToAngle(Entity.Transform.Position) + (float)Math.PI / 2;
    }

    float VectorToAngle(Vector2 vector)
    {
      return (float)Math.Atan2(vector.Y, vector.X);
    }
  }
}
