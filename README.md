# 🐦 Flappy_Bird_KN

A pixel-art inspired Flappy Bird clone built in Unity using C#.  
Relaxing to look at — challenging to play.
![Unity_jPCCGtGVV8](https://github.com/user-attachments/assets/c000fc63-6091-4382-a89b-79a3b414c9a3)

[image](https://github.com/user-attachments/assets/3adea47a-eddd-45d9-aeec-f020c0a5e4e9)



## 🎮 Game Summary

This is a simple yet functional 2D side-scrolling game where the player controls a cute bird that flaps through a series of randomly placed pipe obstacles. The bird stays fixed on the X-axis, while pipes and clouds scroll toward the left to create the illusion of movement.

The game includes:
- A **main menu** with animated background and Start button
- In-game **sound effects and music**
- A responsive **flap mechanic** and animated bird sprite
- Score tracking
- A **Game Over screen** with restart functionality

---

## 💡 Core Features & Concepts

This game was built entirely in Unity with custom C# scripting. Some of the key systems and logic:

### 🐤 Bird Mechanics
- Uses **Rigidbody2D** physics for realistic movement
- **`Input.GetKeyDown(KeyCode.Space)`** to flap upward
- **Dynamic sprite switching** depending on movement (up/down)
- **Bool flag (`birdIsAlive`)** used to control game flow
- Plays different **AudioSources** when jumping or hitting obstacles
- **`OnCollisionEnter2D`** triggers game over and sound effects

```csharp
if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
{
    myRigidbody.linearVelocity = Vector2.up * flapStrength;
    spriteRenderer.sprite = birdDownSprite;
    flapSound.Play();
}

🧠 Game Logic & UI
Score increases every time the bird passes between pipes

Game Over screen shown when collision is detected

Scene management via SceneManager.LoadScene(...)

Linking between scripts via GetComponent<> and GameObject.FindWithTag

🧱 Pipe Spawning
Pipes are spawned at random vertical positions every few seconds

Controlled using a timer and Random.Range

Spawned objects self-destruct after they leave the screen for optimization

csharp
Zkopírovat
Upravit
Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
🎵 Audio & Visual Polish
Audio clips added for jump and collision feedback

Animated background in the main menu (falling feathers to be added!)

Future plans: particle effects, interactive items (e.g. power-ups or collectibles)

📁 Project Structure
Scripts are neatly organized:

GameScripts/ — Core gameplay logic (Bird, Pipes, Logic)

MenuScripts/ — Menu, UI transitions, background animation

Scenes/ — MainMenu & GameScene

🚀 Tech Stack
Engine: Unity 2022+

Language: C#

Tools used: UnityEditor, Visual Studio Code

Source Control: Git + GitHub

📸 Media
📝 To be added soon:

Gameplay GIF and animated preview

Screenshots showing menu, gameplay, and Game Over state

  Author Notes
This is one of my first Unity games and I’m really proud of how it came out.
I explored a wide range of Unity features: animation, physics, collision detection, scene management, and sound. I focused on clean code, performance (like despawning), and smart logic flows using bools and conditionals.

This game is a part of my game development journey, and more exciting projects are coming! 
Thanks for checking it out :)
