using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BoxMove : MonoBehaviour {
    float jumbotime,back,speed=0f,time_count;
    Vector3 offset;
    private int sum=0;
    public Text text,overmessage;
    private bool jumbo=false,boost=false,faster=true;
    private AudioSource crushsound;
    private Rigidbody rigid;
    public Slider slider;
    public Button button;
    public AudioClip[] a;
    float time=0;
    void Start() {
        text.text = "Score : " + sum.ToString();
    }
    void Awake() {
        crushsound = GetComponent<AudioSource>();
        rigid = GetComponent<Rigidbody>();
        button.enabled = false;
    }
    void Update() {
        if ( sum < 0 )
        {
            overmessage.text = "Game Over";
            time+=Time.deltaTime;
            if ( time > 1.5f )
            {
                Application.LoadLevel( "Start" );
            }
        }
        GameObject.Find( "InputManager" ).SendMessage( "aboutsum", sum );
        if ( transform.position.z < -4.9f )
        {
            Vector3 vec= this.transform.position;
            vec.z = ( -5f );
            transform.position = vec;
        }
        if ( transform.position.z > 5.5f )
        {
            Vector3 vec= this.transform.position;
            vec.z = 5.5f;
            transform.position = vec;
        }
        if ( !boost )
        {
            slider.value += ( Time.deltaTime * 1.1f );
        }
        if ( slider.value == slider.maxValue )
        {
            boost = true;
            if ( Input.GetKey( KeyCode.Space ) )
            {
                faster = false;
                button.enabled = false;
            }
        }
        if ( faster == true && boost == true )
            button.enabled = true;
        if ( !faster )
        {
            slider.value -= 0.12f;
            speed = 15f;
            Debug.Log( speed );

            if ( slider.value == slider.minValue )
            {
                boost = false;
                faster = true;
            }

        }

        if ( !jumbo&&!(sum<0) )
            driving();
        else if ( jumbo )
            JumboPower();
    }
    public void Button()
    {
        faster = false;
        button.enabled = false;

    }
    void JumboPower()
    {
        speed = 2f;
        offset = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.right * 2,
              speed * Time.deltaTime );
        this.transform.position = offset;
        jumbotime += Time.deltaTime;
        if ( jumbotime > 2.0f )
        {
            jumbo = false;
            jumbotime = 0f;
        }
    }

    public void OnTriggerEnter( Collider col )
    {

        if ( col.transform.tag == "Normal" )
        {
            sum += 10;
            text.text = "Score : " + sum.ToString();
            crushsound.Play();
            crushsound.clip = a[1];
        }
        else if ( col.transform.tag == "Red" )
        {
            sum += 20;
            text.text = "Score : " + sum.ToString();
            crushsound.Play();
            crushsound.clip = a[1];
        }
        else if ( col.transform.tag == "Jumbo" )
        {
            sum -= 30;
            text.text = "Score : " + sum.ToString();
            jumbo = true;
            crushsound.Play();
            crushsound.clip = a[0];
        }
        else if ( col.transform.tag == "Fast" )
        {
            sum -= 50;
            text.text = "Score : " + sum.ToString();
            jumbo = true;
            crushsound.Play();
            crushsound.clip = a[0];
        }
        else if ( col.transform.tag == "Slow" )
        {
            sum += 20;
            text.text = "Score : " + sum.ToString();
            crushsound.Play();
            crushsound.clip = a[1];
        }
    }
    public void driving()
    {
                speed += 0.5f;
                offset = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.right * 4,
            speed * Time.deltaTime );
                this.transform.position = offset;
                if ( speed >= 8f )
                    speed = 7f;
    }
    public void Left()
    {
        if ( !(sum < 0) )
        {
            offset = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.forward * 4,
            15f * Time.deltaTime );
            this.transform.position = offset;
        }
    }
    public void Right()
    {
        if ( !(sum < 0) )
        {

            offset = Vector3.Lerp( this.transform.position, this.transform.position + Vector3.back * 4,
            15f * Time.deltaTime );
            this.transform.position = offset;
        }
    }
    
}