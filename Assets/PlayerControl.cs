using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float PlayerSpeed = 1;
    public Vector3 position;

void Update () {
        float yPosition = gameObject.transform.position.y + (Input.GetAxis("Vertical") * PlayerSpeed);
        position = new Vector3(-10, Mathf.Clamp(yPosition, -4, 4),0);
        gameObject.transform.position = position;	
	}
}
