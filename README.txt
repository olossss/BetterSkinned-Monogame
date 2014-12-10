Requirements:
	Visual Studio 2013 (may work with lower, but I haven't tested.)
	Requires XNA 4.0 Refresh - https://msxna.codeplex.com/releases/view/117230

Current Supported Platforms:
	Windows 8.1
	Windows Phone 8.1
	Windows Desktop

Instructions to add to project:
	Open up and compile Animation Pipeline
	Open up and compile AnimationAux Monogame
	In your Project, refrence AnimationAux.dll
	In your Content Project, refrence AnimationPipeline.dll

To add additional platforms:
For easability of adding platforms, I have setup the project using Shared Code Projects. To quickly add a new platform, follow these steps
	Install the Shared Project Reference Manager extension - https://visualstudiogallery.msdn.microsoft.com/315c13a7-2787-4f57-bdf7-adae6ed54450
	
	Add a new Class Library to the solution which targets that platform
	
	Right Click on the Class Library and select Properties
	Under Library, ensure Assembly Name and Default Namespace is set to "AnimationAux"
	Click Assembly Information and blank out every field
	Set Title to "AnimationAux"
	Set First Bar of Assembly Version to "1"
	Set First Bar of File Version to "1"
	Set Neutral Language to "(None)"
	
	Refrence The "MonoGame.Framework" for that Platform 
	Right click on Refrences and select "Add Shared Project Refrence. Add a Refrence to AnimationAux.Shared
	
	Build the Class Library

Code Sample to use in you're setup and in project
	Add an FBX to your Content Project
	  Set its Content Processor to "Animation Processor"

	Add this code to the top:
	  `private AnimatedModel animatedModel = null;`

	Inside LoadContent:
	  `animatedModel = new AnimatedModel("contentName");
	  animatedModel.LoadContent(Content);
		
	  AnimationClip clip = animatedModel.Clips[0];
	  AnimationPlayer player = animatedModel.PlayClip(clip);
		player.Looping = true;`

	Inside Update:
	  `animatedModel.Update(gameTime);`
		
	Inside Draw:
	  `dance.Draw(graphics.GraphicsDevice, Camera.View, Camera.Projection, Matrix.Identity);`
		
		
	Feel free to also check out the XNA Original project also included in the repo
		
Credit
Original XNA Library: http://metlab.cse.msu.edu/betterskinned.html

Special Thanks
	RyamBaCo - https://monogame.codeplex.com/discussions/520341
	  If he hadn't supplied me a version of his code with it working, I would have had a much harder time getting this to work.

License
	Royalty Free Soldier Walk Model and Animation from Mixamo
	All content and source code downloaded from this page are bound by the [Microsoft Public License (Ms-PL)](http://www.opensource.org/licenses/MS-PL).
