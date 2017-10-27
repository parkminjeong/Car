using UnityEngine;
using System.Collections;

public class RoadManager : MonoBehaviour
{
    public GameObject Road1,Road2,Road3,line2,manager,player;
    int num;
    public string state;
    void Start()
    {
    }
    void Update()
    {
        num= Random.Range( 0, 3 );
    }
    public void OnTriggerEnter( Collider col )
    {
        if ( col.transform.tag == "Player" )
        {
            if ( num == 0 )
            {
                var position=line2.transform.position;
                position.x += 40f;
                Instantiate( manager, position, this.transform.rotation );
                position.y += 0.1f;
                Instantiate( Road1, position, transform.rotation );
            }
            else if ( num == 1 )
            {
                var position=line2.transform.position;
                position.x += 18f;
                position.y -= 0.3f;
                Instantiate( Road2, position, transform.rotation );
                position.x += 22f;
                position.y += 0.3f;
                Instantiate( manager, position, this.transform.rotation );
             }
            else
            {
                var position=line2.transform.position;
                position.x += 40f;
                Instantiate( manager, position, this.transform.rotation );
                Instantiate( Road3, position, Road3.transform.rotation );
            }

        }
    }
}
