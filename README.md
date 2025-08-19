# Endless Runner Game

An **endless runner** built in Unity.  
The player moves forward automatically and can switch lanes or jump to avoid obstacles with **three actions**:
- **Arrow Up (↑):** Move lane up
- **Arrow Down (↓):** Move lane down
- **Space:** Jump

The player collects **Rewards** (3D object made in Blender) and sees **Game Over** / **Congratulations** screens with a custom logo.

---

## 🎮 Features
- Constant forward movement.
- ≥20 obstacle prefabs (ground & air).
- Collectible **Rewards** with **UI counter**.
- **Game Over** & **Congratulations** screens with logo and Restart button.
- **Animations:** running, lane switching, jumping, death.
- **Audio:** SFX (jump / collect / hit) + custom music track ≥1′ (Audacity mix with 2 melodies and an intro narration).
- **Scripts:** `PlayerController`, `GameManager`, `ObstacleSpawner`, `FinishTrigger`.

---

## ⌨️ Controls
- **↑ (Arrow Up):** Move lane up  
- **↓ (Arrow Down):** Move lane down  
- **Space:** Jump  

---

## 🛠️ Technologies
- Unity (see `ProjectSettings/ProjectVersion.txt` for exact version)
- C# Scripts
- Blender (Reward 3D object)
- Audacity (music & SFX)
- Photoshop/GIMP (logo)

---

## 📂 Project Structure
Assets/ # Unity assets (scripts, scenes, prefabs, models, audio, sprites)
Packages/ # Unity packages
ProjectSettings/ # Unity project settings
SourceAssets/ # Original sources (Blender .blend, Audacity .aup3, Logo .psd/.png)
README.md

---

## 🚀 Run the Project
1. Clone the repository.
2. Open the project in the Unity version specified in `ProjectSettings/ProjectVersion.txt`.
3. Open the scene **`Assets/Scenes/Main.unity`**.
4. Press **Play** or create a build (**File → Build Settings → PC/Mac/Linux**).

---

## 🎥 Demo Video
Check out the demo here: [demo.mp4](demo.mp4)

---

## 📜 Credits
- **3D Reward:** Created in Blender.
- **Music & SFX:** Produced in Audacity (≥1′, 2 melodies + intro narration).
- **Logo/UI:** Designed in Photoshop/GIMP.


