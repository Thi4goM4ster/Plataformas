using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void Startgame()
    {
        GameManager.instance.LoadScene("Game");
        }
    
        public void Quitgame()
        {
           Application.Quit(); 
    }
}