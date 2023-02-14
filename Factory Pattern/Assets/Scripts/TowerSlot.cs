/*
 * (Jacob Welch)
 * (TowerSlot)
 * (Factory Pattern)
 * (Description: Handles the locations that towers can be placed at.)
 */
using UnityEngine;

public class TowerSlot : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The current tower that is on the tower slot.
    /// </summary>
    private Tower currentTower;

    /// <summary>
    /// The sprite renderer of the tower slot.
    /// </summary>
    private SpriteRenderer sr;
    #endregion

    #region Functions
    /// <summary>
    /// Handles initilization of components and other fields before anything else.
    /// </summary>
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    #region Input
    /// <summary>
    /// Handles the start of hover events.
    /// </summary>
    private void OnMouseEnter()
    {
        if (CantSetTowerHere()) return;

        UpdateColor(0.5f);
    }

    /// <summary>
    /// Handles the end of hover events.
    /// </summary>
    private void OnMouseExit()
    {
        if (CantSetTowerHere()) return;

        UpdateColor(1.0f);
    }

    /// <summary>
    /// Handles the clicking to place towers.
    /// </summary>
    private void OnMouseUp()
    {
        if (CantSetTowerHere()) return;

        TowerPurchaser.OpenTowerPurchaser(this);
    }

    /// <summary>
    /// Handles the removal of towers.
    /// </summary>
    private void OnMouseOver()
    {
        if (currentTower == null || TowerPurchaser.IsOpen()) return;

        if (Input.GetMouseButtonDown(1))
        {
            DestroyImmediate(currentTower.gameObject);
            currentTower = null;
            UpdateColor(0.5f);
        }
    }
    #endregion

    /// <summary>
    /// Returns true if towers can not currently be placed on this slot.
    /// </summary>
    /// <returns></returns>
    private bool CantSetTowerHere()
    {
        return currentTower != null || TowerPurchaser.IsOpen();
    }

    /// <summary>
    /// Updates the color of the tower slot.
    /// </summary>
    /// <param name="newAlphaValue">The alpha value to set the tower slot to.</param>
    private void UpdateColor(float newAlphaValue)
    {
        var color = sr.color;
        color.a = newAlphaValue;
        sr.color = color;
    }

    /// <summary>
    /// Sets the tower that is on the tower slot.
    /// </summary>
    /// <param name="newTower">The tower that has been placed on the slot.</param>
    public void SetTower(Tower newTower)
    {
        currentTower = newTower;

        if(newTower != null)
        {
            currentTower.transform.position = transform.position;
            currentTower.ScaleToFit(transform.localScale);
            UpdateColor(1.0f);
        }
    }
    #endregion
}
