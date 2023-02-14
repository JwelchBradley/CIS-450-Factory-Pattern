/*
 * (Jacob Welch)
 * (BeamTower)
 * (Factory Pattern)
 * (Description: Handles the funcitonality of a beam tower.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamTower : Tower
{
    #region Functions
    /// <summary>
    /// Sets the sprite of the spriterenderer for the tower.
    /// </summary>
    protected override void SetSprite()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("Beam Tower");
    }
    #endregion
}
