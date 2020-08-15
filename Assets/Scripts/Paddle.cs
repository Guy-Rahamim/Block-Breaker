using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{
	float mouseXPosition, mouseYPosition;
	[SerializeField] float min = 1f;
	[SerializeField] float max = 15f;
	[SerializeField] float screenWidthInUnits= 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		mouseXPosition = Mathf.Clamp(mousePosInUnits, min, max);
		mouseYPosition = transform.position.y;
		Vector2 paddlePosition = new Vector2(mouseXPosition,mouseYPosition);
		transform.position = paddlePosition;

    }
}
