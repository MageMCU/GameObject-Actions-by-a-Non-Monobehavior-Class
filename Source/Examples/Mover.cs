using UnityEngine;

namespace Examples
{
    // Pure C# movement logic that can be reused and unit tested.
    public class Mover
    {
        private Transform target;
        private float speed;

        public void Initialize(Transform targetTransform, float moveSpeed)
        {
            target = targetTransform;
            speed = moveSpeed;
        }

        public void Steer(float horizontalInput)
        {
            if (target == null) return;

            Vector3 delta = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;
            target.Translate(delta, Space.World);
        }
    }
}
