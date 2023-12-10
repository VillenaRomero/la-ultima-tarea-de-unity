using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class gamemanager : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    public void UpdatePoints() {
        points = points + 1;
        TextPoints.Text = "Puntos : " + points;
    }
}
