#pragma strict

// Variable to store the enemy prefab
public var enemy : GameObject;
public var enemy2 : GameObject;

// Variable to know how fast we should create new enemies
public var spawnTime : float = 2;
public var spawnTime2 : float = 5;

function Start() {
    // Call the 'addEnemy' function in 0 second
    // Then every 'spawnTime' seconds
    InvokeRepeating("addEnemy", 0, spawnTime);
    InvokeRepeating("addEnemy2", 0, spawnTime2);
}

// New function to spawn an enemy
function addEnemy() {
    // Get the renderer component of the spawn object
    var rd = GetComponent(Renderer);

    // Position of the left edge of the spawn object
    // It's: (position of the center) minus (half the width)
    var x1 = transform.position.x - rd.bounds.size.x/2;

    // Same for the right edge
    var x2 = transform.position.x + rd.bounds.size.x/2;

    // Randomly pick a point within the spawn object
    var spawnPoint = Vector2(Random.Range(x1, x2), transform.position.y);

    // Create an enemy at the 'spawnPoint' position
    Instantiate(enemy, spawnPoint, Quaternion.identity);
} 

// New function to spawn an enemy
function addEnemy2() {
    // Get the renderer component of the spawn object
    var rd = GetComponent(Renderer);

    // Position of the left edge of the spawn object
    // It's: (position of the center) minus (half the width)
    var x1 = transform.position.x - rd.bounds.size.x/2;

    // Same for the right edge
    var x2 = transform.position.x + rd.bounds.size.x/2;

    // Randomly pick a point within the spawn object
    var spawnPoint = Vector2(Random.Range(x1, x2), transform.position.y);

    // Create an enemy at the 'spawnPoint' position
    Instantiate(enemy2, spawnPoint, Quaternion.identity);
} 