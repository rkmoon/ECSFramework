using Raylib_cs;
using System.Numerics;

public class TextRendererComponent : IComponent
{
    public string Text;
    public int FontSize;
    public Color FontColor;
    public Vector2 Position;

    public TextRendererComponent(string text, int fontSize, Color fontColor, Vector2 position)
    {
        Text = text;
        FontSize = fontSize;
        FontColor = fontColor;
        Position = position;
    }
}
