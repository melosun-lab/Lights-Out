using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_movement_3 : MonoBehaviour
{
    public SphereCollider barrier;
    private float count = 0;
    private float position;
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        count += Time.deltaTime;
        if (count > 14)
        {
            count -= 14;
        }
        if (count >= 0 && count <= 3.5)
            position = count - 47.5f;
        else if (count > 3.5 && count <= 7)
            position = -40.5f - count;
        else if (count > 7 && count <= 10.5)
            position = -40.5f - count;
        else if (count > 10.5 && count <= 14)
            position = -61.5f + count;
        barrier.transform.localPosition = new Vector3(65f, 3f, position);
    }
}
