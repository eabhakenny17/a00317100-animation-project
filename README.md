# Animation Project

This report details the steps I took to carry out this MakeHuman -> Blender -> Unity modelling and animation project.

## Step 1: Create a character in Makehuman
I used MakeHuman to create a customised 3D character model with clothes. I used MakeHuman to edit details of the model such as age, body part sizes and body part ratios.
<img width="1849" height="1079" alt="image" src="https://github.com/user-attachments/assets/884bb11a-44b1-4b6f-9dc3-437ab32130a5" />

## Step 2: Rig and Weight in Blender
I created an empty Blender file and imported the 3D model from MakeHuman. There were initial complications caused by a lack of textures. This was resolved by using Blender's "Find Missing File" function. I also had to rename all UV maps so that all had the same name so that I could keep everything on one mesh.

<img width="431" height="264" alt="image" src="https://github.com/user-attachments/assets/a0326316-9b42-4eb6-a3e9-5ca60601f14a" />

To rig the model, I used bones to create a full armature. The bones are parented appropriately so that they can effect each other. For example, if you move the left upper arm bone, the left lower arm and hand bones will also be moved. Joints can be rotated. The root bone is an impactful bone located below the model. If the root bone is moved the model moves coordinates without any bone changing position.

<img width="986" height="456" alt="image" src="https://github.com/user-attachments/assets/4e77ad60-959a-4f3e-a7e3-aac1d5ed18f6" />

I used the automatic weights option to automatically assign bone deformation weights to the mesh. Thousands of vertices were assigned incorrectly or unassigned to any bone so I used vertex groups in Edit Mode and Weight Paint Mode to manually correct any weighting issues.

<img width="1830" height="750" alt="image" src="https://github.com/user-attachments/assets/d110d06d-7069-4dc1-adbc-b9671fb3fee7" />
<img width="1783" height="699" alt="image" src="https://github.com/user-attachments/assets/9fad5f41-b633-4d9e-a602-65c57b389834" />

Below is a screenshot of the model in Pose Mode.
<img width="1852" height="1078" alt="image" src="https://github.com/user-attachments/assets/281ab8ae-5bc7-467d-abdf-8aedfb361720" />

## Step 3: Animations in Blender
I created several custom animations in Blender. I used the 'I' shortcut to create initial frames and used auto-keying afterward the initial frame. The bones were altered in Pose Mode. While creating animations I noticed several weighting issues and fixed them as they appeared.

Flip animation:
<img width="1179" height="1026" alt="image" src="https://github.com/user-attachments/assets/75b72c98-e91b-4bd0-b5cc-28ff19a10211" />
Jumping animation:
<img width="1394" height="1019" alt="image" src="https://github.com/user-attachments/assets/1681840d-5558-4ef8-95c7-996929df3103" />
Walking animation:
<img width="1426" height="990" alt="image" src="https://github.com/user-attachments/assets/90689ddd-0e7b-4eaa-951a-d2eb06cf9aa9" />
Wave animation:
<img width="1284" height="973" alt="image" src="https://github.com/user-attachments/assets/2e6c21c2-3301-4fe6-b307-07ad410f787f" />

### Video of model, rig and animation in Blender:
[!Watch the video](https://github.com/eabhakenny17/a00317100-animation-project/blob/main/videos/blender_anim_rig.mp4)


## Step 3: Export model from Blender and import into Unity
After completing the model on Blender I exported the .fbx file with textures. I used the 'Copy' option for path mode in order to ensure all textures would be exported on the model. I only exported the armature, mesh and animations.

<img width="242" height="460" alt="image" src="https://github.com/user-attachments/assets/05fe9a84-8e84-4427-bb04-fcf168dd61dd" />

In Unity, I imported the Unity template 'First Person + Third Person | Character Controllers' package, including a scene 3D objects to move around in and a moveable player character. I replaced the built-in player character with my model and maintained the character controller and animator. I added my custom animations to the animator.

<img width="1180" height="373" alt="image" src="https://github.com/user-attachments/assets/038b73b9-d557-43e2-bc8b-2bf7962b280f" />
I connected the wave animation to the in-use animator and added a trigger condition. I configured the custom wave animation to activate if the user presses 'q'.
<img width="618" height="621" alt="image" src="https://github.com/user-attachments/assets/2794d388-d805-4f7e-b31d-5d4b3ccc6d03" />
<img width="453" height="490" alt="image" src="https://github.com/user-attachments/assets/ad3d6910-a914-4874-95fe-f20905633389" />

I created a blend tree for the flip animation, blending between the idle and flip animation. I configured the flip animation to activate if the user presses 'f'. I created a method in the same script to trigger an audio to be played and added this function as an event during the animation.

<img width="1193" height="443" alt="image" src="https://github.com/user-attachments/assets/3f58cc33-f1f5-4d1a-a44c-10c2dcd7ed26" />
<img width="1060" height="861" alt="image" src="https://github.com/user-attachments/assets/05dc4c8c-6768-4d3c-9164-6eb6f1970ede" />
<img width="733" height="668" alt="image" src="https://github.com/user-attachments/assets/5c6fef4d-b8dd-4ae9-970e-b2991b396e65" />

### Video of model imported into Unity:
[!Watch the video](https://github.com/eabhakenny17/a00317100-animation-project/blob/main/videos/model_movement_in_unity.mov)

### Video of wave animation in Unity:
[!Watch the video](https://github.com/eabhakenny17/a00317100-animation-project/blob/main/videos/wave_animation_custom.mov)

### Video of flip Blend Tree in Unity:
[!Watch the video](https://github.com/eabhakenny17/a00317100-animation-project/blob/main/videos/flip_blendtree_metachannel.mov)

## Step 4: Ragdoll in Unity
I added a ragdoll to the model. I added a Rigidbody to the required bones in Unity and set each Rigidbody to be kinematic. 

<img width="1829" height="692" alt="image" src="https://github.com/user-attachments/assets/0fe4b5f5-6340-419a-81f1-ac538c081d6b" />
I created a script to trigger the ragdoll if the user presses 'r'.

<img width="675" height="1013" alt="image" src="https://github.com/user-attachments/assets/6c20db7b-a7cb-43ad-9068-46a3501173aa" />
<img width="1545" height="484" alt="image" src="https://github.com/user-attachments/assets/05e14321-ee05-48c6-af4c-e4e8bef6c798" />

### Video of ragdoll in Unity:
[!Watch the video](https://github.com/eabhakenny17/a00317100-animation-project/blob/main/videos/flip_blendtree_metachannel.mov)

## Sources:
https://www.youtube.com/watch?v=MF1qEhBSfq4
https://www.youtube.com/watch?v=4QuPlKzdq14&t=1s
https://docs.unity.com/en-us/engine/6000.6/manual/animation-section/animation-mecanim/animation-clips/animation-editor-guide/script-animation-window-event
https://docs.unity3d.com/6000.2/Documentation/Manual/class-BlendTree.html
https://www.youtube.com/watch?v=xyt26Zyf6BQ&t=26s

## AI disclaimer:
I used Hy4 Flash through the local LLM provider OpenCode to help me plan implementation and troubleshoot issues importing from Blender to Unity (eg. missing textures and incorrectly assigned bones).
