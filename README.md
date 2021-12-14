# Love-Hurts

Overview:

Love Hurts is a vaporwave themed multiplayer fighting arcade game which consists of two human-animal hybrid characters who fight for their Senpai’s love. The character on the left is the human-dolphin hybrid, and the character on the right is the human-cat hybrid. Each player will battle in head-to-head combat until one of the characters is victorious or the timer runs out. 

![alt text](https://github.com/Matt01234/Love-Hurts/blob/main/Go_Screen.png?raw=true)

Watch Trailer Here: 
https://youtube/LXfIz0JFleE

Controls: 

Player 1 (human-dolphin) uses the joystick on the left side, attack button, and special attack button on the left. Player 2 (human-cat) uses the joystick on the right, attack button, special attack button on the right. Either Player 1 or Player two can use their joystick and select button to navigate through the ui. There is a special admin button underneath the arcade control board to access admin settings.

Title Screen:

![alt text](https://github.com/Matt01234/Love-Hurts/blob/main/title_screen.png?raw=true)

The title screen consists of the title of the game, the two characters on their corresponding side, and start button. Either player can select the start button using their joystick and pressing either of their select buttons to start the game. 

Game Scene:

Each player had a movement script that allowed each player to move left, right, jump, and crouch. There was a grounded script which would check to see if the current player was in contact with the ground to prevent infinite jumps. The health script was made to lower the health of the current player every time damage was inflicted. Each player had a hit box collider and a hurt box collider. The hit box always dealt the same damage per frame. However, for the special attack, the hit box was active for more frames compared to the regular attack in order to deal more damage.

End Scenarios:

The end scenes consist of the winning player and an exit button that either player can select and press to go back to the start screen.

![alt text](https://github.com/Matt01234/Love-Hurts/blob/main/Player_1_wins.png?raw=true)

If Player 1 wins, the human-dolphin character will take home Senpai.

![alt text](https://github.com/Matt01234/Love-Hurts/blob/main/Player_2_wins.png?raw=true)

If Player 2 wins, the human-cat character will take home senpai.

![alt text](https://github.com/Matt01234/Love-Hurts/blob/main/End_Screen.png?raw=true)

If both players draw, unfortunately, no one will be claiming Senpai.

Challenges faced: 

We were unsure what the goal of the game was. It was initially going to be a street fighter type game that would have had combo moves. In addition, one of the buttons was going to be a defense move. Instead, we changed it to be a special attack that deals more damage that has a 3 second cooldown to avoid spam. Many of the scripts had to be rewritten. Learning and creating the animation was complicated. Many things did not work right with the sprite animation and hit box animation. The characters are cross wired in the code since there was miscommunication on which side the players would be on in the arcade cabinet. However, this is not noticeable when playing the game inside the arcade machine. We were unable to create a leaderboard that would keep track of how many times players won with each character. The volume slider only affected the button sound effect rather than the entire sound system.

Miscellaneous: Video game play file is in with the code. 
