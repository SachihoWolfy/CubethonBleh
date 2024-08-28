using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Vector3 dieTorque;
    public Vector3 dieForce;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) 
        {
            Die();
        }
    }
    public void Die()
    {
        movement.rb.AddForce(dieForce, ForceMode.VelocityChange);
        movement.rb.AddTorque(dieTorque, ForceMode.VelocityChange);
        movement.enabled = false;
        GameManager.instance.EndGame();
    }
}
