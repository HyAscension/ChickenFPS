using System;
using System.Collections.Generic;
using System.Text;

namespace HyVo_ChickenFPS.Sprites
{
    public interface ICollidable
    {
        void OnCollide(Sprite sprite);
    }
}
