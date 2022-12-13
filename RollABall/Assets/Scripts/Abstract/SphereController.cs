#region Header
// SphereController.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using UnityEngine;

    public abstract class SphereController : MonoBehaviour
    {
        public float speed = 5f;

        private Rigidbody _rb;
        private Vector3 _movementInput;
    
        private IInputHandler _inputHandler;
    
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _inputHandler = GetComponent<IInputHandler>();
        }

        private void OnEnable()
        {
            _inputHandler.OnInputHandled += OnInputHandled;
        }

        private void OnDisable()
        {
            _inputHandler.OnInputHandled -= OnInputHandled;
        }

        private void OnInputHandled(Vector3 target)
        {
            _movementInput = target;
        }

        protected virtual void FixedUpdate()
        {
            if (!GameManager.instance.isGameStarted)
            {
                _rb.velocity = Vector3.zero;
                return;
            }
            
            _rb.AddForce(_movementInput * speed);
        }
    }
