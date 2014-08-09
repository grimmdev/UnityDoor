UnityDoor
=========

Let's go and make a door! In C#!

2014 Sean Loper
Grimmdev@gmail.com

The code that comes with this project is very well commented and documented, please refer to the code for explanation.

Want to use Unity's new 2D System instead of 3D? EASY! Follow these steps!
Open both the Door.cs file and Key.cs file and replace the following line of code on both

void OnTriggerStay (Collider other)

with

void OnTriggerStay2D (Collider other)

NOTES

You will need to set the player's Tag in Unity Editor to Player. (as seen in the demo scene provided)
