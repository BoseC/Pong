using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed=4f;
    void borders()
    {
        if (this.transform.position >= (17f,0,0))
        {

        }

    }
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
    }
	
	// Update is called once per frame
	void Update () {
        

	
	}
}
