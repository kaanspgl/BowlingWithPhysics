using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;


        if (triggeredBody.CompareTag("Ball"))
        {

            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            ballRigidBody.AddForce(Vector3.left * velocityMagnitude, ForceMode.VelocityChange);

        }
        
    }
}
