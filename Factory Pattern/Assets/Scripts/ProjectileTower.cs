/*
 * (Jacob Welch)
 * (ProjectileTower)
 * (Factory Pattern)
 * (Description: Handles the functionality of a projectile tower.)
 */
using UnityEngine;

public class ProjectileTower : Tower
{
    #region Functions
    /// <summary>
    /// Sets the sprite of the spriterenderer for the tower.
    /// </summary>
    protected override void SetSprite()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("Projectile Tower");
    }
    #endregion
}
