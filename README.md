#  Rotating Cube - Unity C# Learning Project

##  Description
A simple Unity project featuring a 3D cube that rotates continuously. This project demonstrates fundamental Unity concepts including GameObjects, transforms, the Update loop, and optional color transitions.

##  Learning Objectives
- Understanding Unity's MonoBehaviour lifecycle (`Start()`, `Update()`)
- Working with transforms and rotation
- Using `Time.deltaTime` for frame-independent movement
- Accessing and modifying components (Renderer)
- Using Unity's Inspector to expose public variables

##  Unity Version
Unity 2022.3 LTS (or compatible version)

##  How to Set Up

### Step 1: Create a New Unity Project
1. Open Unity Hub
2. Click **"New Project"**
3. Select **"3D (URP)"** or **"3D"** template
4. Name it: `RotatingCube-Project`
5. Click **"Create"**

### Step 2: Create the Cube
1. In Unity, right-click in the **Hierarchy** window
2. Select **3D Object → Cube**
3. The cube appears at position (0, 0, 0)

### Step 3: Add the Script
1. In the **Project** window, right-click in **Assets**
2. Create a folder named **"Scripts"**
3. Right-click the Scripts folder → **Create → C# Script**
4. Name it: `RotatingCube`
5. Copy the script code from the artifact above
6. Drag the script onto the Cube in the Hierarchy

### Step 4: Configure Settings
1. Select the Cube in the Hierarchy
2. Look at the **Inspector** window
3. You'll see the **RotatingCube** component with these settings:
   - **Rotation Speed**: Controls rotation speed (try 50)
   - **Rotation Axis**: Which axis to rotate around (default: Y-axis)
   - **Change Color**: Enable to see color transitions
   - **Color Change Speed**: How fast colors change

### Step 5: Run the Project
1. Click the **Play** button at the top of the Unity Editor
2. Watch your cube rotate!
3. Try adjusting values in the Inspector while playing (changes revert when you stop)

##  Code Explanation

### Key Concepts

**MonoBehaviour Lifecycle:**
```csharp
void Start()    // Called once when the object is created
void Update()   // Called every frame (60+ times per second)
```

**Transform Rotation:**
```csharp
transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
```
- `transform`: The position, rotation, and scale of the GameObject
- `rotationAxis`: Direction to rotate (Vector3.up = Y-axis)
- `Time.deltaTime`: Time since last frame (ensures smooth, frame-independent rotation)

**Component Access:**
```csharp
cubeRenderer = GetComponent<Renderer>();
```
- Gets the Renderer component attached to the same GameObject
- Allows us to modify the cube's appearance

**Inspector Variables:**
```csharp
[Header("Rotation Settings")]
public float rotationSpeed = 50f;
```
- `public` variables appear in the Unity Inspector
- `[Header]` adds organized sections
- `[Tooltip]` adds helpful descriptions when hovering

##  Customization Ideas

### Easy Modifications:
1. **Change rotation speed**: Set `rotationSpeed` to different values (10, 100, 200)
2. **Change rotation axis**: 
   - X-axis: `(1, 0, 0)`
   - Y-axis: `(0, 1, 0)`
   - Z-axis: `(0, 0, 1)`
   - Diagonal: `(1, 1, 0)`
3. **Enable color changing**: Check the "Change Color" box
4. **Adjust color speed**: Modify `colorChangeSpeed`

### Advanced Challenges:
- Add keyboard input to control rotation speed
- Make the cube move in a circle while rotating
- Add multiple cubes that rotate at different speeds
- Make the cube scale up and down over time

##  Troubleshooting

**Cube not rotating?**
- Make sure the script is attached to the Cube
- Check that `rotationSpeed` is not 0
- Look for errors in the Console window

**Colors not changing?**
- Enable "Change Color" checkbox in Inspector
- Make sure the cube has a material

**Script errors?**
- Check for typos in the code
- Make sure the script name matches the class name


## Notes
- Always save your scene: **File → Save Scene**
- Test frequently by clicking Play
- Experiment with different values
- Read Unity documentation when stuck

##  Reference Resources
- [Unity Learn](https://learn.unity.com/)
- [Unity Documentation](https://docs.unity3d.com/)
- [Unity Scripting API](https://docs.unity3d.com/ScriptReference/)

---

**Created as part of:** C# Learning Phase 1  
**Date:** December 2025  
**Tag:** #cl-csharp-learnp1
