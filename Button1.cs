using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour
{
    private bool gogo;
    public GameObject Player;
    public float speed;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( gogo )
        {
            speed += 1f;
            offset = Vector3.Lerp( Player.transform.position, Player.transform.position + Vector3.right * 2,
        speed * Time.deltaTime );
            Player.transform.position = offset;
            if ( speed >= 8f )
                speed = 7f;
        }
    }
    void OnPress()
    {
        gogo = true;
    }
    void OnRelease()
    {
        gogo = false;
    }
}
