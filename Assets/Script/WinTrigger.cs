using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameCenter GameCenter;
   private void OnTriggerEnter(Collider other) {
       GameCenter.WinGame();
   }
}