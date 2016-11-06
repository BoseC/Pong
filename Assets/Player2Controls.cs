using UnityEngine;
using System.Collections;

public class Player2Controls : MonoBehaviour {

    private Rigidbody2D rb2;
    public float speed = 5;
    void movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))        {
            rb2.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2.velocity = new Vector2(0f, -speed);

        }
        else
            rb2.velocity = new Vector2(0f, 0f);
    }

	// Use this for initialization
	void Start () {
    rb2 = this.GetComponent<Rigidbody2D>();
}
	
	// Update is called once per frame
	void Update () {
    movement();
	}

}
