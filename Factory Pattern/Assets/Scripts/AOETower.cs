/*
 * (Jacob Welch)
 * (AOETower)
 * (Factory Pattern)
 * (Description: Handles the funcitonality of an AOE tower.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOETower : Tower
{
    #region Functions
    /// <summary>
    /// Sets the sprite of the spriterenderer for the tower.
    /// </summary>
    protected override void SetSprite()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("AOE Tower");
    }
    #endregion
}
