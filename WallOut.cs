using UnityEngine;
using System.Collections;

public class WallOut : MonoBehaviour
{
    public GameObject player,manager,Line2;
    public GameObject outwall,outwall_2;
    float distance;
    int i;
    Vector3 temp;
    // Use this for initialization
    void Start()
    {         //나는 라인이당

    }
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
         i=Random.Range(0,2);
    }
   
    public void OnTriggerEnter( Collider col )
    {

        if ( col.transform.tag == "Player" )
        {
            var position=Line2.transform.position;

            if ( i == 1 )
            {           position.x += 13f;
                Instantiate( outwall, position, outwall.transform.rotation );
                distance = Vector3.Distance( this.transform.position, manager.transform.position );
                position.x += 18f;
                Instantiate( manager, position, manager.transform.rotation );
            }
            else
            {
                position.x +=30f;
                Instantiate( outwall_2, position, outwall_2.transform.rotation );
                Instantiate( manager, position, manager.transform.rotation );
            }

        }
    }
    
}
