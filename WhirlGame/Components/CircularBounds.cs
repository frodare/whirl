using System;
using Microsoft.Xna.Framework;
using Nez;

namespace Whirl.Desktop.Components
{

  public class CircularBounds : Component, IUpdatable
  {

    private Vector2 position;
    private float radiusSq;

    public CircularBounds(Vector2 position, float radius)
    {
      this.position = position;
      this.radiusSq = radius * radius;
    }

    void IUpdatable.Update()
    {

      Vector2 toCenter = position - Entity.Position;
      float distanceFromCenterSq = toCenter.LengthSquared();


      if (distanceFromCenterSq > radiusSq)
      {

        BallBody body = Entity.GetComponent<BallBody>();
        float speed = body.velocity.Length();
        toCenter.Normalize();

        body.velocity = toCenter * speed;

      }

    }


  }
}
