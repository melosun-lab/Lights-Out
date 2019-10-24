using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCenter : MonoBehaviour
{
    void EndGame(){

    }
    
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

    public void quit(){
        Application.Quit();
    }

    //void
}

