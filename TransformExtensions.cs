using UnityEngine;

namespace Karan.Util.Extensions
{
    public static class TransformExtensions
    {
	public static void MovePosition2D(this GameObject go, PositionDirection2D dir, float speed)
        {
            switch (dir)
            {
                case PositionDirection2D.Right :
                    go.transform.Translate(go.transform.right * speed);
                    break;
                case PositionDirection2D.Left :
                    go.transform.Translate(go.transform.right * (speed * -1));
                    break;
                case PositionDirection2D.Up :
                    go.transform.Translate(go.transform.up * speed);
                    break;
                case PositionDirection2D.Down :
                    go.transform.Translate(go.transform.up * (speed * -1));
                    break;
            }
        }

        private static void MovePosition2D(Transform transform, PositionDirection2D direction, float posX, float posY)
        {
            var pos = transform.position;

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

            transform.position = pos;
        }
        
        public static void MovePosition2D(this GameObject go, PositionDirection2D direction, float posX, float posY) =>
            MovePosition2D(go.transform, direction, posX, posY); 
        
        public static void MovePosition2D(this MonoBehaviour mb, PositionDirection2D direction, float posX, float posY) =>
            MovePosition2D(mb.transform, direction, posX, posY); 

        public static void Whirl2D(this MonoBehaviour mb, Rotate2D rotate, float speed)
        {
            object vector;
            vector = null;

            switch (rotate)
            {
                case Rotate2D.Clockwise:
                    vector = new Vector3(0, 0, -1);
                    break;
                case Rotate2D.CounterClockwise :
                    vector = new Vector3(0, 0, 1);
                    break;
            }
            
            mb.transform.Rotate((Vector3)vector * Time.deltaTime * speed);
        }
    }
}

