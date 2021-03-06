# HW5: Leveling up Your Unity Skills

## Team Members:
* Kelsey Anderson
* Jesica Maria Ramirez Toscano

## Goals:

The primary learning goals of this lab are:
* Create jumping scripts and use gravity in Unity
* Create projectiles and learn instantiation of classes in C# and Unity
* Use global level variables to affect game play
* Reduce Marble health
* Reduce Obstacle Health
* Remove elements from the game as it is played
* Add text to screen
* Understand and use win/lose conditions in Unity

[More about the HW5](https://docs.google.com/document/u/1/d/e/2PACX-1vQTKAbtBLvtmtWqItUt3KYrw8a4aCy43U0P6jl6aQJofnuQfr-GJYuwHb-crgiq9NFeuDcdLTQW04Z4/pub)

## Implementation Notes:
* We added small white capsules for health repair. You must jump up a stepped structure to get them. They add 10 health back.
* We added two enemy objects that target the marble and will reduce it's health.
  * One large one that requires the Marble to come close to it to activate and reduces health by 20.
  * One small one that targets the Marble immediately and reduces health by 10.
  * Both can be destroyed by shooting twice with blasts.
* We modified the obstacle material so that the first time an obstale is hit, it appears to crack.
