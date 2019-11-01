using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class player_detector : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public BoxCollider enemy;
    private bool enemy_movement_enabled;
    private float count = 0;
    private float Velocity = 1f;
    private string main_direction = "";
    private string next_direction = "";
    private bool Collision_enabled = false;
    private void Start()
    {
        enemy_movement_enabled = false;
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Collision")
        {
            Collision_enabled = true;
        }
        else
        {
            Collision_enabled = false;
        }
    }
    void Update()
    {
        float p_x = rb.transform.localPosition.x;
        float p_z = rb.transform.localPosition.z;
        float e_x = enemy.transform.localPosition.x;
        float e_y = enemy.transform.localPosition.y;
        float e_z = enemy.transform.localPosition.z;
        float Distance = Mathf.Sqrt((p_x - e_x) * (p_x -e_x) + (p_z - e_z) *(p_z - e_z));
        if ((Distance < 10f) && (Distance > 0f))
        {
            enemy_movement_enabled = true;
            if (Mathf.Abs(p_x - e_x) > Distance / Mathf.Sqrt(2))
            {
                if (p_x - e_x > 0)
                {
                    main_direction = "East"; 
                }
                else
                {
                    main_direction = "West";
                }
                if (p_z - e_z > 0)
                {
                    next_direction = "North";
                }
                else
                {
                    next_direction = "South";
                }
            }
            else
            {
                if (p_x - e_x > 0)
                {
                    next_direction = "East";
                }
                else
                {
                    next_direction = "West";
                }
                if (p_z - e_z > 0)
                {
                    main_direction = "North";
                }
                else
                {
                    main_direction = "South";
                }
            }
        }
        else
        {
            if (Distance <= 0f)
            {
                enemy_movement_enabled = false;
            }
        }
        if (enemy_movement_enabled)
        {
            string direction = "";
            count += Time.deltaTime;
            if (Collision_enabled)
            {
                direction = next_direction;
            }
            else
            {
                direction = main_direction;
            }
            switch (direction)
            {
                case "North":
                    enemy.transform.localPosition = new Vector3(e_x,e_y,e_z + count * Velocity);
                    break;
                case "South":
                    enemy.transform.localPosition = new Vector3(e_x, e_y, e_z - count * Velocity);
                    break;
                case "West":
                    enemy.transform.localPosition = new Vector3(e_x - count * Velocity, e_y, e_z );
                    break;
                case "East":
                    enemy.transform.localPosition = new Vector3(e_x + count * Velocity, e_y, e_z);
                    break;
            }
            if (count >0.2)
            {
                enemy_movement_enabled = false;
                count = 0;
            }
        }
    }
}
