using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
    private string sam;
    public GameObject player,ma;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float dis=Vector3.Distance(player.transform.position,this.transform.position);
        if ( dis > 120f )
        {
            Destroy( ma );
        }

	}
 
}
