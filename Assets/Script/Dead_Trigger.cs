using UnityEngine;
using UnityEngine.UI;
public class Dead_Trigger : MonoBehaviour
{
    public GameCenter GameCenter;
    public GameObject deadUI;
    // Start is called before the first frame update    public GameCenter GameCenter;
    private void OnTriggerEnter(Collider other) {
        deadUI.SetActive(true);
        GameCenter.Dead();
    }
}
