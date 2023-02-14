/*
 * (Jacob Welch)
 * (TowerFactory)
 * (Factory Pattern)
 * (Description: A factory for making towers.)
 */
using UnityEngine;

public class TowerFactory : MonoBehaviour
{
    #region Functions
    /// <summary>
    /// Spawns a desired tower.
    /// </summary>
    /// <param name="towerType">The type of tower to be spawned.</param>
    /// <returns></returns>
    public static Tower MakeTower(string towerType)
    {
        Tower tower = null;
        var towerObject = new GameObject(towerType + " Tower");

        switch (towerType)
        {
            case "AOE":
                tower = towerObject.AddComponent<AOETower>();
                break;
            case "Beam":
                tower = towerObject.AddComponent<BeamTower>();
                break;
            case "Projectile":
                tower = towerObject.AddComponent<ProjectileTower>();
                break;
            default:
                print("Tower Type Not Found");
                DestroyImmediate(towerObject);
                break;
        }

        return tower;
    }
    #endregion
}
