using UnityEngine;

namespace Karan.Util.Extensions
{
    public static class RigidBody2DExtension
    {
        public static void AddExplosionForce(this Rigidbody2D rigidbody, float force, Vector3 position, float radius)
        {
            var forceVector = rigidbody.transform.position - position;
            var wearOff = 1 - forceVector.magnitude / radius;

            rigidbody.AddForce(forceVector.normalized * force * wearOff);
        }
    }
}

