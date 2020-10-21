# FlappyCrow
Клон игры Flappy Bird

![Стартовый экран](desc/main.png) 
![Стартовый экран](desc/in_game.png) 

## Геймплей
![Стартовый экран](desc/main.gif)
![Стартовый экран](desc/gameplay.gif)

## Фрагменты кода

### Спавн преград
```csharp
public class TreesSpawn : MonoBehaviour
{
    public float maxTime = 1;
    public GameObject trees;
    private float timer = 0;
    public float height; 

    void Start()
    {
        GameObject newtrees = Instantiate(trees);
        newtrees.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newtrees, 5);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newtrees = Instantiate(trees);
            newtrees.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newtrees, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
} 
```

### Случайная смена фона в начале игры
```csharp
    private void Start()
    {
        Time.timeScale = 0;

        if(Random.Range(0, 100) > 50)
        {
            nightBackground.SetActive(true);
            dayBackground.SetActive(false);
        }
        else
        {
            dayBackground.SetActive(true);
            nightBackground.SetActive(false);
        }
    }
```

### Полёт птицы
```csharp
public class Fly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        gameManager.GameOver();
    }
}
```

