using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timdDiff;
    float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timdDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-0.7f, 5.1f), 0);
            timer = 0;
            Destroy(newpipe, 5.0f);
        }
    }
}
