# QuickOVRHandTracking

# Install

Go to _Window > Package Manager_ and click on the ‘+’ symbol in the top left corner of the new window. Select _Add package from git URL…_

![](/Documentation~/img/install/00.png)

A text field will open. Copy and paste the following URL, and then click on _Add_. 

https://github.com/eventlab-projects/com.quickvr.quickbase.git

__Now be patient__. It seems that Unity does not produce any kind of visual feedback and it looks like nothing is happening, but the package is downloading. Then it will be automatically imported. 

Once this process is done, the following window may appear, depending on the settings of your project. 

![](/Documentation~/img/install/01.png)

If you’re starting a new project, just select _Yes_ and ignore the following sentence. Otherwise, if you are introducing the QuickVR library in an existing project and you want to keep support for legacy’s Unity input system, select _No_, and go to _Edit > Project Settings > Player_ and set _Active Input Handling_ to _Both_. 

If you want, you can install some samples by going to _Window > Package Manager_. You’ll see that a new tab called __EventLab__ has appeared, containing the package __QuickVR.QuickBase__. 

![](/Documentation~/img/install/02.png)

Select _Import_ on those samples you want to install. The samples are installed in _Assets > Samples_.  

Done! Follow the documentation on the _Samples_ folder and the documentation on the wiki to learn how to configure your application for VR and start using the library. 
