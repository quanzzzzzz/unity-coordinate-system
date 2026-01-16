using UnityEngine;

public class SimpleGame : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Debug.Log("Game Started");
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            ChangeColor();
            Debug.Log("Screen Touched");
        }
        if (Input.GetMouseButtonDown(0))
        {
            ChangeColor();
            Debug.Log("Mouse Clicked");
        }
        if (Input.touchCount == 2)
        {
            Debug.LogWarning("WARNING: About to create error");
            CreateError();
        }
    }


    void ChangeColor()
    {
        sr.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        Debug.Log("Player color changed");
    }

    void CreateError()
    {
        Debug.LogError("ERROR: This is a forced error!");
        GameObject obj = null;
        obj.transform.position = Vector3.zero;
    }

}
