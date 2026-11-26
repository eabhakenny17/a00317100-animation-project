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

<img width="1852" height="1078" alt="image" src="https://github.com/user-attachments/assets/281ab8ae-5bc7-467d-abdf-8aedfb361720" />

## Step 3: Animations in Blender
