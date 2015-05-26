LinqPadVisulaizer
=================

Forked from https://code.google.com/p/linqpadvisualizer/

This versions adds support to customize object serialization depth.


## How to Use ##
These instructions are tested with Visual Studio 2012 and Linqpad 4.55, but, should work for newer visual studio versions as well.
 
- Copy LinqPad.exe besides devenv.exe (For VS 2012 it should be C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE
- Unzip contents of Binaries\LinqPadVisualizer-1.0.2.zip to C:\Users\[User]\Documents\Visual Studio 2012\Visualizers folder.
- Restart visual studio.
- Open a project that you want to debug and start debugging, when you want to run the visualizer go to the watch pane and enter the variable you want to inspect like this: new System.WeakReference(variable_to_inspect) (this is because of limitation of Visual Studio so we can attach the visualizer to any type)
- Then click on the downarrow on the right side of the row and a form with the dump should popup
if using VS2010 you have two options - LINQPad visualizer and LINQPad visualizer JS. The first one uses normal serialization and can therefore only be used on objects which have Serializable on them. Second one uses JSON.NET to serialize objects, but in the process you lose type information. However, you can use it on any object.