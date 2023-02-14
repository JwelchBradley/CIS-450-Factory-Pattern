/*
 * (Jacob Welch)
 * (TowerPurchaser)
 * (Factory Pattern)
 * (Description: Handles the UI+events of purchasing towers.)
 */
using UnityEngine;

public class TowerPurchaser : MonoBehaviour
{
    #region Fields
    /// <summary>
    /// The scenes instance of the tower purchaser.
    /// </summary>
    private static TowerPurchaser instance;

    /// <summary>
    /// The current slot that is trying to purchase a tower.
    /// </summary>
    private TowerSlot currentSlot;
    #endregion

    #region Functions
    /// <summary>
    /// Handles initilization of components and other fields before anything else.
    /// </summary>
    private void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Opens the UI for purchasing towers.
    /// </summary>
    /// <param name="slot">The current slot calling for the UI to be opened.</param>
    public static void OpenTowerPurchaser(TowerSlot slot)
    {
        if (instance == null) return;

        instance.gameObject.SetActive(true);
        instance.currentSlot = slot;
    }

    /// <summary>
    /// Returns true if the UI for purchasing towers is open.
    /// </summary>
    /// <returns></returns>
    public static bool IsOpen()
    {
        return instance.gameObject.activeInHierarchy;
    }
    
    /// <summary>
    /// Purchases a desired tower.
    /// </summary>
    /// <param name="name">The name of the tower to be purchased.</param>
    public void PurchaseTower(string name)
    {
        if (currentSlot == null) return;

        currentSlot.SetTower(TowerFactory.MakeTower(name));
        gameObject.SetActive(false);
    }
    #endregion
}
