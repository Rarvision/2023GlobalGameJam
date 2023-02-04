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
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    // Boolean values to control scene on/off
    public bool isPastSceneOn = true;
    public bool isFutureSceneOn = false;
    
    // Scene masks
    [SerializeField] private SpriteRenderer pastSceneMask;
    [SerializeField] private SpriteRenderer futureSceneMask;
    
    // Switch between two scenes
    public void SwitchPastScene()
    {
        isPastSceneOn = !isPastSceneOn;
        pastSceneMask.enabled = !pastSceneMask.enabled;
    }
    
    // Switch between two scenes
    public void SwitchFutureScene()
    {
        isFutureSceneOn = !isFutureSceneOn;
        futureSceneMask.enabled = !futureSceneMask.enabled;
    }

    public void debugInfo()
    {
        Debug.Log("DEBUG INFO PRINTED");
    }

}
