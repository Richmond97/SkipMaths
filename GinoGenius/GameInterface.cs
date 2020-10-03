using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GinoGenius
{
    interface IGameInterface
    {

        void Update();
        void MoveGameEntity(Direction direction);
    }
}
