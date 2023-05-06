using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndButton : ButtonBehavior
{
    void Start()
    {
        question = GameObject.Find("Text_Question").GetComponent<TMP_Text>();
        question.text = "You got " + points + " question(s) correct!";
    }
    public void OnButtonPress()
    {
        has_started = false;
        SceneManager.LoadScene(0);
    }
}