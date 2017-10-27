using UnityEngine;
using System.Collections;

public class selfdie : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }

    public void OnTriggerExit( Collider other )
    {
        if ( other.transform.tag == "Player" )
        {
            Destroy(this.gameObject);
        }
    }
}
