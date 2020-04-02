using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
	float mouseXPoisition, mouseYPosition;
	[SerializeField] float screenWidthInUnits= 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(Input.anyKeyDown.ToString());
		mouseXPoisition = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		mouseYPosition = transform.position.y;
		Vector2 paddlePosition = new Vector2(mouseXPoisition,mouseYPosition);
		transform.position = paddlePosition;

    }
}
