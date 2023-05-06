using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartButton : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(1);
    }
}
