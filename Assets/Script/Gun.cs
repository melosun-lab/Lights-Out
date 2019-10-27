using UnityEngine;

public class Gun : MonoBehaviour
{    
    public float damege = 1f;

    public float range = 100f;

    public ParticleSystem mf;

    public GameObject impact;
    public Camera cam;
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Fire();
        }
    }

    void Fire(){
        mf.Play();
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            
            if(target != null){
                target.TakeDamege(damege);
            }

            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
