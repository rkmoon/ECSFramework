using Raylib_cs;

public class RenderComponent : IComponent
{
    public Color Color;

    public RenderComponent(Color color)
    {
        Color = color;
    }
}
