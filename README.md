# Game Engines 2 2019-2020

[![Video](http://img.youtube.com/vi/NMDupdv85FE/0.jpg)](http://www.youtube.com/watch?NMDupdv85FE)

## Teams links for classes:
- [Tuesday 9am lab](https://teams.microsoft.com/l/meetup-join/19%3ameeting_MzhhZmVhY2MtOWI5Ni00ZjExLTliYmMtZWJiZjhjYTVkYmY5%40thread.v2/0?context=%7b%22Tid%22%3a%22766317cb-e948-4e5f-8cec-dabc8e2fd5da%22%2c%22Oid%22%3a%2261aab78b-a857-4647-9668-83d4cca5de03%22%7d)
- [Thursday 11am Class](https://teams.microsoft.com/l/meetup-join/19%3ameeting_YjdhMGNhZDYtOTU4MC00YjViLTk5MjQtOWFlZDk5MDM4ZTYw%40thread.v2/0?context=%7b%22Tid%22%3a%22766317cb-e948-4e5f-8cec-dabc8e2fd5da%22%2c%22Oid%22%3a%2261aab78b-a857-4647-9668-83d4cca5de03%22%7d)
- [Friday 10am Class](https://teams.microsoft.com/l/meetup-join/19%3ameeting_MmU0OTg2YWMtOWQ0YS00YzA2LTk0NmQtMTczNjM0MTczNzY5%40thread.v2/0?context=%7b%22Tid%22%3a%22766317cb-e948-4e5f-8cec-dabc8e2fd5da%22%2c%22Oid%22%3a%2261aab78b-a857-4647-9668-83d4cca5de03%22%7d)

## Resources
- [Class Facebook page](https://www.facebook.com/groups/407619519952058/)
- [Assignment](ca.md)
- [A build of Infinite Forms](https://drive.google.com/file/d/1w24BcMAi6P1XmPc9D9ss6Lkro4KBvsMS/view?usp=sharing)
- [All about Infinite Forms](http://bryanduggan.org/forms)
- [A spotify playlist of music to listen to while coding](https://open.spotify.com/user/1155805407/playlist/5NYFsIFTgNOI93hONLbqNI)

## Contact me
* Email: bryan.duggan@dit.ie
* Twitter: [@skooter500](http://twitter.com/skooter500)
* [My website & other ways to contact me](http://bryanduggan.org)

## Previous years courses
- [2019-2020](https://github.com/skooter500/GE2-2019-2020)
- [2018-2019](https://github.com/skooter500/GE2-2018-2019)
	
## Assessment Schedule	
- Week 6 - CA proposal & Git repo
- Week 11 - Lab Test - 20%
- Week 13 - CA Submission & Demo - 50%

## Week 3

## Lab

You could use the lab class to work on your assignment - get 3D models imported and flying around or here is an exercise you can do that uses the pursue behaviour we worked on last week: 

Update your fork of the course repo to get the Pursue code we wrote in the class on Friday.

Create a new scene and make this predator prey simulation. The prey will follow a path until the predator comes into range. When the predator is is range the prey will attack the predator by shooting at it. It only shoots at the predator if it is inside the field of view. The predator will get close to the prey, but will flee from the prey if the prey attacks it. You can use colliders and then disable and enable certain behaviours to implement the simulation.

[![YouTube](http://img.youtube.com/vi/SqThPN_ogJE/0.jpg)](https://www.youtube.com/watch?v=SqThPN_ogJE)

To draw the "Lazers" you can use Debug.DrawLine from Update or you could use a LineRenderer

## Week 2 - Path Following, Flee, Pursue & Evade, Banking
- [Video of the class about Player Steering & Pursue](https://web.microsoftstream.com/video/d8be0d36-d9ab-4981-ba33-8d4e20697150?list=studio)

### Part 1 - Path following

Update your fork of the repo with the latest code from the master branch of my repo. To do this, cd to the folder where you have your fork cloned and type:

```bash
git checkout master
git pull upstream master
```

This will get the code we wrote last week. Open the Seek scene and you will see a boid that implements seek and arrive behaviours in the BigBoid.cs class. Today you can implement a path following behaviour for the boid.

Create a branch for your work today:

```bash
git checkout -b lab2
```

Check out this video:

[![Video](http://img.youtube.com/vi/eAfpnWI5jEI/0.jpg)](http://www.youtube.com/watch?v=eAfpnWI5jEI)

The scene contains a game object object with a script called ```Path``` attached. The path script implements the method ```OnDrawGizmos``` to draw lines between the waypoints on the path and to draw a sphere at each of the waypoints. The blue box is following the path. Today you can try and program this behaviour. 

- Implement the ```Path``` script that contains a ```public List<Vector3> waypoints``` containing the waypoints. The 0th waypoint should be the position of the path gameobject itself and the positions of the attached children should be used to set the subsequent waypoints. You can populate this list in ```Awake```. 
- Add a bool flag on the ```Path``` class called ```IsLooped``` to indicate whether the path should loop back to the 0th waypoint when the Boid reaches the last waypoint. If this flag is set to be false, then don't draw a line gizmo back to the 0th waypoint.
- In the scene, create a path using the ```Path``` script you made.
- Add a a public field to the BigBoid class for the Path and drag the Path you made onto this in the Unity editor. 
- Now write code for a behaviour in BigBoid called ```FollowPath``` to get the Boid to move from waypoint to waypoint on the path using Seek and Arrive. If the ```IsLooped``` flag is true on the path, then the Boid should Seek the 0th waypoint again when it reaches the last waypoint. If this flag is set to be false, then the Boid should Arrive at the last waypoint. You will need to add a method called FollowPath and a boolean flag to indicate that the FollowPath behaviour is enabled. 

### Part 2 - Flee

- Implement a behaviour called ```Flee``` that causes the BigBoid to flee from a target when the target comes in range. To do this, add a method called ```Flee``` and a bool flag called ```FleeEnabled``` on the BigBoid class. You will also have to update the ```CalculateForces``` method. Set up your scene with a target game object and move the target around the scene and make sure the Flee force gets activated when the target comes in range.

## Week 1 - Introduction to the course. Introduction to steering behaviours

## Lab
- No lab this week

## Lecture
- [Introduction slides](https://drive.google.com/file/d/1Egwa8jgpLUpQeNJcZ8RuU0Jrt-g65BjU/view?usp=sharing)
- [Steering Behaviours Slides (a bit out of date)](https://drive.google.com/file/d/1nQeVLqhNY1JvAZQK_BgMxUoVr7w1VPUE/view?usp=sharing)
- [Craig Reynolds original paper](https://www.red3d.com/cwr/papers/1999/gdc99steer.pdf)
- [Steering behaviours in Java](https://www.red3d.com/cwr/steer/)