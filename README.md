# Love-Hurts

Trailer: https://youtu.be/LXfIz0JFleE

Controls: 
Player 1 uses wasd to move, z for attack, and x for special attack
Player 2 uses arrow keys to move, n for attack, and m for special attack
Press I to open settings 

Objectives:
Each player will fight for Senpai before time runs out. The player that defeats their opponent will win.

How it was made:
Each player had a movement script that allowed each player to move left, right, jump, and crouch. There was a grounded script which would check to see if the current player was in contact with the ground to prevent infinite jumps. The health script was made to lower the health of the current player every time damage was inflicted. Each player had a hit box collider and a hurt box collider. The hit box always dealt the same damage per frame. However, for the special attack, the hit box was active for more frames compared to the regular attack in order to deal more damage.   

Weekly goals:
Week 1 - basic control was added such as moving and jumping (boxes were used as placeholders)
Week 2 - ground colliders were added to prevent infinite jumping
Week 3 - Physics were fine tuned.
Week 4 - Both players could move, and additional scenes were added. Animation of player 1 hit box was created. 
Week 5 - Hit box scripts and health scripts were created. Animation of player 2 hit box was created.
Week 6 - Health bar decreased when hit boxes and hurt boxes would collide. Animation of both players standing and moving positions created.
Week 7 -  Countdown timer and round time was implemented. Animation of both players' attacks were created. Button scripts were added.
Week 8 - Camera movement was added to follow players and zoom in and out, sound effects were added, and bugs were fixed.

Challenges faced: 
We were unsure what the goal of the game was. It was initially going to be a street fighter type game though it turned into a more basic fighting game. Combo moves would have taken additional time. At first the second button was going to be a defense. However, we changed it to be a special attack that deals more damage but less spammy. Many scripts had to be redone. Learning the animation was complicated. Many things did not work right with the animation of the sprites and the hit boxes. The characters are cross wired since there was miscommunication on which side the players would be on the arcade cabinet. We were unable to create a leaderboard. The volume slider only affected the button sound effect. 

Extra:
Video and photos can be downloaded with the code
