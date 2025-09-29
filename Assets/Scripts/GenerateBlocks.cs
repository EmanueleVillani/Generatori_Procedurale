using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] bool isDebugging;
    void Start()
    {
        isDebugging = Application.isEditor && isDebugging;
        if (!isDebugging)
        {
            Instantiate(blockPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
