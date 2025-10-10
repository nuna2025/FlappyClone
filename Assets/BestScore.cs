using UnityEngine;

using TMPro;

public class BestScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Best Score: " + Score.bestScore.ToString();
    }


}
