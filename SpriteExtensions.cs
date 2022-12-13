using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpriteExtensions
{
    public static Texture2D ConvertToTexture(this Sprite sprite)
    {
        Texture2D texture = new((int)sprite.rect.width, (int)sprite.rect.height);
        texture.filterMode = FilterMode.Point;

        Color[] pixels = sprite.texture.GetPixels((int)sprite.rect.x,
                                                (int)sprite.rect.y,
                                                (int)sprite.rect.width,
                                                (int)sprite.rect.height);
        texture.SetPixels(pixels);
        texture.Apply();

        return texture;
    }
}
