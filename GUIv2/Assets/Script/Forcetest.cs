using UnityEngine;
using UnityEngine.SceneManagement;

public class Forcetest : MonoBehaviour
{
    public void OnClickButton(string ForceSelect)
    {
        Player.getForce = ForceSelect;
        Player.isShoot = true;
        Debug.Log("Ball " + Player.getBall + ", Force " + Player.getForce);
        SceneManager.LoadScene(Player.level);
    }
}
