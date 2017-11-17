using UnityEngine;
using UnityEngine.SceneManagement;

public class BallToForce : MonoBehaviour
{
    public void ClickBtn(string ballselect)
    {
        Player.getBall = ballselect;
        if (int.Parse(ballselect) < 20) {
            Player.level = "3ptlinePos";
        }
        Debug.Log("Select ball" + Player.getBall);
        SceneManager.LoadScene("Force");
    }
}
