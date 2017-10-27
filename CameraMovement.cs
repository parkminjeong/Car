using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public GameObject player;
    Vector3 temp=Vector3.zero;
	// Use this for initialization
	void Start () {
        player.GetComponent<GameObject>();
	}
    void Awake()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        temp = player.transform.position + new Vector3( -2f, 5f, 0 );
        Vector3 movehelper=Vector3.Lerp(transform.position,temp,100f*Time.deltaTime);
        this.transform.position = movehelper;
	}
}
