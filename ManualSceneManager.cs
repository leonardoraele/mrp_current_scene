using Godot;

public partial class ManualSceneManager : Node
{
    public void ChangeToSceneB()
    {
        // Remove & free current scene
        Node currentScene = GetTree().CurrentScene;
        currentScene.GetParent().RemoveChild(currentScene);
        currentScene.Free();

        // Load SceneB
        Node sceneB = ResourceLoader.Load<PackedScene>("res://scene_b.tscn").Instantiate();

        // Change to SceneB
        GetTree().CurrentScene = sceneB; // Error: Condition "p_scene && p_scene->get_parent() != root" is true.
                                         //   <C++ Source>   scene/main/scene_tree.cpp:1399 @ set_current_scene()
        GetTree().Root.AddChild(sceneB);
        GetTree().CurrentScene = sceneB; // Here, the assignment is allowed without errors, but SceneB._EnterTree()
                                         // and SceneB._Ready() have already been called while
                                         // GetTree().CurrentScene was null.
    }
}
