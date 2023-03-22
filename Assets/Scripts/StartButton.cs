using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public string loadScene = "";
   public void onClickStart()
    {
        SceneManager.LoadScene(loadScene, LoadSceneMode.Single);
    }
}
