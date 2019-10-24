using UnityEngine;
using UnityEngine.UI;

public class brightness : MonoBehaviour
{
    Light light;

    public GameObject timerUI;

    public Text text;
    private float count = 120;

    void Start()
    {
        light = GetComponent<Light>();
        light.intensity = 2f;
    }
    // Update is called once per frame
    void FixedUpdate() {
        count -= Time.deltaTime;
        light.intensity = 2f / 120 * count;
        if(count <= 0 && count >= -5){
            text.text = (5 + count).ToString("0");
            timerUI.SetActive(true);
        }
        if(count <= -5){
            FindObjectOfType<GameCenter>().LoseGame();
        }
    }
}
