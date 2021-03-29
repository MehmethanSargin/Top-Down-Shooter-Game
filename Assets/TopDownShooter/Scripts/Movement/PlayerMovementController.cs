using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        private InputData inputData;

        [SerializeField]
        private Rigidbody body;

        [SerializeField]
        private PlayerMovementSettings playerMovementSettings;

        private void Update()
        {
            body.MovePosition(body.position + (body.transform.forward * inputData.Vertical * playerMovementSettings.VerticalSpeed ));
            
            body.MovePosition(body.position + (body.transform.right * inputData.Horizontal * playerMovementSettings.HorizontalSpeed));
        }
    }

}
