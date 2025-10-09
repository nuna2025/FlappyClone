using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Score.score++;
    }
}
