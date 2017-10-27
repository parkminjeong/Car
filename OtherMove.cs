using UnityEngine;
using System.Collections;

public class OtherMove : MonoBehaviour {
    public GameObject other,red,jumbo;
    public GameObject cop,amb,bus,truck,fire,van;
    public GameObject player;
    float waittime=0.5f;
    int sum2;
    int ver=4;

    // Use this for initialization
    void Start () {
        StartCoroutine( Creation() );
    }
    void Update() {
        if ( sum2 > 70 )
        {
            ver = 10;
        }else if ( sum2 < 0 )
        {
            Destroy( this );
        }
    }
    public void aboutsum( int sum )
    {
        sum2 = sum;
    }
    IEnumerator Creation()
    {
        while ( true )
        {
            for ( int i = 0 ; i < ver ; i++ )
            {
                Vector3 temp=player.transform.position;
                temp.y = 0f;
                yield return new WaitForSeconds( waittime );
                if ( i == 0|| i == 3 || i == 5|| i == 8  )
                {
                    var position = new Vector3(Random.Range(temp.x+100f,temp.x+110f), 0.34f, Random.Range(-5.5f,5.5f));
                    Instantiate( other, position, other.transform.rotation );
                }
                else if ( i == 2|| i == 6 )
                {
                    var redposition = new Vector3(temp.x+100f, 0.34f, Random.Range(-5.5f,5.5f));
                    Instantiate( red, redposition, red.transform.rotation );
                }
                else if ( i == 1|| i == 8)
                {
                    var jumboposi = new Vector3(temp.x+100f, 0.03f, Random.Range(-5.5f,5.5f));
                    Instantiate( jumbo, jumboposi, jumbo.transform.rotation );
                }
                else if ( i == 5 || i ==8 || i == 7 )
                {
                    var position_ = new Vector3(Random.Range(temp.x+100f,temp.x+110f), -0.1f, Random.Range(-5.5f,5.5f));
                    Instantiate( van, position_, van.transform.rotation );
                }
                if ( i == 8 || i == 5 || i == 6 )
                {
                    var redposition = new Vector3(temp.x+100f, -0.1f, Random.Range(-5.5f,5.5f));
                    Instantiate( cop, redposition, cop.transform.rotation );
                }
                else if ( i == 6 || i == 9 )
                {
                    var redposition = new Vector3(temp.x+100f, -0.1f, Random.Range(-5.5f,5.5f));
                    Instantiate( bus, redposition, bus.transform.rotation );
                }
                else if ( i == 4 || i == 7 )
                {
                    var redposition = new Vector3(temp.x+100f, -0.1f, Random.Range(-5.5f,5.5f));
                    Instantiate( fire, redposition, fire.transform.rotation );
                }
                else if ( i == 9 || i == 6 )
                {
                    var redposition = new Vector3(temp.x+100f, -0.1f, Random.Range(-5.5f,5.5f));
                    Instantiate( truck, redposition, truck.transform.rotation );
                }
                else if ( i == 6 || i == 4 )
                {
                    var redposition = new Vector3(temp.x+100f, -0.1f, Random.Range(-5.5f,5.5f));
                    Instantiate( amb, redposition, amb.transform.rotation );
                }
            }
        }
    }
}
