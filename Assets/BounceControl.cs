using UnityEngine;

public class BounceControl : MonoBehaviour
{
    private int bounceCount = 0;
    public int maxBounces = 3; // Set how many bounces before stopping
    private PhysicMaterial ballMaterial;

    private void Start()
    {
        // Get the material attached to the collider
        ballMaterial = GetComponent<Collider>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Increase the bounce count each time the ball hits a surface
        bounceCount++;

        // Check if the bounce count has reached the maximum allowed bounces
        if (bounceCount >= maxBounces)
        {
            // Reduce the bounciness gradually to 0
            ballMaterial.bounciness = 0f;
            GetComponent<Rigidbody>().velocity = Vector3.zero; // Stop the ball
        }
    }
}
