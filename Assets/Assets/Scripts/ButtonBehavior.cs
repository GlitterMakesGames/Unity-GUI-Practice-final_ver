using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonBehavior : GameManager
{
    protected static TMP_Text questionNum;
    protected static TMP_Text question;
    protected static int questionIndex;
    protected static bool has_started = false;

    protected TMP_Text buttonText;

    protected string[,] questionArray = {{"What day did the original season of Pretty Cure begin airing in Japan?", "February 1, 2003", "March 1, 2003", "February 1, 2004", "March 1 2004", "Button_C"},
                                    {"Which anniversary is the Pretty Cure franchise celebrating during the 2023-2024 season?", "10th anniversary", "15th anniversary", "20th anniversary", "30th anniversary", "Button_C"},
                                    {"Which season of Pretty Cure was the first to feature a woman as a main antagonist?", "Yes! Pretty Cure 5", "Happiness Charge Pretty Cure", "Go! Princess Pretty Cure", "Star Twinkle Pretty Cure", "Button_A"},
                                    {"What is the theme color of the team leader in nearly every season of Pretty Cure?", "Blue", "Pink", "Red", "Rainbow", "Button_B"},
                                    {"What was the first season of Pretty Cure to use CGI for the ending song of each episode?", "Yes! Pretty Cure 5", "Fresh Pretty Cure", "Heartcatch Pretty Cure", "Suite Pretty Cure", "Button_B"},
                                    {"What was the first season to feature a villain later joining the Pretty Cure team?", "Go! Princess Pretty Cure", "Suite Pretty Cure", "Fresh Pretty Cure", "Star Twinkle Pretty Cure", "Button_C"},
                                    {"Which season of Pretty Cure is widely considered one of the darkest in the franchise due to the backstory of one of the cures having strong themes of death, loss, grieving, and trauma?", "Yes! Pretty Cure 5", "Fresh Pretty Cure", "Heartcatch Pretty Cure", "Suite Pretty Cure", "Button_C"},
                                    {"Which season had some of its episodes delayed due to an earthquake in Japan?", "Yes! Pretty Cure 5", "Fresh Pretty Cure", "Heartcatch Pretty Cure", "Suite Pretty Cure", "Button_D"},
                                    {"Which season had some of its episodes delayed due to the owner of the franchise, Toei Animation, getting hacked?", "Tropical-Rouge! Pretty Cure", "Delicious Party Pretty Cure", "Star Twinkle Pretty Cure", "Healin' Good Pretty Cure", "Button_B"},
                                    {"What does the current season, Hirogaru Sky! Pretty Cure, have that no previous season in Pretty Cure history has had?", "A team leader with a different theme color", "A boy as a main character Pretty Cure", "An adult as a main character Pretty Cure", "All of the above", "Button_D"}};

    public void OnStart()
    {
        questionNum = GameObject.Find("Text_WhichQuestion").GetComponent<TMP_Text>();
        question = GameObject.Find("Text_Question").GetComponent<TMP_Text>();
        questionIndex = 0;
        points = 0;
        EditQuestion();
    }
    public void FindButtonText()
    {
        buttonText = this.GetComponentInChildren<TMP_Text>();
    }

    public void EditQuestion()
    {
        int temp = questionIndex + 1;
        questionNum.text = "Question " + temp;
        question.text = questionArray[questionIndex, 0];
        EditAllButtons();
    }
}