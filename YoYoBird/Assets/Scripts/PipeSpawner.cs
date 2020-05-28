using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 4;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        // newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-0.15f, 0.9f), 0);
        Destroy(newPipe, 7);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
            GameObject newPipe = Instantiate(pipe);
            // newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-0.15f, 0.9f), 0);
            Destroy(newPipe, 7);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
