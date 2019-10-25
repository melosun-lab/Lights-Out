using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCenter : MonoBehaviour{
    
    public void WinGame(){
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void LoseGame(){
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart(){
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Dead(){
        Invoke("LoseGame", 2f);
    }

    public void quit(){
        Application.Quit();
    }

    //void
}

