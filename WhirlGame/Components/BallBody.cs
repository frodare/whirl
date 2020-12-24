using System;
using Microsoft.Xna.Framework;
using Nez;

namespace Whirl.Desktop.Components
{
  public class BallBody : Component, IUpdatable
  {

    public Vector2 velocity;
    Collider _collider;

    Scene _scene;

    public BallBody(Scene scene)
    {
      _scene = scene;
    }

    public override void OnAddedToEntity()
    {
      _collider = Entity.GetComponent<Collider>();
    }

    void IUpdatable.Update()
    {

      Entity.Transform.Position += velocity * Time.DeltaTime;

      CollisionResult collisionResult;

      var neighbors = Physics.BoxcastBroadphaseExcludingSelf(_collider, _collider.CollidesWithLayers);

      foreach (var neighbor in neighbors)
      {
        if (neighbor.Entity == Entity) continue;


        if (_collider.CollidesWith(neighbor, out collisionResult))
        {
          //entity.transform.position -= collisionResult.minimumTranslationVector;
          //var relativeVelocity = velocity;
          //calculateResponseVelocity(ref relativeVelocity, ref collisionResult.minimumTranslationVector, out relativeVelocity);
          //velocity += relativeVelocity;

          velocity.Y *= -1;


        }
      }
    }


  }
}
