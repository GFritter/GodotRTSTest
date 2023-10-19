using Godot;
using System;

public partial class BasicEntity : AnimatedSprite2D
{
	// Called when the node enters the scene tree for the first time.

	[Export]
	Sprite2D selectedIndicator;
	[Export]
	bool selected;

	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
