using Godot;

public partial class SceneB : Node
{
	public override void _Ready()
	{
		GD.PrintS("In SceneB._Ready():", new { this.GetTree().CurrentScene });
		GD.PrintS("Now quitting...");
		GetTree().Quit();
	}
}
