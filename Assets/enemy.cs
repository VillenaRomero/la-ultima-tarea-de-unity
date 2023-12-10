using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float minXposition;
    public float maxXposition;
    public GameObject objEnemyPref;
    public float minTime;
    public float maxTime;
    void Start()
    {
        float Time = random.Range(minTime, maxTime);
        Invoke("createEnemy", time);
    }

    // Update is called once per frame
    void cReateEnemy()
    {
        float x = Random.Range(minXposition, maxXposition);
        Vector2 position = new Vector2(x, 6.26f);
        Instantiate(objEnemyPref, position, transform.rotation);
        float Time = random.Range(minTime, maxTime);
        Invoke("createEnemy" , time);
    }
}
