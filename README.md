# Unity-Panorama-Viewer
A panoramic image viewer based on Unity


This is a simple panoramic image viewer base on Unity game engine.

Basically, this project's work flow is to import 2d panoramic images, change their texture shape in Unity from 2D to cube.

Then use the cube image as Cubemaps in the skybox/Cubemap shaders.

Attach the each material to a sphere object.

Finally, view the material from the center of the sphere.

![plot](https://github.com/YiYuGit/Unity-Panorama-Viewer/blob/main/Assets/PanoViewerExample.png)

User can switch image, change view direction and zoom in and out.

User can can also take screen shot for viewing part of the panorama.

The sample images come from https://pixexid.com/search/360%20panoramic

The Website announced: You can download free 360 panoramic pictures and use them for commercial or personal projects, free equirectangular 360 degree images to use and share anywhere.

If you don't want to use the whole project, just import the PanoViewPack.unitypackage
