using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCenter : MonoBehaviour
{
    void EndGame(){

    }

    public void WinGame(){
        Debug.Log("Win");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoseGame(){
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void quit(){
        Application.Quit();
    }

    //void
}

