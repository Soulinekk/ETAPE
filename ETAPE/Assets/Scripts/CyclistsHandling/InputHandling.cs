using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EtapeGame
{
    namespace PlayerMovementHandler
    {
        public class InputHandling : MonoBehaviour {

            public float turningSpeedMultiplayer;
            public float DrivingImpulsForce;
            private float horizontalInput;
            public Rigidbody rb;
            private Transform playerTransform;

            void Start()
            {
                playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
                rb = playerTransform.gameObject.GetComponent<Rigidbody>();
            }


            void Update()
            {
                GetInput();
            }

            private void FixedUpdate()
            {
                TurningsHandling();
            }

            private void GetInput()
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    MovingForwardHandling();
                }
                horizontalInput = Input.GetAxis("Horizontal");
            }

            private void MovingForwardHandling()
            { 
                rb.AddForce(playerTransform.forward * DrivingImpulsForce, ForceMode.Impulse);
            }

            private void TurningsHandling()
            {

            }
        }
    }
}
