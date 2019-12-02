using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderAnimation : MonoBehaviour
{

    public float delayMaximo = 0.0f;

    private Animation spiderAnim;
    private bool started = false;
    private float timeStart;
    private float timeDelay;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = Time.time;
        timeDelay = Random.Range(0.0f, delayMaximo);
    }

    // Update is called once per frame
    void Update()
    {
        if (!started) {
            if (Time.time > timeStart+timeDelay) {
                spiderAnim = GetComponentInChildren<Animation>();
                spiderAnim["SpiderUpDown"].wrapMode = WrapMode.Loop;
                spiderAnim.Play("SpiderUpDown");
                started = true;
            }
        }
        
    }
}
