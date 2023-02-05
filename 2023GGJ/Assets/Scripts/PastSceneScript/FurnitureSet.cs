using UnityEngine;

// No need to attach to any object
public abstract class FurnitureSet : MonoBehaviour
{
    // Game manager
    protected GameManager gameManager;
    
    // Used to check if the object need to detect the key input
    protected bool isDetectKeyInput;
    // SpriteRenderer of the "E" symbol 
    protected SpriteRenderer markE;
    
    // If a furniture is used, it will never be triggered again
    protected bool hasUsed = false;

    private void Start()
    {
        gameManager = GameManager.Instance;
        
        var markObject = gameObject.transform.Find("MarkE");
        markE = markObject.gameObject.GetComponent<SpriteRenderer>();
        if (markE != null) return;
        Debug.Log("No mark object detected");

    }

    private void Update()
    {
        if (hasUsed) return;
        if (!isDetectKeyInput) return;
        if (Input.GetKey(KeyCode.E))
        {
            markE.enabled = false;
            SetTrap();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (hasUsed) return;
        if (!col.gameObject.CompareTag("Player")) return;
        markE.enabled = true;
        isDetectKeyInput = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (hasUsed) return;
        if (!col.gameObject.CompareTag("Player")) return;
        markE.enabled = false;
        isDetectKeyInput = false;
    }
    
    // Execute event based on furniture type
    protected abstract void SetTrap();
}
