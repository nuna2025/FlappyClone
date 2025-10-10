using UnityEngine;
//using UnityEngine.UI;

using TMPro;

public class Score : MonoBehaviour
{
    //private TMP_InputField inputField;
    public TextMeshProUGUI scoreText;
    public static int score = 0;
    public static int bestScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // score = 0;
        //inputField = GetComponent<TMP_InputField>();
        scoreText = GetComponent<TextMeshProUGUI>();
        
        if (scoreText == null)
        {
            Debug.LogError("TextMeshProUGUI Component not found. Score display needs a TextMeshProUGUI component.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Set the text to the .text property of the TextMeshProUGUI.
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }
}
