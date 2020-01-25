using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    public Rigidbody rb;

    Vector3 new_velocity = new Vector3();
    void OnCollisionEnter(Collision colliding_object)
    {
        string material_name = colliding_object.gameObject.GetComponent<Renderer>().material.name;
        // Debug.Log(material_name);

        if(string.Equals(material_name, "Mat_Red (Instance)"))
        {
            // Debug.Log("Red");
            Player.speed_multiplier = 0.0f;
            rb.velocity = Vector3.zero;
            FindObjectOfType<GameManager>().EndGame(2);
        }
        else if(string.Equals(material_name, "Mat_Yellow (Instance)"))
        {
            // Debug.Log("Yellow");
            Player.speed_multiplier = 0.5f;
        }
        else if(string.Equals(material_name, "Mat_Green (Instance)"))
        {
            // Debug.Log("Green");
            Player.speed_multiplier = 2.0f;
        }
        else
        {
            // Debug.Log("Other");
            Player.speed_multiplier = 1.0f;
        }
        if(!string.Equals(material_name, "Mat_Purple (Instance)"))
        {
            new_velocity.z = rb.velocity.z;
            new_velocity.y = rb.velocity.y;
            new_velocity.x = rb.velocity.x / 5.0f;
            rb.velocity = new_velocity;
        }
        
    }
}
