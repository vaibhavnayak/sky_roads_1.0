using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    float x_force = 300f, z_force = 300f, y_force = 800f;
    float x_force2 = 15f, z_force2 = 15f;
    float max_velocity_z = 30.0f;
    float max_velocity_x = 5.0f;
    public static float speed_multiplier = 1.0f;
    Vector3 new_velocity = new Vector3();
    void FixedUpdate()
    {
        if(player.position.y < 1.0)
        {
            rb.velocity = Vector3.zero;
            FindObjectOfType<GameManager>().EndGame(1);
        }
        // Debug.Log(rb.velocity.z);
        if(player.position.y > 4)
        {
            rb.AddForce(0 , -y_force * Time.deltaTime / 15.0f, 0, ForceMode.VelocityChange);
        }
        if(player.position.y > 1.3)
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-x_force2 * Time.deltaTime * 2.0f,0 ,0 ,ForceMode.VelocityChange);
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(x_force2 * Time.deltaTime * 2.0f,0 ,0 ,ForceMode.VelocityChange);
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(0 ,0, z_force2 * Time.deltaTime * 1.0f ,ForceMode.VelocityChange);
            }
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(rb.velocity.x > 0)
            {
                new_velocity.z = rb.velocity.z;
                new_velocity.y = rb.velocity.y;
                new_velocity.x = 0.0f;
                rb.velocity = new_velocity;
            }

            if(Mathf.Abs(rb.velocity.x) < max_velocity_x)
            {
                rb.AddForce(-x_force * Time.deltaTime * speed_multiplier,0 ,0 );
            }
            
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(rb.velocity.x < 0)
            {
                new_velocity.z = rb.velocity.z;
                new_velocity.y = rb.velocity.y;
                new_velocity.x = 0.0f;
                rb.velocity = new_velocity;
            }

            if(Mathf.Abs(rb.velocity.x) < max_velocity_x)
            {
                rb.AddForce(x_force * Time.deltaTime * speed_multiplier,0 ,0 );
            }
            
        }
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(rb.velocity.z < max_velocity_z)
            {
                rb.AddForce(0 ,0, z_force * Time.deltaTime * speed_multiplier);
            }
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            if(rb.velocity.z > 0)
            {
                rb.AddForce(0 ,0, -z_force * Time.deltaTime * speed_multiplier * 2);
            }
        }
        if(Input.GetKey(KeyCode.Space))
        {
            if(player.position.y < 1.26 && player.position.y > 1.24)
            {
                rb.AddForce(0 ,y_force, 0);
            }
        }
    }
}
