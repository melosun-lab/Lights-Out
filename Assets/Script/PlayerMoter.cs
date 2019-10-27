using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[RequireComponent(typeof(Rigidbody))]

public class PlayerMoter : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 cam_rotation = Vector3.zero;

    public Camera cam;
    public Rigidbody rb;

    public GameObject gun;

    public bool moving = false;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 velocity){
        this.velocity = velocity;
    }

    public void Rotate(Vector3 rotate){
        rotation = rotate;
        GetRotated();
    }

    public void RotateCam(Vector3 cam_rotation){
        this.cam_rotation = cam_rotation;
    }
    void FixedUpdate() {
        GetMoved();
        GetRotated();
    }

    void GetMoved(){
        if(this.velocity != Vector3.zero){
            moving = true;
            rb.MovePosition(rb.position + this.velocity * Time.fixedDeltaTime);
        }
        else{
            moving = false;
        }
    }

    void GetRotated(){
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        if(cam){
            if(cam.transform.localRotation.x >= 0.3){
                if( cam_rotation.x < 0){
                    cam_rotation = Vector3.zero;
                }
            }
            if(cam.transform.localRotation.x <= -0.45){
                if(cam_rotation.x > 0){
                    cam_rotation = Vector3.zero;
                }
            }
            cam.transform.Rotate(-cam_rotation);
            gun.transform.Rotate(-cam_rotation);
        }
    }
}
