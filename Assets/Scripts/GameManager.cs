using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;
    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        Debug.Log("GameManager is awake.");
    }
    // Start is called before the first frame update
    void Start()
    {
        print("GameManager has started.");
    }

    // Called when the object becomes enabled and active
    private void OnEnable() 
    {
        Debug.Log("GameManager is enabled.");
    }

    // Called when the behaviour becomes disabled or inactive
    private void OnDisable()
    {
        Debug.Log("GameManager is disabled.");

        foreach (var enemy in enemies)
        {
            Debug.Log(enemy.name);
        }
    }
}
