/*
 * (Jacob Welch)
 * (Tower)
 * (Factory Pattern)
 * (Description: A base class for all towers.)
 */
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The sprite renderer of the tower.
    /// </summary>
    protected SpriteRenderer spriteRenderer;

    /// <summary>
    /// The value used for properly scaling the tower.
    /// </summary>
    private const float SCALING_VALUE = 0.1f;
    #endregion

    #region Functions
    /// <summary>
    /// Initializes all components and values of the tower.
    /// </summary>
    protected virtual void Awake()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        SetSprite();
    }

    /// <summary>
    /// Sets the sprite of the spriterenderer for the tower.
    /// </summary>
    protected abstract void SetSprite();

    /// <summary>
    /// Scales the tower to fit the given tower slot.
    /// </summary>
    /// <param name="slotScale">The slot's scale</param>
    public virtual void ScaleToFit(Vector3 slotScale)
    {
        transform.localScale = slotScale * SCALING_VALUE;
    }
    #endregion
}
