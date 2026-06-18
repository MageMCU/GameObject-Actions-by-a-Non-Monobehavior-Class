using UnityEngine;

namespace Examples
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;

        private Mover mover;

        private void Awake()
        {
            mover = new Mover();
            mover.Initialize(transform, moveSpeed);
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            mover.Steer(horizontal);
        }
    }
}
