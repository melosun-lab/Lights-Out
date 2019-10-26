using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_movement_2 : MonoBehaviour
{
    public SphereCollider barrier;
    private float count = 0f;
    private float position;
    // Start is called before the first frame update
    private float Position_x, Position_y, Position_z;
    private float Amplitude = 7f;
    private float Frequency = 5f;
    private int choice = 2;
    private void Start()
    {
        Position_x = barrier.transform.localPosition.x;
        Position_y = barrier.transform.localPosition.y;
        Position_z = barrier.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {

        count += Time.deltaTime * Frequency;
        switch (choice)
        {
            case 1:
                if (count > Amplitude * 2)
                {
                    count -= Amplitude * 2;
                }
                if (count >= 0 && count <= 3.5)
                    position = count + Position_z;
                else if (count > Amplitude / 2 && count <= Amplitude)
                    position = Position_z + Amplitude - count;
                else if (count > Amplitude && count <= Amplitude * 3 / 2)
                    position = Position_z + Amplitude - count;
                else if (count > Amplitude * 3 / 2 && count <= Amplitude * 2)
                    position = Position_z - Amplitude * 2 + count;
                barrier.transform.localPosition = new Vector3(Position_x, Position_y, position);
                break;
            case 2:
                if (count > Amplitude * 2)
                {
                    count -= Amplitude * 2;
                }
                if (count >= 0 && count <= Amplitude / 2)
                    position = -count + Position_z;
                else if (count > Amplitude / 2 && count <= Amplitude)
                    position = Position_z - Amplitude + count;
                else if (count > Amplitude && count <= Amplitude * 3 / 2)
                    position = Position_z - Amplitude + count;
                else if (count > Amplitude * 3 / 2 && count <= Amplitude * 2)
                    position = Position_z + Amplitude * 2 - count;
                barrier.transform.localPosition = new Vector3(Position_x, Position_y, position);
                break;
        }

    }
}