using System;
using System.Collections.Generic;

public class TextUpdateSystem : ISystem
{
    public delegate string TextUpdateDelegate(List<Entity> entities);

    private TextUpdateDelegate _textUpdate;

    public TextUpdateSystem(TextUpdateDelegate textUpdate)
    {
        _textUpdate = textUpdate;
    }

    public void Update(float deltaTime, List<Entity> entities)
    {
        foreach (Entity entity in entities)
        {
            TextRendererComponent textRenderer = entity.GetComponent<TextRendererComponent>();

            if (textRenderer != null)
            {
                textRenderer.Text = _textUpdate(entities);
            }
        }
    }
}
