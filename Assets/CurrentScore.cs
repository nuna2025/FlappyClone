using UnityEngine;

using TMPro;

public class CurrentScore : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Score: " + Score.score.ToString();

    }

}
