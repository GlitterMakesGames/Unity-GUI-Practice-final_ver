using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Button_02 : ButtonBehavior
{
    void Start()
    {
        if (!has_started)
        {
            has_started = true;
            base.OnStart();
        }
    }
    public void EditButton()
    {
        FindButtonText();
        switch (this.name)
        {
            case "Button_A":
                buttonText.text = questionArray[questionIndex, 1];
                break;
            case "Button_B":
                buttonText.text = questionArray[questionIndex, 2];
                break;
            case "Button_C":
                buttonText.text = questionArray[questionIndex, 3];
                break;
            case "Button_D":
                buttonText.text = questionArray[questionIndex, 4];
                break;
        }
    }
    public void OnButtonPress()
    {
        if (this.name.Equals(questionArray[questionIndex, 5]))
        {
            points++;
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Incorrect");
        }

        if ((questionIndex + 1) < 10)
        {
            questionIndex++;
            EditQuestion();
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    public void ClearButton()
    {
        buttonText.text = "";
    }
}