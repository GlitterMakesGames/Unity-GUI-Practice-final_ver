using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    protected static int points;

    Button Button_A;
    Button Button_B;
    Button Button_C;
    Button Button_D;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            SceneManager.LoadScene(0);
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void AssignButtons()
    {
        Button_A = GameObject.Find("Button_A").GetComponent<Button>();
        Button_B = GameObject.Find("Button_B").GetComponent<Button>();
        Button_C = GameObject.Find("Button_C").GetComponent<Button>();
        Button_D = GameObject.Find("Button_D").GetComponent<Button>();
    }

    public void EditAllButtons()
    {
        AssignButtons();
        Button_A.GetComponent<Button_02>().EditButton();
        Button_B.GetComponent<Button_02>().EditButton();
        Button_C.GetComponent<Button_02>().EditButton();
        Button_D.GetComponent<Button_02>().EditButton();
    }
}