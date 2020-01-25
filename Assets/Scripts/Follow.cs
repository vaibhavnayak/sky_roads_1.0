using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    Vector3 new_pos = new Vector3();
    void LateUpdate()
    {
        new_pos.z = player.position.z - 15;
        new_pos.y = this.transform.position.y;
        new_pos.x = this.transform.position.x;
        this.transform.position = new_pos;

    }
}
