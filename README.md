# GameObject Actions by a Non-MonoBehaviour Class

## Quick Facts
- Purpose: show how to keep Unity scene wiring in a MonoBehaviour while moving gameplay logic into a plain C# class.
- Main idea: pass only the Transform dependency into the logic class.
- Audience: beginners learning how Unity scripts and regular C# classes work together.
- Series context: this is Project 1 in a three-repository Unity learning series.
- Teaching use: designed as a teaching tool for the Unity Joystick Robot Simulation lessons.

## What You Get
- A simple movement example split into two scripts.
- A practical Initialize pattern for dependency setup.
- A beginner-focused explanation of common confusion points.

## Quick Start
1. Open a Unity project.
2. Copy scripts from Source/Examples into your project Scripts folder.
3. Add PlayerController to a GameObject in the scene.
4. Press Play and move with horizontal input.

## Controls
- Horizontal axis input (A/D, Left/Right, or controller stick).

## Project Notes
### Series context
This repository is the first Unity project in a sequence of three. The set is used to teach robot simulation concepts step by step, starting with core scripting patterns before moving to more advanced behaviors. The third project in the series — Unity Joystick Robot Simulation — is available for purchase on the Unity Asset Store. Purchasing it directly supports the ongoing open-source work at MageMCU and [Carpenter Software](https://carpentersoftware.com).

### Where this tip is currently applied
Current status across the Unity repos in this teaching series:

- GameObject-Actions-by-a-Non-Monobehaviour-Class: uses this tip.
- Unity-Camera-Overlay: does not currently use this tip.
- Unity Joystick Robot Simulation *(Unity Asset Store — coming soon)*: uses this tip.

This list helps first-time learners see which projects already use the MonoBehaviour + non-MonoBehaviour split pattern and which projects still use Unity-facing scripts only.

### Why this can be difficult for first-time Unity users
Mixing MonoBehaviour and non-MonoBehaviour programming is useful, but beginners often hit these issues:

- Lifecycle confusion: Unity calls Awake, Start, and Update only on MonoBehaviour scripts attached to scene objects. Plain C# classes do not receive these callbacks automatically.
- Instantiation confusion: MonoBehaviour scripts are managed by Unity, while plain classes are created with new. New users often expect both to behave the same way.
- Reference confusion: passing a GameObject exposes too much, passing only a Vector3 exposes too little, and understanding why Transform is the right middle ground takes practice.
- Timing issues: if Initialize is never called, or called too late, logic classes run with null references and appear "broken".
- Debugging split: behavior is now split across two files, so beginners must trace control flow from Update to logic methods.

### Practical rule for beginners
Keep Unity-facing responsibilities in MonoBehaviour (input, scene refs, lifecycle), and keep reusable gameplay rules in plain C# classes.

## Source Files
- Source/Examples/PlayerController.cs
- Source/Examples/Mover.cs
- Source/Examples/README.md

## Folder Guide
- Source/Examples: working scripts and a short example note.
- ref: reference-only files moved from the root.

## Release Notes
- Updated series context from four repositories to three following the release of Unity Joystick Robot Simulation on the Unity Asset Store.
- Added Source/Examples folder with runnable split-logic example.
- Updated README with first-time Unity beginner guidance.

## Updates
- June 2026: repository structure simplified, examples added, and series references updated.

## In Progress
- Add interface-based variant (for example, IMovable) to show stronger decoupling.

## License
See LICENSE.

## Contributing
Issues and PRs are welcome for clearer beginner examples and documentation improvements.
