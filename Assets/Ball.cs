using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed=4f;
    void borders()
    {
        if (Mathf.Abs(this.transform.position.x) >= 10f)
        {
            transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());

        }
       
     }
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
        StartCoroutine(Pause());
    }
	
	// Update is called once per frame
	void Update () {
        borders();

	
	}
    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);

        if(directionX == 0)
        {
            directionX = 1;
        }
        rb.velocity = new Vector2(0f, 0f);
    yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(6f * directionX,6f * directionY); 
    }
}
