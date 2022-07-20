using UnityEngine;

namespace Karan.Util.Extensions
{
    public static class TransformExtensions 
    {
        public static void MovePosition2D(this MonoBehaviour mb, PositionDirection2D direction, float posX, float posY)
        {
            var pos = mb.transform.position;
        
            switch (direction)
            {
                case PositionDirection2D.Up :
                    pos.y += posY;
                    break;
                case PositionDirection2D.Right :
                    pos.x += posX;
                    break;
                case PositionDirection2D.Down :
                    pos.y -= posY;
                    break;
                case PositionDirection2D.Left :
                    pos.x -= posX;
                    break;
                case PositionDirection2D.RightAndUp :
                    pos.x += posX;
                    pos.y += posY;
                    break;
                case PositionDirection2D.RightAndDown :
                    pos.x += posX;
                    pos.y -= posY;
                    break;
                case PositionDirection2D.LeftAndUp :
                    pos.x -= posX;
                    pos.y += posY;
                    break;
                case PositionDirection2D.LeftAndDown :
                    pos.x -= posX;
                    pos.y -= posY;
                    break;
            }

            mb.transform.localPosition = pos;
        }
    }
}

