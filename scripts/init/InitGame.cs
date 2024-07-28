using Godot;

namespace Druid.scripts.init;

public partial class InitGame : Node
{
    [Export] public string ScenePath { get; private set; }

    public override void _Ready()
    {
        var scene = GD.Load<PackedScene>(ScenePath);
        AddChild(scene.Instantiate());
    }
}