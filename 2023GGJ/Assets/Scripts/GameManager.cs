using UnityEngine;

// Attach to GameManager object
public class GameManager : MonoBehaviour
{
    // Singleton
    private static GameManager _instance;
    public static GameManager Instance{ get {return _instance; }}
    
    private void Awake() 
    {
        if(_instance == null || _instance == this)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    // Trigger States
    // Electricity State
    public bool electricityOn = true;
    // Other trigger states
    public bool fanTriggerOn = true;
    public bool cigarBox = false;
    public bool cabinet = false;
    public bool smokeDetected = false;
    public bool mop = false;
    public bool painting = false;

    // Boolean values to control scene on/off
    public bool isPastSceneOn = true;
    public bool isFutureSceneOn = false;
    
    // Scene masks
    [SerializeField] private SpriteRenderer pastSceneMask;
    [SerializeField] private SpriteRenderer futureSceneMask;
    
    // Switch to the future scene
    public void SwitchToFutureScene()
    {
        isFutureSceneOn = true;
        isPastSceneOn = false;
        futureSceneMask.enabled = false;
        pastSceneMask.enabled = true;
    }

}
