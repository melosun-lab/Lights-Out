using UnityEngine;

[RequireComponent(typeof(PlayerMoter))]
public class PlayerController : MonoBehaviour
{
    private float speed = 5f;

    public float sensitivity = 3f;

    private PlayerMoter player_moter;

    public Rigidbody rb;
    public float jumpforce;

    void Start (){
        player_moter = GetComponent<PlayerMoter>();
    }

    void Update() {
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_z = Input.GetAxisRaw("Vertical");
        
        Vector3 move_horrizontal = transform.right * move_x;
        Vector3 move_vertical = transform.forward * move_z;

        Vector3 local_velocity = (move_horrizontal + move_vertical).normalized * speed;
        player_moter.Move(local_velocity);

        float rotate_y = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0f, rotate_y, 0f) * sensitivity;

        player_moter.Rotate(rotation);

        float rotate_x = Input.GetAxisRaw("Mouse Y");

        Vector3 cam_rotation = new Vector3(rotate_x, 0f, 0f) * sensitivity;

        player_moter.RotateCam(cam_rotation);

        if (Input.GetKey(KeyCode.Space) && (transform.localPosition.y <= 1.08))
            {
                rb.velocity = new Vector3(0f, jumpforce, 0f);
            }


    }
    
}
