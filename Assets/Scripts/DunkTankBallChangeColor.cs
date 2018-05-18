using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DunkTankBallChangeColor : MonoBehaviour {

    private int RandomColor;
    private Color ChosenColor;

    // Use this for initialization
    void Start () {

        System.Random rand = new System.Random();
        RandomColor = rand.Next(1, 11);
        if (RandomColor == 1)
        {
            ChosenColor = Color.black;
        }
        if (RandomColor == 2)
        {
            ChosenColor = Color.red;
        }
        if (RandomColor == 3)
        {
            ChosenColor = Color.green;
        }
        if (RandomColor == 4)
        {
            ChosenColor = Color.yellow;
        }
        if (RandomColor == 5)
        {
            ChosenColor = Color.blue;
        }
        if (RandomColor == 6)
        {
            ChosenColor = Color.clear;
        }
        if (RandomColor == 7)
        {
            ChosenColor = Color.cyan;
        }
        if (RandomColor == 8)
        {
            ChosenColor = Color.grey;
        }
        if (RandomColor == 9)
        {
            ChosenColor = Color.magenta;
        }
        if (RandomColor == 10)
        {
            ChosenColor = Color.white;
        }







        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", ChosenColor);

        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", ChosenColor);

    }
	
    
	// Update is called once per frame
	void Update () {
		
	}

   
}
