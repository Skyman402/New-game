
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public float speedRigtLeft;
    public FixedJoystick joystick;
    private int health = 100;
    public Text health_state;

    void Start()
    {
        print("Start life - " + health);
        health_state.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime,0,-(joystick.Direction.x * speedRigtLeft * Time.deltaTime));
    }
    public void updateheath(int damage)
    {
        health += damage;
        print("Current life - " + health);
        health_state.text = health.ToString();
        isAlive();
    }
    private void isAlive()
    {
        if (health <= 0)
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
    }
}
