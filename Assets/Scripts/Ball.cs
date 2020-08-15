using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField] Paddle paddle;
	[SerializeField] float ballDirection = 2f;
	[SerializeField] float ballVelocity = 10f;

	bool hasStarted = false;
	Vector2 ballToPaddleVector;
	
	   void Start()
	{
		ballToPaddleVector = new Vector2 (transform.position.x - paddle.transform.position.x, transform.position.y - paddle.transform.position.y);
	}

	void Update()
	{
		if (!hasStarted)
		{
			lockBallToPaddle();
			launchOnMouseClick();
		}
		



		if (Input.GetMouseButton(0))
			hasStarted = true;

		if (hasStarted)
			launchOnMouseClick();
		else
		lockBallToPaddle();

	}

	private void lockBallToPaddle()
	{
		Vector2 paddlePos = paddle.transform.position;
		transform.position = paddlePos + ballToPaddleVector;
	}

	private void launchOnMouseClick()
	{
		if (Input.GetMouseButtonDown(0))
			GetComponent<Rigidbody2D>().velocity = new Vector2(ballDirection, ballVelocity);
	}

}
