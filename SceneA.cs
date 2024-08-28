using Godot;

public partial class SceneA : Node
{
	public override void _Ready()
	{
		GetTree().Root.GetNode("ManualSceneManager").CallDeferred(ManualSceneManager.MethodName.ChangeToSceneB);
	}
}
