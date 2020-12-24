using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace Whirl.Desktop.Components
{
  public class PaddleMover : Component, IUpdatable
  {

    private float speed = 1f;

    private int player;

    public PaddleMover(int player)
    {
      this.player = player;
    }

    public void Update()
    {
      float motion = 0f;

      if (Input.IsKeyDown(player == 0 ? Keys.Left : Keys.A))
      {
        motion = -speed;
      }
      else if (Input.IsKeyDown(player == 0 ? Keys.Right : Keys.D))
      {
        motion = speed;
      }

      Entity.GetComponents<SpinBody>()[0].position.Angle += motion * Time.DeltaTime;
    }

  }
}
