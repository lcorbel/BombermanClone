using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AnimatedSpriteRenderer spriteRendererStart;
    public AnimatedSpriteRenderer spriteRendererMiddle;
    public AnimatedSpriteRenderer spriteRendererEnd;

    public void SetActiveRenderer(AnimatedSpriteRenderer spriteRenderer)
    {
        spriteRendererStart.enabled = spriteRenderer == spriteRendererStart;
        spriteRendererMiddle.enabled = spriteRenderer == spriteRendererMiddle;
        spriteRendererEnd.enabled = spriteRenderer == spriteRendererEnd;
    }

    public void SetDirection(Vector2 direction)
    {
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.Rotate(0, 0, angle);
    }

}
