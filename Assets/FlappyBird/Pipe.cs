using UnityEngine;

public class Pipe : MonoBehaviour
{

    public float speed;
    public float restartPos;
    public float startPos;
    public float maxTop, maxBottom;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var pos = transform.localPosition;
        pos.y = Random.Range(maxTop, maxBottom);
        transform.localPosition = pos;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.localPosition;
        pos.x -= speed * Time.deltaTime;
        print(pos);
        if(pos.x < restartPos)
        {
            pos.x = startPos;
            pos.y = Random.Range(maxTop, maxBottom);
        }

        transform.localPosition= pos;
    }
}
