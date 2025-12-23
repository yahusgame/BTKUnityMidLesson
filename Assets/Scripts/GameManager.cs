using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;
    public float delay;
    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        Debug.Log("GameManager is awake.");
    }
    // Start is called before the first frame update
    void Start()
    {
        print("GameManager has started.");
        Invoke("InvokeExample", delay); // Call InvokeExample after 2 seconds
        InvokeRepeating("InvokeRepeatingExample", delay, 5f); // Call InvokeExample after 2 seconds, then repeat every 5 seconds
        InvokeRepeating("TimeUpdate", 1f, 1f); // Call TimeUpdate every second
        StartCoroutine(RoutineFNC());
        StartCoroutine(AlwaysRouitine());
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

    // Update is called once per frame
    // we can use Update to handle game logic that needs to be checked every frame example, player input, AI behavior, etc.
    void Update()
    {
        Debug.Log("GameManager is updating.");
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            TimeUpdateStopped();
        }
    }


    // FixedUpdate is called at a fixed interval and is independent of frame rate. It is often used for physics calculations.
    // we can use FixedUpdate to apply consistent physics forces to a character or object.
    private void FixedUpdate()
    {
        Debug.Log("GameManager FixedUpdate called.");
    }

    // LateUpdate is called after all Update functions have been called. It is often used to follow up on calculations made in Update.
    // we can use LateUpdate to adjust camera position after all character movements have been processed in Update.
    private void LateUpdate()
    {
        Debug.Log("GameManager LateUpdate called.");
    }

    //Invoke is used to call a method after a specified delay.
    // we can use Invoke to trigger a power-up effect after a delay.
    private void InvokeExample()
    {
        Debug.Log($"InvokeExample method called after {delay}s.");
    }

    private void InvokeRepeatingExample()
    {
        Debug.Log("InvokeRepeatingExample method called.");
    }

    // TimeUpdate is called every second to demonstrate InvokeRepeating
    int time = 0;
    private void TimeUpdate()
    {
        time++;
        Debug.Log($"TimeUpdate called {time} times.");
    }

    private void TimeUpdateStopped()
    {
        CancelInvoke("TimeUpdate");
        Debug.Log("TimeUpdate has been stopped.");
    }

    IEnumerator RoutineFNC() {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Corouitine Started. Step:" + i);
            yield return new WaitForSeconds(1f); //wait a seconds for every steps 
        }
    }

    IEnumerator AlwaysRouitine()
    {
        while (true)
        {
            Debug.Log("AlwaysRouitine");
            yield return new WaitForSeconds(1f);
        }
    }
}
