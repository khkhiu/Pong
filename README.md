# PONG
#### Video Demo:  https://youtu.be/fclLPQodTvQ
#### Description: Pong game for CS50's final project

***

<strong>Introduction</strong>

***

This is a simple pong game for the CS50's final project created using C# and unity. Game development was something that I have always wanted to try and CS50 gave me the perferct opportunity for me to explore the field. Pong was choosen as it is a simple game that I felt could be created relatively quickly. Furthermore, pong would bring my CS50 experience full-circle as I had created a pong game in Week 0 using Scratch.

Players will be greeted with a simple 'Start' screen when launching the game. The game will immediately start when 'Start Game' is choosen. Players use either the 'W' and 'S' keys or the arrow keys to control their paddles. The 'R' key will reset the scores and position of all assets in the game. The 'Q' key is used to pause the game. The 'ESC' key is used to quit the application. The first player to reach a score of 5 will win the game.

***

<strong>Explanation of project components</strong>

***
The following segment will explain how I created the project (in alphabetical order):

1. All assest seen on screen are created using the Unity editor. The Unity editors have built in functionality that allows users to create basic shapes and text, which I used to create all assets used for this project. A number of assests are also off-screen to constraint the paddles and square to the screen.

2. BounceSurface.CS and 'Bounce' components are used to control the how the square bounces off the walls and paddles. The angle of the bounce is randomised and speed is increased slightly to make the tryjectory of the square unpredictable. 

3. ComputerPaddle.CS is used to control the behaviour of the oppposing paddle. This was achieved by having the paddle track the movement of the square. Thus allowing the computer to effectively intercept the square.

4. GameManager.CS is the script that controls all functionality related to the game. This includes keeping track of player scores, resetting the game controlling, the pause menu and exiting the game.

5. MainMenu.CS controls the how the main menus fucntions, allowing players to access the game proper.

6. Paddle.CS dictates how fast the player's and computer's paddle move. It also ensures that the square can bounce-off both paddles and their respective starting positions.

7. PlayerPaddle.CS contains code that allows players to control their paddles.

8. Scoring.CS is used to update the score in the UI.

9. Square.CS controls how the square will bounce when hitting any given surface.