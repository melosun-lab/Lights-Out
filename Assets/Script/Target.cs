using UnityEngine;

public class Target : MonoBehaviour
{
    public float hp = 5f;

    public void TakeDamege(float damege){
        hp -= damege;
        if(hp <= 0){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
    }
}
