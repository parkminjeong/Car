using UnityEngine;
using System.Collections;

public class OtherMovement : MonoBehaviour {
    public GameObject myself;
    private GameObject player;
    public string CarTag;
    public string player_tag;
    private Rigidbody rigid;
    private bool crush=false;
    int sum2;
    void Start () {
        rigid = GetComponent<Rigidbody>();
	}
    public void aboutsum(int sum )
    {
        sum2 = sum;
    }
	void Update () {
        if ( sum2 < 0 )
        {
            Destroy( this );
        }
        myself = GameObject.FindGameObjectWithTag( CarTag );
        player = GameObject.FindGameObjectWithTag( player_tag );
        if ( crush == true )
        {
            Vector3 a=new Vector3(5f,2f,0);
            rigid.AddForce( a, ForceMode.Impulse );
            rigid.isKinematic = false;
            StartCoroutine( WaitForIt() );
        }
        if ( this.tag== "Normal" )
        {
            Vector3 moving = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.left * 3 ,
                2.4f * Time.deltaTime );
            this.transform.position = moving;
            if ( ( this.transform.position.x <  player.transform.position.x-4f ) )
            {
                Destroy( myself );
            }
        }
        else if(tag=="Red")
        {
            Vector3 moving = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.left * 4 ,
                3.5f * Time.deltaTime );
            this.transform.position = moving;
            if ( ( this.transform.position.x <  player.transform.position.x-4f  )  )
            {
                Destroy( myself );
            }
        }else if ( tag == "Jumbo" )
        {
            Vector3 moving = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.left * 4 ,
                1.3f * Time.deltaTime );
            this.transform.position = moving;
            if ( ( this.transform.position.x < player.transform.position.x - 4f ) )
            {
                Destroy( myself );
            }

        }
        if ( this.tag == "Fast" )
        {
            Vector3 moving = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.left * 4 ,
               3.7f * Time.deltaTime );
            this.transform.position = moving;
            if ( ( this.transform.position.x < player.transform.position.x - 4f ) )
            {
                Destroy( myself );
            }
        }
        if ( this.tag == "Slow" )
        {
            Vector3 moving = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.left *4f ,
                1.8f * Time.deltaTime );
            this.transform.position = moving;
            if ( ( this.transform.position.x < player.transform.position.x - 4f ) )
            {
                Destroy( myself );
            }
        }
    }
    void OnTriggerEnter(Collider col )
    {
        if ( col.transform.tag == "Player" )
        {
            crush = true;
            
        }
    }
    IEnumerator WaitForIt(){
                yield return new WaitForSeconds( 1.0f );
                Destroy( myself );

            }
   

}
