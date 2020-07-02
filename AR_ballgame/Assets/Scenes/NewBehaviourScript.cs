using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    //float ran = Random.Range(-50.0f, 50.0f);
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject.Find("Cube").transform.Rotate(0, 0,f);
        GameObject.Find("Cube").transform.Rotate(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.5f, 0.5f));
       
    }

    public void left()
    {
        GameObject.Find("Cube").transform.Rotate(0, 0, 5f);
    }
    public void right()
    {
        GameObject.Find("Cube").transform.Rotate(0, 0, -5f);
    }

    public void front()
    {
        GameObject.Find("Cube").transform.Rotate(-5f, 0, 0);
    }

    public void back()
    {
        GameObject.Find("Cube").transform.Rotate(5f, 0, 0);
    }
}
