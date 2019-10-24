using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_End : MonoBehaviour
{
    public Rigidbody player;
    public BoxCollider win_point;
    // Start is called before the first frame update
    void Start()
    {
        int ran = Random.Range(1, 6);
        switch(ran)
        {
            case 1:
                player.transform.localPosition = new Vector3(45f,3f,-5.5f);
                player.transform.localRotation = Quaternion.LookRotation(new Vector3(90, 0, 0));
                win_point.transform.localPosition = new Vector3(36f, 3f, -91f);
                break;
            case 2:
                player.transform.localPosition = new Vector3(36f, 3f, -91f);
                player.transform.localRotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
                win_point.transform.localPosition = new Vector3(45f, 3f, -5.5f);
                break;
            case 3:
                player.transform.localPosition = new Vector3(36f, 3f, -5.5f);
                player.transform.localRotation = Quaternion.LookRotation(new Vector3(270, 0, 0));
                win_point.transform.localPosition = new Vector3(95.5f, 3f, -82f);
                break;
            case 4:
                player.transform.localPosition = new Vector3(95.5f, 3f, -82f);
                player.transform.localRotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
                win_point.transform.localPosition = new Vector3(36f, 3f, -5.5f);
                break;
            case 5:
                player.transform.localPosition = new Vector3(95.5f, 3f, -16f);
                player.transform.localRotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
                win_point.transform.localPosition = new Vector3(5.5f, 3f, -91f);
                break;
            case 6:
                player.transform.localPosition = new Vector3(5.5f, 3f, -91f);
                player.transform.localRotation = Quaternion.LookRotation(new Vector3(180, 0, 0));
                win_point.transform.localPosition = new Vector3(95.5f, 3f, -16f);
                break;

        }
       
    }
}
