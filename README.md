###Leap Motion : Space design (preconception phase)


Application by Pierre Raimbaud

Mixed reality class - PhD Pablo Figueroa (First demo)


https://docs.google.com/document/d/15ROZUhbgSzlI_U6LjRrmvcnpmOcXqEiJyDorLrXWkJQ/edit?usp=sharing


Device used in the demo: Leap Motion
Technologies used: Unity, C# script, Leap Motion plugin for Unity

Demo used as base for this new new: Leap_Motion_Core_Assets_ 4.4.0.unitypackage
Scene used as a base: Assets\LeapMotion\Core\Examples\Capsule Hands (Desktop).unity

Link to the original demo in Github: https://github.com/pierreraimbaud/OriginalDemoUnityAssetLeapMotion (simple Unity project where Leap_Motion_Core_Assets_ 4.4.0.unitypackage has been used, importing all the assets

Link to the new demo in Github: https://github.com/pierreraimbaud/LeapMotionSpaceDesign

How to install and make it run  (technically) + lab place

Download or clone the github repository.
Install Unity3D on your computer.
Install the drivers for the LeapMotion.
Install the plugins for the LeapMotion.
Open the project in Unity3D.
Build it for your platform.
Plug the LeapMotion in a computer that also has the drivers for the LeapMotion.
Run the .exe and enjoy the app.

The app has been installed and shown during the Open lab sessions in the computer (gamer computer with some fancy lights), next to the “manequí” and below the “telón negro a la izquierda” (and also on my computer).


Explanations (how to use it)

Run the application.
Put your 2 hands (opened) approx 20 cm above the Leap Motion.
Touch the virtual ground with the right hand (opened), in particular with your thumb.
A cube appears.
If you want to cancel it, close your right hand.
If you want to confirm it, close your left hand.
Repeat the operation. Observe that the “cost” augments.
If you want to change to another form for creation, touch (with whatever hand) : cylinder or sphere
Then repeat the operation of creation.
Close the app when you want.


Modifications done in the new demo


Modification have been done in the original scene Assets\LeapMotion\Core\Examples\Capsule Hands (Desktop).unity

It’s the current scene that has to been built for playing the new demo.

We had new materials at : Assets\Materials

We had new a skybox material: 360DutchFree360\Volume_1\01_Standard_Skies_Without_Suns\Materials (downloaded asset)

New scripts at :Assets\LeapMotion\Core\Scripts\NewScriptsForDemo
DetectionGroundHandTouch: for gesture detection and ground touch detection
ChangeCurrentForm: for cube/cylinder/sphere touch detection

To resume:

We add objects: cube, sphere, cylinder, the instruction texts and images, the cost text, the planes.

We add the detection of the two different gestures (closed, thumb) on both hands (or 1 one only for the thumb).

We add collision detection between the ground and the hands and between the hands and the forms.


