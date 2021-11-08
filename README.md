<h4>Added:</h4>

-Mechanic "Ultimate Strike XD" 
Description: 
Using mouse(RMB), player can destroy enemies on range.
cost: Player need to have enough tokens(3).
cooldown: After every 'shot', cool down starts(3s).

<h4>Setup:</h4>

- [Install Unity 2020.3.15f2](https://unity3d.com/get-unity/download/archive)
- [Fork Repository to your GitHub](https://github.com/Nordeus/jobfair21-frontend-challange)
- **Import Project** to Unity and make sure to select **PC platform (Win/Mac)** before opening 

<h4>Game Description:</h4>

We are working on a [platformer game](https://assetstore.unity.com/packages/templates/platformer-microgame-151055). Game Mechanics are implemented and working for the PC platform. For controls, we are using standard keys: wasd/arrows + space. You can try out the gameplay by opening MainScene, going into play mode, and hitting the play button.

The player can collect tokens by going through them and killing enemies by jumping on them. If the player collides with the enemy it will be game over. The same thing goes for a player falling from the platform. In order to win player needs to reach the end of the level without dying. 

<h4>Tech Description:</h4> 

The project consists of two scenes: **MainScene** (from which we start the game) and **LevelScene** (which is used for gameplay).

On the MainScene you will find **Main Menu Canvas** with the attached script: **MainMenuCanvas.cs** which you should use for implementing entering a username, high score, and starting the game.

On the LevelScene you will find **Level UI Canvas** with the attached script: **LevelCanvas.cs** which you should use for adding in-game UI, Lose, Win and Pause menu. 

**GameDatabase.cs** holds information regarding **CurrentUser** which you can use for displaying username, a number of collected tokens, killed enemies, or end score.

Gameplay is realized through scheduling events that are executed on Tick in Simulation. Feel free to explore this on your own. Relevant Classes: **Simulation.Event<T>, Simulation**, etc. 

All resources needed for the UI can be found in the folder: **Assets/Resources**

<h4>End Goal:</h4> 

- [Video of completed game UI implementation](https://drive.google.com/file/d/1a0Sw97lHh7eRRrzLEMzPh8SWcipBAmtG/view?usp=sharing)
- [Full Requirments & Details for implementation are in this doc](https://docs.google.com/document/d/1X6sJCYW94YOW_BTJ_G9-5dqPlXWPDp-OFdcrqEkS8gM/edit)

<h4>Submitting results:</h4>

- You should send an e-mail to jobfair21-frontend-challenge@nordeus.com with a link to the forked Github project
- We will go through git history to review your changes and evaluate code
- We will play the game to make sure all the functionalities are there

<h4>Additional Resources:</h4>

- [job fair gameplay.mp4](https://drive.google.com/file/d/1a0Sw97lHh7eRRrzLEMzPh8SWcipBAmtG/view?usp=sharing)
- [Screen Previews](https://drive.google.com/drive/folders/175QLrnE8aIzhR2NF0tb64Ec8NFekZrkc?usp=sharing)

<h4>Bonus Points:</h4>

- Let's be honest - this game is kinda fun, but there are a lot of opportunities to make it much better
- Feel free to add more features, new enemies, weapons, new levels, different end conditions
- Does UI support different aspect ratios? Everything from 4:3 to 21:9? 
- Make it mobile? Go crazy and earn some bonus points! 
- If you decide to go wild - make sure to tell us what have you done so we make sure to check it out! 


**Good luck!**



