using UnityEngine;

namespace Karan.Unity.Util.Generic
{
    public class ObjectFactory : MonoBehaviour
    {
        public Object Object;
    
        public virtual Object  NewInstance() => Instantiate(Object);

        public virtual Object NewInstance(Vector3 position, Quaternion rotation) =>
            Instantiate(Object, position, rotation);
    }
}

