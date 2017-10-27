using UnityEngine;
using System.Collections;

public class BuildingLine : MonoBehaviour
{
    public GameObject player,b_line2,buildings;
    float distance=0f,dis=0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            distance = Vector3.Distance( this.transform.position, player.transform.position );
            if ( distance > 100f )
                Destroy( buildings );
    }

    public void OnTriggerEnter( Collider col )
    {
        if ( col.transform.tag == "Player" )
        {
            dis = Vector3.Distance( this.transform.position, b_line2.transform.position );
            var position = buildings.transform.position;
            position.x += dis;
            Instantiate( buildings, position, buildings.transform.rotation );
        }
    }
    
}
