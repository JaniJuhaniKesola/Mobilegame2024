using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileExample
{
    public class ReadInput : MonoBehaviour
    {
        private Inputs _inputs;
        private Vector2 _movementInput = Vector2.zero;
        private bool _interactInput = false;
        public Vector2 Movement
        {
            get { return _movementInput; }
        }
        private void Awake() 
        {
            _inputs = new Inputs();
        }

        private void OnEnable()
        {
            _inputs.Game.Enable();
        }

        private void OnDisable()
        {
            _inputs.Game.Disable();
        }

        // Update is called once per frame
        void Update()
        {
            _movementInput = _inputs.Game.Move.ReadValue<Vector2>();
        }
    }
}
