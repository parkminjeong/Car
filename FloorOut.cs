using UnityEngine;
using System.Collections;

public class FloorOut : MonoBehaviour
{
    float distance,distroy_dis;
    public GameObject floor,m_Line_2,player;

    // Use this for initialization
    void Start()
    {

    }
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distroy_dis = Vector3.Distance( this.transform.position, player.transform.position );
        if ( distroy_dis>100f )
        {
            Destroy( floor );
        }
    }

    public void OnTriggerExit( Collider col )
    {
        if(col.transform.tag=="Player"){
            distance = Vector3.Distance( this.transform.position, m_Line_2.transform.position );
   
            var position = new Vector3(player.transform.position.x+distance, 0, 0);

            Instantiate( floor, position, floor.transform.rotation );
        }
    }
    
}
