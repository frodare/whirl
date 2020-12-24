using System;
using Microsoft.Xna.Framework;
using Nez;
using Whirl.Desktop.Components.Utils;
using Whirl.Desktop.Scenes;

namespace Whirl.Desktop.Components
{
  public class SpinBody : Component, IUpdatable
  {

    public PolarVector position = new PolarVector();




    public Vector2 GetWorldPosition()
    {
      // add scene rot
      // convert to vector2d

      PolarVector offseted = new PolarVector(position.Angle - GameScene.rotation, position.Radius);

      return offseted.toVector2();
    }


    void IUpdatable.Update()
    {
      Entity.Transform.Rotation = -GameScene.rotation;
      Entity.Transform.Position = GetWorldPosition();

    }


  }
}
