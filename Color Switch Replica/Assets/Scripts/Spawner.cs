using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    //public GameObject[] objects;
   //public static GameObject colorChanger;
    public static float colorchangeYposition;
    public static float currentYposition = 16.33f;
    public static float diffrence;
    public static int Score;
    public Text text;
	void Start () {
        currentYposition = 16.33f;
        diffrence = 7.2f;
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = Score.ToString();
	}
}
