<h1>Leap Motion : Space design (preconception phase)</h1>


<h2>Application by Pierre Raimbaud</h2>

<h2>Mixed reality class - PhD Pablo Figueroa (First demo)</h2>


<h3>Device used in the demo: Leap Motion</h3>
<h3>Technologies used: Unity, C# script, Leap Motion plugin for Unity</h3>

Demo used as base for this new new: Leap_Motion_Core_Assets_ 4.4.0.unitypackage
Scene used as a base: Assets\LeapMotion\Core\Examples\Capsule Hands (Desktop).unity

<h3>Link to the original demo in Github</h3>: https://github.com/pierreraimbaud/OriginalDemoUnityAssetLeapMotion (simple Unity project where Leap_Motion_Core_Assets_ 4.4.0.unitypackage has been used, importing all the assets of the package)

<h3>Link to the new demo in Github</h3>: https://github.com/pierreraimbaud/LeapMotionSpaceDesign

<h3>How to install and make it run  (technically) + lab place</h3>

-Use the project (building it)
-Download or clone the github repository.
-Install Unity3D on your computer.
-Install the drivers for the LeapMotion.
-Install the plugins for the LeapMotion.
-Open the project in Unity3D.
-Build it for your platform.
-Plug the LeapMotion in a computer that also has the drivers for the LeapMotion.
-Run the .exe and enjoy the app.

The app has been installed and shown during the Open lab sessions in the computer (gamer computer with some fancy lights), next to the “manequí” and below the “telón negro, a la izquierda” (and also on my computer).

For Windows: download the Build folder and run the .exe

<h3>Explanations (how to use it)</h3>

-Run the application.
-Put your 2 hands (opened) approximately 20 cm above the Leap Motion.
-Touch the virtual ground with the right hand (opened), in particular with your thumb.
-A cube should appear (or maybe another form in case of having been touching the forms in the background).
-If you want to cancel it, close your right hand.
-If you want to confirm it, close your left hand.
-Repeat the operation if you want (creation, confirmation). Observe that the “cost” augments (and does not augment when you cancel your creation).
-If you want to change to another form for creation, touch (with whatever hand) the cylinder or the sphere that are in the background.
-Then repeat the operation of creation.
-Close the app when you want.


<h3>Modifications done in the new demo</h3>


Modification have been done in the original scene Assets\LeapMotion\Core\Examples\Capsule Hands (Desktop).unity

It’s the scene that has to been built for playing the new demo.

We had new materials at : Assets\Materials (for the forms in the back)

We had new a skybox material: 360DutchFree360\Volume_1\01_Standard_Skies_Without_Suns\Materials (downloaded asset)

New scripts at :Assets\LeapMotion\Core\Scripts\NewScriptsForDemo
DetectionGroundHandTouch: for gesture detection and ground touch detection
ChangeCurrentForm: for cube/cylinder/sphere touch detection

To resume:

We add (3D) objects: cube, sphere, cylinder, the instruction texts and images, the cost text, the plane.

We add the detection of the two different gestures (closed hand, thumb) on one or two hands and the two hands are differentiated.

We add collision detections between the ground and the hands and between the hands and the forms.
