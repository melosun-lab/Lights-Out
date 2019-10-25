using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_movement_3 : MonoBehaviour
{
    public SphereCollider barrier;
    private float count = 0f;
    private float position;
    // Start is called before the first frame update
    private float Position_x, Position_y, Position_z;
    private float Velocity = 7f;
    private int choice = 1;
    private void Start()
    {
        Position_x = barrier.transform.localPosition.x;
        Position_y = barrier.transform.localPosition.y;
        Position_z = barrier.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {

        count += Time.deltaTime;
        switch (choice)
        {
            case 1:
                if (count > Velocity * 2)
                {
                    count -= Velocity * 2;
                }
                if (count >= 0 && count <= 3.5)
                    position = count + Position_z;
                else if (count > Velocity / 2 && count <= Velocity)
                    position = Position_z + Velocity - count;
                else if (count > Velocity && count <= Velocity * 3 / 2)
                    position = Position_z + Velocity - count;
                else if (count > Velocity * 3 / 2 && count <= Velocity * 2)
                    position = Position_z - Velocity * 2 + count;
                barrier.transform.localPosition = new Vector3(Position_x, Position_y, position);
                break;
            case 2:
                if (count > Velocity * 2)
                {
                    count -= Velocity * 2;
                }
                if (count >= 0 && count <= Velocity / 2)
                    position = -count + Position_z;
                else if (count > Velocity / 2 && count <= Velocity)
                    position = Position_z - Velocity + count;
                else if (count > Velocity && count <= Velocity * 3 / 2)
                    position = Position_z - Velocity + count;
                else if (count > Velocity * 3 / 2 && count <= Velocity * 2)
                    position = Position_z + Velocity * 2 - count;
                barrier.transform.localPosition = new Vector3(Position_x, Position_y, position);
                break;
        }

    }

}
