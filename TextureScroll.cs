using UnityEngine;
using System.Collections;

public class TextureScroll : MonoBehaviour {
    public float speed=0.5f;
    private Material m_material;
	// Use this for initialization
	void Start () {
        m_material = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset=m_material.mainTextureOffset;
        offset.Set( 0, offset.y + ( speed * Time.deltaTime ) );
        m_material.mainTextureOffset = offset;
	}
}
