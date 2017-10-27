using UnityEngine;
using System.Collections;

public class Start_A : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown( KeyCode.Escape ) )
        {
            Application.Quit();
        }
    }
    public void Button()
    {
        Application.LoadLevel("Car_10_6_Practice");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
