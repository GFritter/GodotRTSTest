using Godot;
using System;

public partial class PlayerController : CharacterBody2D
{
	public float moveSpeed = 100.0f;
	public Vector2 moveDirection = new Vector2();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		moveDirection = Input.GetVector("moveLeft","moveRight","moveUp","moveDown");
		
		Velocity = moveDirection*moveSpeed;
		MoveAndSlide();


	}
}
