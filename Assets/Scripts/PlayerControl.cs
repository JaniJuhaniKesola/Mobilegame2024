using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileExample
{
    [RequireComponent(typeof(ReadInput), typeof(Movement))]
    public class PlayerControl : MonoBehaviour
    {
        private ReadInput _ReadInput = null;
        private Movement _movement = null;
        // Start is called before the first frame update
        private void Awake()
        {
            _ReadInput = GetComponent<ReadInput>();
            _movement = GetComponent<Movement>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 movement = _ReadInput.Movement;
            _movement.Move(movement);
        }
    }
}
